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
    public partial class MDCliente : Form
    {
        public Clientes Clientemd { get; set; }
        private readonly NegocioClientes CN_Clientes;

        public MDCliente()
        {
            InitializeComponent();
            this.KeyPreview = true;
            CN_Clientes = new NegocioClientes();
        }

        private void MDCliente_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            List<Clientes> clientes = CN_Clientes.ListarClientesModal();
            var clientesActivos = clientes.Where(c => c.Estado == "Activo").ToList();
            listaClientes.DataSource = clientesActivos;
        }

        private void listaClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /* creo dos variables para recorrer el datagrid*/
            int iRow = e.RowIndex;
            int iCol = e.ColumnIndex;
            //recorro el datgrid
            if (iRow >= 0 && iCol >= 0)
            {
                Clientemd = new Clientes()
                {
                    ID_cliente = Convert.ToInt32(listaClientes.Rows[iRow].Cells["ID_cliente"].Value.ToString()),
                    Documento = listaClientes.Rows[iRow].Cells["documento"].Value.ToString(),
                    NombreCompleto = listaClientes.Rows[iRow].Cells["NombreCompleto"].Value.ToString(),
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
            listaClientes.ClearSelection();

            // Primero, deselecciona la celda actual
            listaClientes.CurrentCell = null;

            foreach (DataGridViewRow row in listaClientes.Rows)
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
                if (!filaVisible && listaClientes.CurrentRow == row)
                {
                    // Buscar otra fila visible para asignar el foco
                    foreach (DataGridViewRow otraFila in listaClientes.Rows)
                    {
                        if (otraFila != row && otraFila.Visible)
                        {
                            listaClientes.CurrentCell = otraFila.Cells[0];
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
                CargarClientes();
            }
        }

        private void MDCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidarYBuscar();  // Llama al método  ValidarYBuscar() cuando se presiona Enter
                e.SuppressKeyPress = true;  // Evita el sonido de la tecla
            }
        }
    }
}
