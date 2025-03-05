using FankyRecords.C_entidad;
using FankyRecords.C_negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FankyRecords.C_presentacion.Modales
{
    public partial class MDCompra : Form
    {
        public Compra CompraMD { get; set; }
        private readonly NegocioCompras CN_Compras;

        public MDCompra()
        {
            InitializeComponent();
            this.KeyPreview = true;
            CN_Compras = new NegocioCompras();
        }

        private void MDCompra_Load_1(object sender, EventArgs e)
        {
            CargarCompras();
        }

        private void CargarCompras()
        {
            List<Compra> compra = CN_Compras.ListarCompras();
            listadoCompras.DataSource = compra;
        }

        private void listadoCompras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /* creo dos variables para recorrer el datagrid*/
            int iRow = e.RowIndex;
            int iCol = e.ColumnIndex;
            //recorro el datgrid
            if (iRow >= 0 && iCol >= 0)
            {
                // Extraer el valor del CUIT
                object cellCuit = listadoCompras.Rows[iRow].Cells["cuit"].Value;
                string cuit;
                if (cellCuit is Proveedores prov)
                {
                    cuit = prov.Cuit;
                }
                else
                {
                    cuit = cellCuit?.ToString() ?? "N/A";
                }

                // Extraer el valor de la Razón Social
                object cellRazon = listadoCompras.Rows[iRow].Cells["razonS"].Value;
                string razonS;
                if (cellRazon is Proveedores prov2)
                {
                    razonS = prov2.RazonSocial;
                }
                else
                {
                    razonS = cellRazon?.ToString() ?? "N/A";
                }

                CompraMD = new Compra()
                {
                    NumeroCompra = Convert.ToInt32(listadoCompras.Rows[iRow].Cells["NumeroCompra"].Value.ToString()),
                    Obj_Tipo_Doc = new TipoDoc() // Asegurar que el objeto está inicializado
                    {
                        Descripcion = listadoCompras.Rows[iRow].Cells["tipoDoc"].Value?.ToString()
                    },
                    Obj_usuarios = new Usuarios() 
                    {
                        NombreCompleto = listadoCompras.Rows[iRow].Cells["usuario"].Value?.ToString()
                    },
                    Obj_proveedor = new Proveedores()
                    {
                        Cuit = cuit,
                        RazonSocial = razonS
                    },
                    FechaCompra = Convert.ToDateTime(listadoCompras.Rows[iRow].Cells["FechaCompra"].Value.ToString()),
                    NumeroFactura = Convert.ToInt32(listadoCompras.Rows[iRow].Cells["NumeroFactura"].Value.ToString()),
                    MontoTotal = Convert.ToDecimal(listadoCompras.Rows[iRow].Cells["MontoTotal"].Value.ToString())
                };

                // devuelve OK y cierra form
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ValidarYBuscar();
        }

        private void ValidarYBuscar()
        {
            if (C_negocio.Validaciones.EstaVacio(TBBuscador.Text))
            {
                MessageBox.Show("Debe ingresar un dato para buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string terminoBusqueda = TBBuscador.Text;
                BuscarDatos(terminoBusqueda);
            }
        }

        private void BuscarDatos(string termino)
        {
            bool encontrado = false;
            string busqueda = termino.ToLower();

            // Desactivar la selección para evitar conflictos
            listadoCompras.ClearSelection();

            // Primero, deselecciona la celda actual
            listadoCompras.CurrentCell = null;

            foreach (DataGridViewRow row in listadoCompras.Rows)
            {
                // Concatenar los valores de las celdas para la búsqueda
                string filaDatos = "";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                        filaDatos += cell.Value.ToString().ToLower() + " ";
                }

                bool filaVisible = filaDatos.Contains(busqueda);

                // Si la fila debe ocultarse pero es la fila actual, cambiar el foco a otra fila visible
                if (!filaVisible && listadoCompras.CurrentRow == row)
                {
                    // Buscar otra fila visible para asignar el foco
                    foreach (DataGridViewRow otraFila in listadoCompras.Rows)
                    {
                        if (otraFila != row && otraFila.Visible)
                        {
                            listadoCompras.CurrentCell = otraFila.Cells[0];
                            break;
                        }
                    }
                }

                // Ahora es seguro modificar la visibilidad
                row.Visible = filaVisible;
                if (filaVisible)
                    encontrado = true;
            }

            if (!encontrado)
            {
                MessageBox.Show("No se encontraron coincidencias.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBBuscador.Clear();
            }
        }

        private void TBBuscador_TextChanged(object sender, EventArgs e)
        {
            if (TBBuscador.Text == "")
            {
                CargarCompras();
            }
        }

        private void MDCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidarYBuscar();  // Llama al método  ValidarYBuscar() cuando se presiona Enter
                e.SuppressKeyPress = true;  // Evita el sonido de la tecla
            }
        }
    }
}
