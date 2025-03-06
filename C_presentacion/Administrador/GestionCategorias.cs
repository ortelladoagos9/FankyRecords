using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FankyRecords.C_datos;
using FankyRecords.C_entidad;
using FankyRecords.C_negocio;

namespace FankyRecords.C_presentacion.Administrador
{
    public partial class GestionCategorias : Form
    {
        private readonly DatosCategorias CD_Categorias;
        private readonly NegocioCategorias CN_Categorias;
        private int categoriaIdSeleccionada; // Variable para almacenar el Id de la categoría seleccionada

        public GestionCategorias()
        {
            InitializeComponent();
            CD_Categorias = new DatosCategorias();
            CN_Categorias = new NegocioCategorias();
        }

        private void Bguardar_Click(object sender, EventArgs e)
        {
            GuardarCategorias();
        }

        private void GuardarCategorias()
        {
           
            // Verificar que todos los campos requeridos estén completos
            if (C_negocio.Validaciones.EstaVacio(TBdescripcion.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación previa de duplicados en la base de datos
            if (CN_Categorias.ExisteCategoria(TBdescripcion.Text))
            {
                MessageBox.Show("La categoría ya existe. No se permiten duplicados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
                return;
            }
                         
            // Crear objeto categoría
            Categorias categorias = new Categorias
            {
                Descripcion = TBdescripcion.Text,
                Estado = rBactivo.Checked ? "Activo" : "Inactivo"
            };
            try
            {
                DialogResult ask = MessageBox.Show("¿Seguro que desea insertar una nueva categoria?", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ask == DialogResult.Yes)
                {
                    // Intentar guardar la categoría en la base de datos
                    CN_Categorias.GuardarCategoria(categorias);

                    MessageBox.Show("La categoria: " + this.TBdescripcion.Text + " se inserto correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Recargar datos y limpiar formulario
                    CargarCategorias();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
        }

        private void Beliminar_Click(object sender, EventArgs e)
        {
            EliminarCategorias();
        }

        private void EliminarCategorias()
        {
            if (C_negocio.Validaciones.EstaVacio(TBdescripcion.Text))
            {
                MessageBox.Show("Debe completar todos los campos para poder desactivar una categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Verificar si la categoria existe en la base de datos
            Categorias categoriaExistente = CN_Categorias.ObtenerCategoriaPorID(categoriaIdSeleccionada);
            if (categoriaExistente == null)
            {
                MessageBox.Show("La categoria seleccionada no se encuentra en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
                return;
            }
            if (C_negocio.Validaciones.mensajeEliminar())
            {
                CN_Categorias.EliminarCategoria(categoriaIdSeleccionada);

                // Recargar datos y limpiar formulario
                CargarCategorias();
                Limpiar();
            }      
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        { 
            Limpiar();
        }

        private void Beditar_Click(object sender, EventArgs e)
        {
            EditarCategorias();
        }

        private void EditarCategorias()
        {
            if (C_negocio.Validaciones.EstaVacio(TBdescripcion.Text))
            {
                MessageBox.Show("No hay datos para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Verificar si la categoria existe en la base de datos
            Categorias categoriaExistente = CN_Categorias.ObtenerCategoriaPorID(categoriaIdSeleccionada);
            if (categoriaExistente == null)
            {
                MessageBox.Show("La categoria seleccionada no se encuentra en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
                return;
            }
            // Crear objeto categoría
            Categorias categorias = new Categorias
            {
                Id_categoria = categoriaIdSeleccionada, // Asignar el ID de la categoría seleccionada
                Descripcion = TBdescripcion.Text,
                Estado = rBactivo.Checked ? "Activo" : "Inactivo"
            };
            try
            {
                DialogResult ask = MessageBox.Show("¿Seguro que desea editar categoria?", "Confirmar edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ask == DialogResult.Yes)
                {
                    // Llamar al método de negocio para guardar/editar la categoría
                    CN_Categorias.GuardarCategoria(categorias);

                    MessageBox.Show("La categoria: " + this.TBdescripcion.Text + " se edito correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Recargar datos y limpiar formulario
                    CargarCategorias();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void GestionCategorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            List<Categorias> categorias = CN_Categorias.ListarCategorias();
            listadoCategorias.DataSource = categorias;
        }

        private void listadoCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica que el índice de fila es válido
            {
                DataGridViewRow row = listadoCategorias.Rows[e.RowIndex];

                // Accede al Id_categoria si existe en el DataGridView
                if (row.Cells["Id_categoria"] != null)
                {
                    categoriaIdSeleccionada = Convert.ToInt32(row.Cells["Id_categoria"].Value);
                }

                // Rellenar otros campos de la categoría seleccionada
                if (row.Cells["Descripcion"] != null)
                {
                    TBdescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                }

                if (row.Cells["Estado"] != null)
                {
                    string estado = row.Cells["Estado"].Value.ToString();
                    rBactivo.Checked = estado == "Activo";
                    rBinactivo.Checked = estado == "Inactivo";
                }
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
            string busqueda = termino.ToLower().Trim(); // Convertir a minúsculas y quitar espacios extra

            // Desactivar la selección para evitar conflictos
            listadoCategorias.ClearSelection();
            listadoCategorias.CurrentCell = null;

            foreach (DataGridViewRow row in listadoCategorias.Rows)
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
                if (!filaVisible && listadoCategorias.CurrentRow == row)
                {
                    foreach (DataGridViewRow otraFila in listadoCategorias.Rows)
                    {
                        if (otraFila != row && otraFila.Visible)
                        {
                            listadoCategorias.CurrentCell = otraFila.Cells[0];
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

        private void Limpiar()
        {
            TBdescripcion.Clear();
            rBactivo.Checked = true;
            // Deselecciona la fila actual en el DataGridView
            listadoCategorias.ClearSelection();
            // Resetea el ID del usuario seleccionado
            categoriaIdSeleccionada = -1;
        }

        private void listadoCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que el índice de fila es válido y que no es un encabezado (e.RowIndex >= 0)
            if (e.RowIndex >= 0)
            {
                // Deselecciona la fila actual en el DataGridView
                listadoCategorias.ClearSelection();

                // Limpia los controles de entrada
                Limpiar();

                // Resetea el ID del cliente seleccionado
                categoriaIdSeleccionada = -1; 
            }
        }

        private void TBBuscador_TextChanged_1(object sender, EventArgs e)
        {
            if (TBBuscador.Text == "")
            {
                CargarCategorias();
            }
        }

        private void TBBuscador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidarYBuscar();  // Llama al método  ValidarYBuscar() cuando se presiona Enter
                e.SuppressKeyPress = true;  // Evita el sonido de la tecla
            }
        }
    }
}