using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FankyRecords.C_negocio;

namespace FankyRecords.C_presentacion.Administrador
{
    public partial class gestionProductos : Form
    {
        public gestionProductos()
        {
            InitializeComponent();
        }

        private void Bguardar_Click(object sender, EventArgs e)
        {
            if (C_negocio.Validaciones.EstaVacio(TBcodigo_prod.Text) ||
               C_negocio.Validaciones.EstaVacio(TBnombre_prod.Text) ||
               C_negocio.Validaciones.EstaVacio(TBdescripcion.Text) ||
               C_negocio.Validaciones.EstaVacio(CBcategoria.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (C_negocio.Validaciones.mensajeConfirmacion())
                {
                    int n = listadoProductos.Rows.Add();

                    listadoProductos.Rows[n].Cells[0].Value = TBcodigo_prod.Text;
                    listadoProductos.Rows[n].Cells[1].Value = TBnombre_prod.Text;
                    listadoProductos.Rows[n].Cells[2].Value = TBdescripcion.Text;
                    listadoProductos.Rows[n].Cells[3].Value = CBcategoria.Text;
                    listadoProductos.Rows[n].Cells[4].Value = TBPrecio_Venta.Text;
                                        
                    if (rBactivo.Checked)
                    {
                        listadoProductos.Rows[n].Cells[5].Value = "Activo";
                    }
                    else
                    {
                        listadoProductos.Rows[n].Cells[5].Value = "Inactivo";
                    }

                    // limpia campos
                    TBcodigo_prod.Clear();
                    TBnombre_prod.Clear();
                    TBdescripcion.Clear();
                    TBPrecio_Venta.Clear();
                    CBcategoria.SelectedIndex = -1;  // Deselect the ComboBox

                }
            }
        }

        private void Txtpalabras_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsLetra(e);
        }
        private void Txtnumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsNumero(e);
        }

        

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todas las filas del DataGridView
            listadoProductos.Rows.Clear();

        }

        private void Beliminar_Click(object sender, EventArgs e)
        {
            if (C_negocio.Validaciones.EstaVacio(TBcodigo_prod.Text) ||
               C_negocio.Validaciones.EstaVacio(TBnombre_prod.Text) ||
               C_negocio.Validaciones.EstaVacio(TBdescripcion.Text) ||
               C_negocio.Validaciones.EstaVacio(CBcategoria.Text))
            {
                MessageBox.Show("No hay datos para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (C_negocio.Validaciones.mensajeEliminar())
                {
                    // limpia campos
                    TBcodigo_prod.Clear();
                    TBnombre_prod.Clear();
                    TBdescripcion.Clear();
                    TBPrecio_Venta.Clear();
                    CBcategoria.SelectedIndex = -1;  // Deselect the ComboBox
                }
            }
        }

        private void Beditar_Click(object sender, EventArgs e)
        {
            if (C_negocio.Validaciones.EstaVacio(TBcodigo_prod.Text) ||
               C_negocio.Validaciones.EstaVacio(TBnombre_prod.Text) ||
               C_negocio.Validaciones.EstaVacio(TBdescripcion.Text) ||
               C_negocio.Validaciones.EstaVacio(CBcategoria.Text))
            {
                MessageBox.Show("No hay datos para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (C_negocio.Validaciones.mensajeEditar())
                {
                    // limpia campos
                    TBcodigo_prod.Clear();
                    TBnombre_prod.Clear();
                    TBdescripcion.Clear();
                    TBPrecio_Venta.Clear();
                    CBcategoria.SelectedIndex = -1;  // Deselect the ComboBox
                }
            }
        }
    }
}

