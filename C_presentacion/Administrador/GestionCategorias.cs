using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FankyRecords.C_negocio;

namespace FankyRecords.C_presentacion.Administrador
{
    public partial class GestionCategorias : Form
    {
        int contador = 0;

        public GestionCategorias()
        {
            InitializeComponent();
        }

        private void Bguardar_Click(object sender, EventArgs e)
        {
            if (C_negocio.Validaciones.EstaVacio(TBdescripcion.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (C_negocio.Validaciones.mensajeConfirmacion())
                {
                    contador += 1;
                    int n = listadoCategorias.Rows.Add();

                    listadoCategorias.Rows[n].Cells[0].Value = contador;
                    listadoCategorias.Rows[n].Cells[1].Value = TBdescripcion.Text;
                 
                    if (rBactivo.Checked)
                    {
                        listadoCategorias.Rows[n].Cells[2].Value = "Activo";
                    }
                    else
                    {
                        listadoCategorias.Rows[n].Cells[2].Value = "Inactivo";
                    }

                    // limpia campos
                    TBdescripcion.Clear();
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
                    // limpia campos
                    TBdescripcion.Clear();
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
                    // limpia campos
                    TBdescripcion.Clear();
                }
            }
        }
    }
}
