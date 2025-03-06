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
                BuscarDatos(terminoBusqueda);
            }
        }

        private void BuscarDatos(string termino)
        {
            bool encontrado = false;
            string busqueda = termino.ToLower().Trim(); // Convertir a minúsculas y quitar espacios extra

            // Desactivar la selección para evitar conflictos
            listadoVentas.ClearSelection();
            listadoVentas.CurrentCell = null;

            foreach (DataGridViewRow row in listadoVentas.Rows)
            {
                bool filaVisible = false;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null)
                        continue;

                    string textoCelda = cell.Value.ToString().ToLower().Trim();

                    // Separar el contenido de la celda en palabras (quitando espacios extras)
                    string[] palabrasCelda = textoCelda.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (busqueda.Contains(" "))
                    {
                        // Búsqueda multi-palabra: dividimos el término en palabras
                        string[] palabrasBusqueda = busqueda.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                        // Revisar cada segmento contiguo de palabras en la celda con la cantidad de palabras en la búsqueda
                        for (int i = 0; i <= palabrasCelda.Length - palabrasBusqueda.Length; i++)
                        {
                            bool coincideTodo = true;
                            for (int j = 0; j < palabrasBusqueda.Length; j++)
                            {
                                // Se usa StartsWith para permitir coincidencias parciales en cada palabra
                                if (!palabrasCelda[i + j].StartsWith(palabrasBusqueda[j]))
                                {
                                    coincideTodo = false;
                                    break;
                                }
                            }
                            if (coincideTodo)
                            {
                                filaVisible = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        // Búsqueda de una sola palabra: se comprueba si alguna palabra de la celda comienza con el término
                        if (palabrasCelda.Any(palabra => palabra.StartsWith(busqueda)))
                        {
                            filaVisible = true;
                        }
                    }

                    if (filaVisible)
                        break;
                }

                // Si la fila actual está oculta y es la fila con foco, cambiar a otra fila visible
                if (!filaVisible && listadoVentas.CurrentRow == row)
                {
                    foreach (DataGridViewRow otraFila in listadoVentas.Rows)
                    {
                        if (otraFila != row && otraFila.Visible)
                        {
                            listadoVentas.CurrentCell = otraFila.Cells[0];
                            break;
                        }
                    }
                }

                // Aplicar la visibilidad a la fila
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
