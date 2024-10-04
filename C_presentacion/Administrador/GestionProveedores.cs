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
        int contador = 0;

        public GestionProveedores()
        {
            InitializeComponent();
            this.CBbuscar.SelectedIndex = 0;
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
                        contador += 1;
                        int n = DGlistaproveedores.Rows.Add();

                        DGlistaproveedores.Rows[n].Cells[0].Value = contador;
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
                    // limpia campos
                    TBRazonSocial.Clear();
                    TBcuit.Clear();
                    TBcorreo.Clear();
                    TBtelefono.Clear();
                    TBdomiciliop.Clear();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todas las filas del DataGridView
            DGlistaproveedores.Rows.Clear();
        }

        private void Beditar_Click(object sender, EventArgs e)
        {
            if (C_negocio.Validaciones.EstaVacio(TBRazonSocial.Text) ||
                C_negocio.Validaciones.EstaVacio(TBcuit.Text) ||
                C_negocio.Validaciones.EstaVacio(TBcorreo.Text) ||
                C_negocio.Validaciones.EstaVacio(TBtelefono.Text) ||
                C_negocio.Validaciones.EstaVacio(TBdomiciliop.Text))
            {
                MessageBox.Show("No hay datos para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (C_negocio.Validaciones.mensajeEditar())
                {
                    // limpia campos
                    TBRazonSocial.Clear();
                    TBcuit.Clear();
                    TBcorreo.Clear();
                    TBtelefono.Clear();
                    TBdomiciliop.Clear();
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
    }
}
