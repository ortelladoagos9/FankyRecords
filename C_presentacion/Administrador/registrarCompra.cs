using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FankyRecords.C_datos;
using FankyRecords.C_entidad;
using FankyRecords.C_negocio;
using FankyRecords.C_presentacion.Modales;

namespace FankyRecords.C_presentacion.Administrador
{
    public partial class registrarCompra : Form
    {
        private readonly NegocioCompras CN_Compras;
        private readonly NegocioTipoDOc CN_TipoDoc;
        private Proveedores proveedorSeleccionado;

        public registrarCompra()
        {
            InitializeComponent();
            CN_Compras = new NegocioCompras();
            CN_TipoDoc = new NegocioTipoDOc();
        }

        private void registrarCompra_Load(object sender, EventArgs e)
        {
            CargarCombo();
            // Obtén la fecha actual del sistema
            DateTime fechaActual = DateTime.Now.Date;

            // Configura la propiedad Text del DateTimePicker a la fecha actual
            dtFechaCompra.Value = fechaActual;

            // Configura el MinDate y MaxDate para que sean la fecha actual
            dtFechaCompra.MinDate = fechaActual;
            dtFechaCompra.MaxDate = fechaActual;
            TBNumFactura.Select();
        }

        private void BAgregarProd_Click(object sender, EventArgs e)
        {
            AgregarProducto();
        }

        private void AgregarProducto()
        {
            //Verificamos que todos los campos estésn completos.
            if (C_negocio.Validaciones.EstaVacio(cbTipoDoc.Text)
                || C_negocio.Validaciones.EstaVacio(TBcuit.Text)
                || C_negocio.Validaciones.EstaVacio(TBprecio_compra.Text)
                || C_negocio.Validaciones.EstaVacio(TBproducto.Text)
                || C_negocio.Validaciones.EstaVacio(TBNumFactura.Text)
                || C_negocio.Validaciones.EstaVacio(TBCodProd.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas agregar el producto: " + TBproducto.Text + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool prodExiste = false;
                    decimal subtotal = cantProd.Value * Convert.ToDecimal(TBprecio_compra.Text);
                    decimal cantidadTotal = 0;
                    decimal precioCompraActual = 0;
                    decimal precioVentaActual = 0;

                    foreach (DataGridViewRow fila in listaCompras.Rows)
                    {
                        if (fila.Cells["Codigo"].Value != null && fila.Cells["Codigo"].Value.ToString() == TBCodProd.Text)
                        {
                            // El producto ya existe, actualizar cantidad y subtotal
                            prodExiste = true;
                            decimal cantidadExistente = Convert.ToDecimal(fila.Cells["Cantidad"].Value);
                            cantidadTotal = cantidadExistente + cantProd.Value;

                            precioCompraActual = Convert.ToDecimal(TBprecio_compra.Text);

                            precioVentaActual = Convert.ToDecimal(TBPrecio_Venta.Text);

                            // Actualizar la celda de cantidad
                            fila.Cells["Cantidad"].Value = cantidadTotal.ToString("N2");
                            // Actualizar la celda de subtotal
                            fila.Cells["Subtotal"].Value = cantidadTotal * precioCompraActual;
                            // Actualizar la celda de Precio_Compra
                            fila.Cells["Precio_Compra"].Value = precioCompraActual.ToString("N2");
                            // Actualizar la celda de Precio_Venta
                            fila.Cells["Precio_Venta"].Value = precioVentaActual.ToString("N2");

                            CalcularTotal();
                            MessageBox.Show("La cantidad del producto " + TBproducto.Text + " se actualizó correctamente.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                            return;
                        }
                    }

                    if (!prodExiste)
                    {
                        listaCompras.Rows.Add(new object[]
                        {
                            TBCodProd.Text,
                            TBproducto.Text,
                            Convert.ToDecimal(TBprecio_compra.Text).ToString("N2"),
                            Convert.ToDecimal(TBPrecio_Venta.Text).ToString("N2"),
                            cantProd.Value.ToString(),
                            dtFechaCompra.Text,
                            subtotal.ToString("N2")
                        });

                        CalcularTotal();
                        MessageBox.Show("El producto: " + TBproducto.Text + " se agregó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            foreach (DataGridViewRow filaCalculada in listaCompras.Rows)
            {
                sumaTotal += Convert.ToDecimal(filaCalculada.Cells["Subtotal"].Value);
            }

            TBtotalPagar.Text = sumaTotal.ToString("N2");
        }

        private void CargarCompra()
        {
            List<Compra> registrarCompra = CN_Compras.ListarCompras();
            listaCompras.DataSource = registrarCompra;
        }

        private void registrarCompra_Click(object sender, EventArgs e)
        {
            RegistrarCompra();
        }

        private void RegistrarCompra()
        {
            if (C_negocio.Validaciones.EstaVacio(TBtotalPagar.Text))
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
            if (proveedorSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuarios usuarioSeleccionado = new Usuarios
            {
                ID_usuarios = SesionUsuario.UsuarioActual.ID_usuarios,
                Nombre = SesionUsuario.UsuarioActual.Nombre,
                Apellido = SesionUsuario.UsuarioActual.Apellido,
                Obj_rol = SesionUsuario.UsuarioActual.Obj_rol
            };

            // Asignar el usuario al objeto compra
            Compra registrarCompra = new Compra
            {
                MontoTotal = Convert.ToDecimal(TBtotalPagar.Text),
                NumeroFactura = Convert.ToInt32(TBNumFactura.Text),
                FechaCompra = Convert.ToDateTime(dtFechaCompra.Text),
                Obj_proveedor = proveedorSeleccionado,
                Obj_usuarios = usuarioSeleccionado, 
                Obj_Tipo_Doc = tipoDocSeleccionado
            };

            registrarCompra.Obj_Tipo_Doc = tipoDocSeleccionado;
            if (cbTipoDoc.SelectedItem is OpcionCombo opcionSeleccionada)
            {
                registrarCompra.Obj_Tipo_Doc.ID_Tipo_Doc = (int)opcionSeleccionada.Valor;
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
                    CN_Compras.GuardarCompra(registrarCompra);

                    MessageBox.Show("La compra del producto: " + this.TBCodProd.Text + " " + this.TBproducto + " se registró correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Recargar datos y limpiar formulario
                    CargarCompra();
                    Limpiar();
                    TBtotalPagar.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
        }

        private void Txtnumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsNumero(e);
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new MDProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TBCodProd.Text = modal.Productomd.Codigo.ToString();
                    TBproducto.Text = modal.Productomd.Nombre.ToString();
                }
                else
                {
                    TBCodProd.Select();
                }
            }
        }

        
        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new MDProveedor())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    proveedorSeleccionado = modal.Proveedormd; // Captura el proveedor seleccionado
                    TBrazonSocial.Text = modal.Proveedormd.RazonSocial.ToString();
                    TBcuit.Text = modal.Proveedormd.Cuit.ToString();
                }
                else
                {
                    TBcuit.Select();
                }
            }
        }

        private void Limpiar()
        {
            TBCodProd.Clear();
            TBproducto.Clear();
            TBprecio_compra.Clear();
            cantProd.Value = 1;
        }

        private void TBprecio_compra_TextChanged(object sender, EventArgs e)
        {
            if (TBprecio_compra.Text == "")
            {
                TBPrecio_Venta.Text = "";
            }
            else
            {
                decimal precioVenta = (Convert.ToDecimal(0.2) * Convert.ToDecimal(TBprecio_compra.Text)) + Convert.ToDecimal(TBprecio_compra.Text);
                TBPrecio_Venta.Text = precioVenta.ToString();
            }
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

        private void listaCompras_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if(e.ColumnIndex == 7)
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

        private void listaCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (listaCompras.Columns[e.ColumnIndex].Name == "BtnEliminar")
            {
                int indice = e.RowIndex;

                if (indice >= 0 && listaCompras.Rows[indice].Cells["Codigo"].Value != null)
                {
                    listaCompras.Rows.RemoveAt(indice);
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