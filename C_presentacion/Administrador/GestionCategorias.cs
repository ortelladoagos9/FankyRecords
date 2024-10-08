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

namespace FankyRecords.C_presentacion.Administrador
{
    public partial class GestionCategorias : Form
    {
        private readonly DatosCategorias CD_Categorias;
        private readonly NegocioCategorias CN_Categorias;

        public GestionCategorias()
        {
            InitializeComponent();
            this.CBbuscar.SelectedIndex = 0;
            CD_Categorias = new DatosCategorias();
            CN_Categorias = new NegocioCategorias();
        }

        private void Bguardar_Click(object sender, EventArgs e)
        {
            GuardarCategorias();
        }

        private void GuardarCategorias()
        {
            if (C_negocio.Validaciones.EstaVacio(TBdescripcion.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (C_negocio.Validaciones.mensajeConfirmacion())
                {
                    Categorias categorias = new Categorias();
                    categorias.Descripcion = TBdescripcion.Text;

                    if (rBactivo.Checked)
                    {
                        categorias.Estado = "Activo";
                    }
                    else
                    {
                        categorias.Estado = "Inactivo";
                    }

                    CN_Categorias.GuardarCategoria(categorias);

                    CargarCategorias();

                    Limpiar();
                }
            }
        }

        private void Beliminar_Click(object sender, EventArgs e)
        {
            if (C_negocio.Validaciones.EstaVacio(TBdescripcion.Text))
            {
                MessageBox.Show("No hay datos para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (C_negocio.Validaciones.mensajeEliminar())
                {
                    Limpiar();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todas las filas del DataGridView
            listadoCategorias.Rows.Clear();
        }

        private void Beditar_Click(object sender, EventArgs e)
        {
            if (C_negocio.Validaciones.EstaVacio(TBdescripcion.Text))
            {
                MessageBox.Show("No hay datos para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (C_negocio.Validaciones.mensajeEditar())
                {
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

                // Solo accede a las columnas si el índice es válido y la celda no es nula
                if (row.Cells["Descripcion"] != null)
                {
                    TBdescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                }

                if (row.Cells["Estado"] != null)
                {
                    string estado = row.Cells["Estado"].Value.ToString();
                    if (estado == "Activo")
                    {
                        rBactivo.Checked = true;
                    }
                    else
                    {
                        rBinactivo.Checked = true;
                    }
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
        }
    }
}
