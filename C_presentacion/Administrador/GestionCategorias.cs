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
            try
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
                
                // Confirmación del usuario para continuar
                if (C_negocio.Validaciones.mensajeConfirmacion())
                {
                    // Crear objeto categoría
                    Categorias categorias = new Categorias
                    {
                        Descripcion = TBdescripcion.Text,
                        Estado = rBactivo.Checked ? "Activo" : "Inactivo"
                    };

                    // Intentar guardar la categoría en la base de datos
                    CN_Categorias.GuardarCategoria(categorias);

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


        private void Beliminar_Click(object sender, EventArgs e)
        {
            EliminarCategorias();
        }

        private void EliminarCategorias()
        {
            if (C_negocio.Validaciones.EstaVacio(TBdescripcion.Text))
            {
                MessageBox.Show("No hay datos para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (C_negocio.Validaciones.mensajeEliminar())
                {
                    CN_Categorias.EliminarCategoria(categoriaIdSeleccionada);

                    // Recargar datos y limpiar formulario
                    CargarCategorias();
                    Limpiar();
                }
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
            }
            else
            {
                    if (C_negocio.Validaciones.mensajeEditar())
                    {
                         // Crear objeto categoría
                         Categorias categorias = new Categorias
                         {
                             Id_categoria = categoriaIdSeleccionada, // Asignar el ID de la categoría seleccionada
                             Descripcion = TBdescripcion.Text,
                             Estado = rBactivo.Checked ? "Activo" : "Inactivo"
                         };

                         // Llamar al método de negocio para guardar/editar la categoría
                         CN_Categorias.GuardarCategoria(categorias);

                        // Recargar la lista de categorías
                        CargarCategorias();
                        Limpiar();
                    }
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
            if (C_negocio.Validaciones.EstaVacio(TBBuscador.Text))
            {
                MessageBox.Show("Debe ingresar un dato para buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            TBdescripcion.Clear();
            rBactivo.Checked = true;
        }

      
    }
}
