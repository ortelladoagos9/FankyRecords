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
               C_negocio.Validaciones.EstaVacio(TBstock.Text) ||
               C_negocio.Validaciones.EstaVacio(TBPrecio_Compra.Text) ||
               C_negocio.Validaciones.EstaVacio(TBPrecio_Venta.Text) ||
               C_negocio.Validaciones.EstaVacio(CBcategoria.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas guardar los datos?",
                                                          "Confirmación",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int n = listadoProductos.Rows.Add();

                    listadoProductos.Rows[n].Cells[0].Value = TBcodigo_prod.Text;
                    listadoProductos.Rows[n].Cells[1].Value = TBnombre_prod.Text;
                    listadoProductos.Rows[n].Cells[2].Value = TBdescripcion.Text;
                    listadoProductos.Rows[n].Cells[3].Value = CBcategoria.Text;
                    listadoProductos.Rows[n].Cells[4].Value = TBstock.Text;
                    listadoProductos.Rows[n].Cells[5].Value = TBPrecio_Compra.Text;
                    listadoProductos.Rows[n].Cells[6].Value = TBPrecio_Venta.Text;
                    
                    if (rBactivo.Checked)
                    {
                        listadoProductos.Rows[n].Cells[7].Value = "Activo";
                    }
                    else
                    {
                        listadoProductos.Rows[n].Cells[7].Value = "Inactivo";
                    }

                    // limpia campos
                    TBcodigo_prod.Clear();
                    TBnombre_prod.Clear();
                    TBdescripcion.Clear();
                    TBstock.Clear();
                    TBPrecio_Compra.Clear();
                    TBPrecio_Venta.Clear();
                    CBcategoria.SelectedIndex = -1;  // Deselect the ComboBox
                                                    
                    MessageBox.Show("Los datos han sido guardados correctamente.",
                                        "Éxito",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                }
                else
                {
                   MessageBox.Show("La operación de guardado ha sido cancelada.",
                                        "Cancelado",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
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

        private void Beliminar_Click(object sender, EventArgs e)
        {

        }
    }
}

