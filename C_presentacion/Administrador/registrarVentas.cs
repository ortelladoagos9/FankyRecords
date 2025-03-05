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
using FankyRecords.C_presentacion.Modales;
using FankyRecords.C_entidad;
using FankyRecords.C_negocio;

namespace FankyRecords.C_presentacion.Administrador
{
    public partial class registrarVentas : Form
    {
        private bool permitirTextChanged = true; // Control de evento
        private readonly System.Windows.Forms.Timer delayTimer;
        private readonly NegocioVentas CN_Ventas;
        private readonly NegocioTipoDOc CN_TipoDoc;
        private Usuarios usuariosActual;

        public registrarVentas(Usuarios usuarioObj = null)
        {
            InitializeComponent();
            // Inicializar el temporizador
            delayTimer = new System.Windows.Forms.Timer();
            delayTimer.Interval = 2000; //2 seg de espera antes de procesar el cálculo
            delayTimer.Tick += DelayTimer_Tick;

            usuariosActual = usuarioObj;
            CN_Ventas = new NegocioVentas();
            CN_TipoDoc = new NegocioTipoDOc();
        }

        private void registrarVentas_Load(object sender, EventArgs e)
        {
            CargarCombo();

            DTFechaVenta.MaxDate = DateTime.Now.Date;  // Establece el máximo en hoy (sin hora)
            DTFechaVenta.MinDate = DateTime.Now.Date;  // Establece el mínimo en hoy (sin hora)
            DTFechaVenta.Value = DateTime.Now.Date;    // Asegura que la fecha seleccionada sea hoy

            // Solo mostrar la fecha en la vista
            DTFechaVenta.Format = DateTimePickerFormat.Short;

            TBRecibe.Select();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarProducto();
        }

        private void AgregarProducto()
        {
            //Verificamos que todos los campos estésn completos.
            if (C_negocio.Validaciones.EstaVacio(cbTipoDoc.Text)
                || C_negocio.Validaciones.EstaVacio(TBNroDocumento.Text)
                || C_negocio.Validaciones.EstaVacio(TBNombreCompleto.Text)
                || C_negocio.Validaciones.EstaVacio(TBCodigoProd.Text)
                || C_negocio.Validaciones.EstaVacio(TBNombreProd.Text)
                || C_negocio.Validaciones.EstaVacio(TBDescripcion.Text)
                || C_negocio.Validaciones.EstaVacio(TBPrecio.Text)
                || C_negocio.Validaciones.EstaVacio(TBStock.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas agregar el producto: "
                    + TBNombreProd.Text + " " + TBDescripcion.Text + "?", "Confirmación", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool prodExiste = false;
                    decimal subtotal = numCantidad.Value * Convert.ToDecimal(TBPrecio.Text);
                    int cantidadTotal = 0;
                    
                    //recorre cada fila del datagrid
                    foreach (DataGridViewRow fila in listadoVentaProducto.Rows)
                    {
                        //si la celda codigo tiene datos y es igual al TBCodigoProd entonces el producto ya existe
                        if (fila.Cells["Codigo"].Value != null && fila.Cells["Codigo"].Value.ToString() == TBCodigoProd.Text)
                        {
                            //actualiza cantidad y subtotal
                            prodExiste = true;
                            int cantidadExistente = Convert.ToInt32(fila.Cells["cantidad"].Value);
                            cantidadTotal = (cantidadExistente + Convert.ToInt32(numCantidad.Value));

                            // Actualizar la celda de cantidad
                            fila.Cells["cantidad"].Value = cantidadTotal;
                            // Actualizar la celda de subtotal
                            fila.Cells["subtotal"].Value = (cantidadTotal * Convert.ToDecimal(TBPrecio.Text)).ToString("N2");
                            
                            CalcularTotal();
                            MessageBox.Show("La cantidad del producto "
                                + TBNombreProd.Text + " " + TBDescripcion.Text + " se actualizó correctamente.", "Actualización", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                            return;
                        }
                    }

                    //si el producto no existe lo agrega al datagrid
                    if (!prodExiste)
                    {
                        listadoVentaProducto.Rows.Add(new object[]
                        {
                            TBIdProducto.Text,
                            TBCodigoProd.Text,
                            TBNombreProd.Text,
                            TBDescripcion.Text,
                            Convert.ToDecimal(TBPrecio.Text).ToString("N2"),
                            TBStock.Text,
                            numCantidad.Value.ToString(),
                            subtotal.ToString("N2")
                        });

                        CalcularTotal();
                        MessageBox.Show("El producto: " 
                            + TBNombreProd.Text + " " + TBDescripcion.Text + " se agregó correctamente.", "Éxito", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                sumaTotal += Convert.ToDecimal(filaCalculada.Cells["subtotal"].Value);
            }

            TBTotalAPagar.Text = sumaTotal.ToString("N2");
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
            RegistrarVenta();
        }

        private void RegistrarVenta()
        {
            delayTimer.Stop();

            if (C_negocio.Validaciones.EstaVacio(TBTotalAPagar.Text) ||
               C_negocio.Validaciones.EstaVacio(TBRecibe.Text) ||
               C_negocio.Validaciones.EstaVacio(TBCambio.Text))
            {
                MessageBox.Show("Debe indicar cuánto efectivo se recibió o completar todos los campos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(TBIdCliente.Text))
            {
                MessageBox.Show("Debe seleccionar un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                permitirTextChanged = false; // Desactivamos el evento TextChanged
                // Mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas crear la venta?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DataTable detalleVenta = new DataTable();
                    detalleVenta.Columns.Add("PrecioVenta", typeof(decimal));
                    detalleVenta.Columns.Add("Cantidad", typeof(int));
                    detalleVenta.Columns.Add("SubTotal", typeof(decimal));
                    detalleVenta.Columns.Add("ID_producto", typeof(int));

                    foreach (DataGridViewRow fila in listadoVentaProducto.Rows)
                    {
                        if (fila.Cells["precioVenta"].Value != null &&
                            fila.Cells["cantidad"].Value != null &&
                            fila.Cells["subtotal"].Value != null &&
                            fila.Cells["ID_Producto"].Value != null)
                        {
                            // Intentamos convertir cada valor al tipo adecuado
                            if (!decimal.TryParse(fila.Cells["precioVenta"].Value.ToString(), out decimal precioVenta) ||
                                !int.TryParse(fila.Cells["cantidad"].Value.ToString(), out int cantidad) ||
                                !decimal.TryParse(fila.Cells["subtotal"].Value.ToString(), out decimal subTotal) ||
                                !int.TryParse(fila.Cells["ID_Producto"].Value.ToString(), out int idProducto))
                            {
                                MessageBox.Show("Uno o más valores de la lista de productos tienen un formato inválido.",
                                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            detalleVenta.Rows.Add(precioVenta, cantidad, subTotal, idProducto);
                        }
                        else
                        {
                            MessageBox.Show("Hay una fila con datos incompletos. Verifique los productos de la lista.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    int idcorrelativo = CN_Ventas.ObtenerCorrelativo();
                    string numeroFactura = string.Format("{0:00000}", idcorrelativo);

                    OpcionCombo opcionSeleccionada = (OpcionCombo)cbTipoDoc.SelectedItem;
                    int idTipoDoc = Convert.ToInt32(opcionSeleccionada.Valor); // obtengo el ID_Tipo_Doc.

                    Venta venta = new Venta()
                    {
                        NumeroFactura = Convert.ToInt32(numeroFactura),
                        MontoTotal = Convert.ToDecimal(TBTotalAPagar.Text),
                        FechaVenta = DTFechaVenta.Value.Date.Add(DateTime.Now.TimeOfDay),
                        Obj_cliente = new Clientes() { ID_cliente = Convert.ToInt32(TBIdCliente.Text) },
                        Obj_usuarios = new Usuarios() { ID_usuarios = SesionUsuario.UsuarioActual.ID_usuarios },
                        Obj_Tipo_Doc = new TipoDoc() { ID_Tipo_Doc = idTipoDoc }
                    };

                    string mensaje = string.Empty;
                    bool respuesta = CN_Ventas.RegistrarVenta(venta, detalleVenta, out mensaje);

                    if (respuesta)
                    {
                        DialogResult result2 = MessageBox.Show("La venta ha sido creada correctamente. Número de factura generada:\n" + numeroFactura +
                            "\n\n¿Desea copiar al portapapeles?", "Mensaje",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (result2 == DialogResult.Yes)
                        {
                            Clipboard.SetText(numeroFactura);
                            MessageBox.Show("Número de factura: " + numeroFactura +
                                " copiado al portapapeles!", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        TBIdCliente.Clear();
                        TBNombreCompleto.Clear();
                        TBNroDocumento.Clear(); 
                        TBTotalAPagar.Clear();
                        TBCambio.Clear();
                        TBRecibe.Clear();
                        cbTipoDoc.SelectedIndex = 0;
                        listadoVentaProducto.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("La operación de crear venta ha sido cancelada.", "Cancelado",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TBRecibe_TextChanged(object sender, EventArgs e)
        {
            if (!permitirTextChanged) return; // Evita la recursión infinita

            delayTimer.Stop();
            delayTimer.Start();
        }

        private void DelayTimer_Tick(object sender, EventArgs e)
        {
            delayTimer.Stop();

            if (!decimal.TryParse(TBRecibe.Text, NumberStyles.Number, CultureInfo.GetCultureInfo("es-ES"), out decimal recibe) ||
                !decimal.TryParse(TBTotalAPagar.Text, NumberStyles.Number, CultureInfo.GetCultureInfo("es-ES"), out decimal totalPagar))
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos en 'Recibe'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBCambio.Clear();
                return;
            }

            if (recibe >= totalPagar)
            {
                decimal cambio = recibe - totalPagar;
                TBCambio.Text = cambio.ToString("N2", CultureInfo.GetCultureInfo("es-ES"));
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
                    TBIdProducto.Text = modal.Productomd.ID_producto.ToString();
                    TBCodigoProd.Text = modal.Productomd.Codigo.ToString();
                    TBNombreProd.Text = modal.Productomd.Nombre.ToString();
                    TBDescripcion.Text = modal.Productomd.Descripcion.ToString();
                    TBPrecio.Text = modal.Productomd.PrecioVenta.ToString("N2");
                    TBStock.Text = modal.Productomd.Stock.ToString();
                }
                else
                {
                    TBCodigoProd.Select();
                    return;
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
                    TBIdCliente.Text = modal.Clientemd.ID_cliente.ToString();
                    TBNroDocumento.Text = modal.Clientemd.Documento.ToString();
                    TBNombreCompleto.Text = modal.Clientemd.NombreCompleto.ToString();
                }
                else
                {
                    TBNroDocumento.Select();
                    return;
                }
            }
        }

        private void Limpiar()
        {
            TBPrecio.Clear();
            numCantidad.Value = 1;
            TBCodigoProd.Clear();
            TBStock.Clear();
            TBNombreProd.Clear();
            TBDescripcion.Clear();
            TBIdProducto.Clear();
        }

        private void listadoVentaProducto_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 8)
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
            if (listadoVentaProducto.Columns[e.ColumnIndex].Name == "btnEliminar")
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
