using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FankyRecords.C_entidad;
using FankyRecords.C_negocio;
using FankyRecords.C_presentacion.Modales;

namespace FankyRecords.C_presentacion.Administrador
{
    public partial class registrarVentas : Form
    {
        private readonly NegocioVentas CN_Ventas;
        private readonly NegocioTipoDOc CN_TipoDoc;
        private Clientes clienteSeleccionado;

        //decimal  sumaSubtotal = 0;
        public registrarVentas()
        {
            CN_Ventas= new NegocioVentas();
            CN_TipoDoc = new NegocioTipoDOc();
            InitializeComponent();
            this.cbTipoDoc.SelectedIndex = 0;
            // Inicializar el temporizador
            delayTimer = new System.Windows.Forms.Timer();
            delayTimer.Interval = 2000; // Ajusta el intervalo según tus necesidades (en milisegundos)
            delayTimer.Tick += DelayTimer_Tick;
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarProducto();
        }

        private void AgregarProducto()
        {
            //Verificamos que todos los campos estésn completos.
            if (C_negocio.Validaciones.EstaVacio(cbTipoDoc.Text) ||
               C_negocio.Validaciones.EstaVacio(TBNroDocumento.Text) ||
               C_negocio.Validaciones.EstaVacio(TBbuscarProducto.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas agregar el producto: " + TBProducto.Text + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool prodExiste = false;
                    decimal subtotal = numCantidad.Value * Convert.ToDecimal(TBPrecio.Text);
                    decimal cantidadTotal = 0;
                    decimal precioVentaActual = 0;

                    foreach (DataGridViewRow fila in listadoVentaProducto.Rows)
                    {
                        if (fila.Cells["Codigo"].Value != null && fila.Cells["Codigo"].Value.ToString() == TBbuscarProducto.Text)
                        {
                            // El producto ya existe, actualizar cantidad y subtotal
                            prodExiste = true;
                            decimal cantidadExistente = Convert.ToDecimal(fila.Cells["Cantidad"].Value);
                            cantidadTotal = cantidadExistente + numCantidad.Value;


                            precioVentaActual = Convert.ToDecimal(TBPrecio.Text);

                            // Actualizar la celda de cantidad
                            fila.Cells["Cantidad"].Value = cantidadTotal.ToString("N2");
                            // Actualizar la celda de subtotal
                            fila.Cells["Subtotal"].Value = cantidadTotal * precioVentaActual;
                            // Actualizar la celda de Precio_Venta
                            fila.Cells["Precio_Venta"].Value = precioVentaActual.ToString("N2");

                            CalcularTotal();
                            MessageBox.Show("La cantidad del producto " + TBProducto.Text + " se actualizó correctamente.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                            return;
                        }
                    }

                    if (!prodExiste)
                    {
                        listadoVentaProducto.Rows.Add(new object[]
                        {
                            TBbuscarProducto.Text,
                            TBProducto.Text,
                            Convert.ToDecimal(TBPrecio.Text).ToString("N2"),
                            numCantidad.Value.ToString(),
                            DTFechaVenta.Text,
                            subtotal.ToString("N2")
                        });

                        CalcularTotal();
                        MessageBox.Show("El producto: " + TBProducto.Text + " se agregó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Limpiar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
        }

        private void CalcularTotal()
        {
            decimal sumaTotal = 0; // Calcular la suma total al final

            // Calcular de nuevo el total
            foreach (DataGridViewRow filaCalculada in listadoVentaProducto.Rows)
            {
                sumaTotal += Convert.ToDecimal(filaCalculada.Cells["Subtotal"].Value);
            }

            TBTotalAPagar.Text = sumaTotal.ToString("N2");
        }

        private void CargarVenta()
        {
            List<Venta> registrarVenta = CN_Ventas.ListarVentas();
            listadoVentaProducto.DataSource = registrarVenta;
        }

        private void RegistrarVenta()
        {
            if (C_negocio.Validaciones.EstaVacio(TBTotalAPagar.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TipoDoc tipoDocSeleccionado = new TipoDoc
            {
                ID_Tipo_Doc = Convert.ToInt32(cbTipoDoc.SelectedValue),
                Descripcion = cbTipoDoc.Text
            };
            // Crear objeto productos
            /*Productos producto = new Productos
            {
                PrecioVenta = Convert.ToDecimal(TBPrecio_Venta.Text),
                PrecioCompra = Convert.ToDecimal(TBprecio_compra.Text),
                Stock = Convert.ToInt32(cantProd.Text)
            };*/
            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuarios usuarioSeleccionado = new Usuarios
            {
                ID_usuarios = SesionUsuario.UsuarioActual.ID_usuarios,
                Nombre = SesionUsuario.UsuarioActual.Nombre,
                Apellido = SesionUsuario.UsuarioActual.Apellido,
                Obj_rol = SesionUsuario.UsuarioActual.Obj_rol
            };

            // Asignar el usuario al objeto venta
            Venta registrarVenta = new Venta
            {
                MontoTotal = Convert.ToDecimal(TBTotalAPagar.Text),
                FechaVenta = Convert.ToDateTime(DTFechaVenta.Text),
                Obj_clientes = clienteSeleccionado,
                Obj_usuarios = usuarioSeleccionado,
                Obj_Tipo_Doc = tipoDocSeleccionado
            };

            registrarVenta.Obj_Tipo_Doc = tipoDocSeleccionado;
            if (cbTipoDoc.SelectedItem is OpcionCombo opcionSeleccionada)
            {
                registrarVenta.Obj_Tipo_Doc.ID_Tipo_Doc = (int)opcionSeleccionada.Valor;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de documento válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas registrar la compra?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    CN_Ventas.GuardarVenta(registrarVenta);

                    MessageBox.Show("La compra del producto: " + this.TBbuscarProducto.Text + " " + this.TBProducto + " se registró correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Recargar datos y limpiar formulario
                    CargarVenta();
                    Limpiar();
                    TBTotalAPagar.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
        }


        private void TBRecibe_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsDecimal(e); 
        }

        private void Txtnumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsNumero(e);
        }

        private void Txtpalabras_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsConcatenacionTexto(e);
        }



        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
            //delayTimer.Stop();
            RegistrarVenta();

        }

        private readonly System.Windows.Forms.Timer delayTimer;
        private bool permitirTextChanged = true; // Variable para controlar la ejecución del evento

        private void TBRecibe_TextChanged(object sender, EventArgs e)
        {
            if (!permitirTextChanged) return; // Si permitirTextChanged es falso, salimos del evento

            delayTimer.Stop(); // Detener el temporizador si ya estaba corriendo
            delayTimer.Start(); // Iniciar el temporizador
        }
        private void DelayTimer_Tick(object sender, EventArgs e)
        {
            delayTimer.Stop();

            decimal recibe, totalPagar;

            // Intenta convertir los valores, manejando posibles errores
            if (!decimal.TryParse(TBRecibe.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out recibe) ||
                !decimal.TryParse(TBTotalAPagar.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out totalPagar))
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos en el campo 'Recibe'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBCambio.Clear();
                return; // Salir de la función si hay errores de conversión
            }

            if (recibe >= totalPagar)
            {
                decimal cambio = recibe - totalPagar;
                TBCambio.Text = cambio.ToString(CultureInfo.InvariantCulture); // Usar CultureInfo para consistencia
            }
            else if (string.IsNullOrEmpty(TBRecibe.Text))
            {
                TBCambio.Clear();
            }
            else
            {
                MessageBox.Show("Debe ingresar un número mayor o igual al total", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBCambio.Clear();
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new MDProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TBbuscarProducto.Text = modal.Productomd.Codigo.ToString();
                    TBProducto.Text = modal.Productomd.Nombre.ToString();
                }
                else
                {
                    TBbuscarProducto.Select();
                }
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            using (var modal = new MDCliente())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    clienteSeleccionado = modal.Clientemd; // Captura el proveedor seleccionado
                    TBNombreCompleto.Text = modal.Clientemd.Nombre.ToString()+""+ modal.Clientemd.Apellido.ToString();
                    TBNroDocumento.Text = modal.Clientemd.Documento.ToString();
                }
                else
                {
                    TBNroDocumento.Select();
                }
            }
        }


        private void Limpiar()
        {
            // limpia campos
            TBPrecio.Clear();
            numCantidad.Value = 1;
            TBNombreCompleto.Clear();
            TBbuscarProducto.Clear();
            TBNroDocumento.Clear();
            TBStock.Clear();
            TBProducto.Clear();
            cbTipoDoc.SelectedIndex = -1;  // Deselect the ComboBox
        }

        private void registrarVentas_Load(object sender, EventArgs e)
        {
            CargarCombo();
            // Obtén la fecha actual del sistema
           /* DateTime fechaActual = DateTime.Now.Date;

            // Configura la propiedad Text del DateTimePicker a la fecha actual
            DTFechaVenta.Value = fechaActual;

            // Configura el MinDate y MaxDate para que sean la fecha actual
            DTFechaVenta.MinDate = fechaActual;
            DTFechaVenta.MaxDate = fechaActual;*/
        }

        private void CargarCombo()
        {
            cbTipoDoc.Items.Clear();

            // Obtener todas las categorías
            List<TipoDoc> listaTipoDOc = CN_TipoDoc.ListarTipoDoc();

            // Filtrar 
            var tipoDocumentos = listaTipoDOc.Where(c => c.Descripcion != null).ToList();

            // Configurar propiedades del ComboBox
            cbTipoDoc.DisplayMember = "Texto";
            cbTipoDoc.ValueMember = "Valor";

            foreach (TipoDoc item in tipoDocumentos)
            {
                cbTipoDoc.Items.Add(new OpcionCombo() { Valor = item.ID_Tipo_Doc, Texto = item.Descripcion });
            }

            if (cbTipoDoc.Items.Count > 0)
            {
                cbTipoDoc.SelectedIndex = 0;
            }
        }

        private void listadoVentaProducto_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 7)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.basura.Width;
                var h = Properties.Resources.basura.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.basura, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void listadoVentaProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (listadoVentaProducto.Columns[e.ColumnIndex].Name == "BtnEliminar")
            {
                int indice = e.RowIndex;

                if (indice >= 0 && listadoVentaProducto.Rows[indice].Cells["Codigo"].Value != null)
                {
                    listadoVentaProducto.Rows.RemoveAt(indice);
                    CalcularTotal();
                }
                else
                {
                    MessageBox.Show("Debe agregar un producto para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
