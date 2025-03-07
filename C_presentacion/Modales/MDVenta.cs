using FankyRecords.C_entidad;
using FankyRecords.C_negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FankyRecords.C_presentacion.Modales
{
    public partial class MDVenta : Form
    {
        public Venta VentaMD { get; set; }
        private readonly NegocioVentas CN_Ventas;

        public MDVenta()
        {
            InitializeComponent();
            this.KeyPreview = true;
            CN_Ventas = new NegocioVentas();
        }

        private void MDVenta_Load(object sender, EventArgs e)
        {
            CargarVentas();
        }

        private void CargarVentas()
        {
            List<Venta> ventas = CN_Ventas.ListarVentas();
            listadoVentas.DataSource = ventas;
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
                string[] columnas = { "NumeroFactura", "FechaVenta" };
                BuscarDatos(terminoBusqueda, listadoVentas, columnas);
            }
        }

        private void BuscarDatos(string termino, DataGridView grid, string[] columnasBusqueda)
        {
            bool encontrado = false;
            string busqueda = termino.ToLower().Trim();
            string[] palabrasBusqueda = busqueda.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Desactivar la selección para evitar conflictos
            grid.ClearSelection();
            grid.CurrentCell = null;

            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow) continue; // Omitir fila nueva si es editable

                bool filaVisible = false;

                // Obtener el texto combinado de las columnas especificadas
                string textoFila = ObtenerTextoFila(row, columnasBusqueda);
                string[] palabrasFila = textoFila.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // Verificar si todas las palabras de búsqueda están en la fila
                if (palabrasBusqueda.All(palabra => palabrasFila.Any(p => p.StartsWith(palabra))))
                {
                    filaVisible = true;
                }

                row.Visible = filaVisible;
                if (filaVisible) encontrado = true;
            }

            if (!encontrado)
            {
                MessageBox.Show("No se encontraron coincidencias.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBBuscador.Clear();
            }
        }

        // Método para obtener el texto concatenado de las columnas especificadas
        private string ObtenerTextoFila(DataGridViewRow row, string[] columnas)
        {
            return string.Join(" ", columnas
                .Select(columna => row.Cells[columna]?.Value?.ToString().ToLower().Trim() ?? "")
                .Where(texto => !string.IsNullOrEmpty(texto)));
        }

        private void TBBuscador_TextChanged(object sender, EventArgs e)
        {
            if (TBBuscador.Text == "")
            {
                CargarVentas();
            }
        }

        private void MDVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidarYBuscar();  // Llama al método  ValidarYBuscar() cuando se presiona Enter
                e.SuppressKeyPress = true;  // Evita el sonido de la tecla
            }
        }

        private void listadoVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /* creo dos variables para recorrer el datagrid*/
            int iRow = e.RowIndex;
            int iCol = e.ColumnIndex;
            //recorro el datgrid
            if (iRow >= 0 && iCol >= 0)
            {
                // Extraer el valor del dni
                object cellDni = listadoVentas.Rows[iRow].Cells["dni"].Value;
                string dni;
                if (cellDni is Clientes clientes)
                {
                    dni = clientes.Documento;
                }
                else
                {
                    dni = cellDni?.ToString() ?? "N/A";
                }

                // Extraer el valor de NombreCompleto
                object cellNombreCompleto = listadoVentas.Rows[iRow].Cells["nombreCompleto"].Value;
                string nombreCompleto;
                if (cellNombreCompleto is Clientes clientes2)
                {
                    nombreCompleto = clientes2.NombreCompleto;
                }
                else
                {
                    nombreCompleto = cellNombreCompleto?.ToString() ?? "N/A";
                }

                VentaMD = new Venta()
                {
                    NumeroFactura = Convert.ToInt32(listadoVentas.Rows[iRow].Cells["NumeroFactura"].Value.ToString()),
                    Obj_Tipo_Doc = new TipoDoc() 
                    {
                        Descripcion = listadoVentas.Rows[iRow].Cells["TipoDoc"].Value?.ToString()
                    },
                    Obj_usuarios = new Usuarios()
                    {
                        NombreCompleto = listadoVentas.Rows[iRow].Cells["usuario"].Value?.ToString()
                    },
                    Obj_cliente = new Clientes()
                    {
                        Documento = dni,
                        NombreCompleto = nombreCompleto
                    },
                    FechaVenta = Convert.ToDateTime(listadoVentas.Rows[iRow].Cells["FechaVenta"].Value.ToString()),
                    MontoTotal = Convert.ToDecimal(listadoVentas.Rows[iRow].Cells["MontoTotal"].Value.ToString())
                };

                // devuelve OK y cierra form
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
