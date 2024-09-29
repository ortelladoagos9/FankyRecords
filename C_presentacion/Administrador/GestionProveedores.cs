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
    public partial class GestionProveedores : Form
    {
        public GestionProveedores()
        {
            InitializeComponent();
        }

        private void Bguardar_Click(object sender, EventArgs e)
        {
            if (C_negocio.Validaciones.EstaVacio(TBRazonSocial.Text) ||
                C_negocio.Validaciones.EstaVacio(TBcuit.Text) ||
                C_negocio.Validaciones.EstaVacio(TBcorreo.Text) ||
                C_negocio.Validaciones.EstaVacio(TBtelefono.Text) ||
                C_negocio.Validaciones.EstaVacio(TBdomiciliop.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                //validar correo

                string email = TBcorreo.Text;

                if (!C_negocio.Validaciones.EmailCorrecto(email))
                {
                    MessageBox.Show("El formato del correo electrónico no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (C_negocio.Validaciones.mensajeConfirmacion())
                    {
                        int n = DGlistaproveedores.Rows.Add();

                        DGlistaproveedores.Rows[n].Cells[0].Value = 0;
                        DGlistaproveedores.Rows[n].Cells[1].Value = TBRazonSocial.Text;
                        DGlistaproveedores.Rows[n].Cells[2].Value = TBcuit.Text;
                        DGlistaproveedores.Rows[n].Cells[3].Value = TBdomiciliop.Text;
                        DGlistaproveedores.Rows[n].Cells[4].Value = TBcorreo.Text;
                        DGlistaproveedores.Rows[n].Cells[5].Value = TBtelefono.Text;
                        if (RBactivop.Checked)
                        {
                            DGlistaproveedores.Rows[n].Cells[6].Value = "Activo";
                        }
                        else
                        {
                            DGlistaproveedores.Rows[n].Cells[6].Value = "Inactivo";
                        }

                        // limpia campos
                        TBRazonSocial.Clear();
                        TBcuit.Clear();
                        TBcorreo.Clear();
                        TBtelefono.Clear();
                        TBdomiciliop.Clear();
                    }
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
            if (C_negocio.Validaciones.EstaVacio(TBRazonSocial.Text) ||
                          C_negocio.Validaciones.EstaVacio(TBcuit.Text) ||
                          C_negocio.Validaciones.EstaVacio(TBcorreo.Text) ||
                          C_negocio.Validaciones.EstaVacio(TBtelefono.Text) ||
                          C_negocio.Validaciones.EstaVacio(TBdomiciliop.Text))
            {
                MessageBox.Show("No hay datos para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (C_negocio.Validaciones.mensajeEliminar())
                {
                    MessageBox.Show("Eliminado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // limpia campos
                    TBRazonSocial.Clear();
                    TBcuit.Clear();
                    TBcorreo.Clear();
                    TBtelefono.Clear();
                    TBdomiciliop.Clear();
                }
            }
        } 
    }
}
