using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FankyRecords.C_presentacion.Vendedor
{
    public partial class GestionClientes : Form
    {
        public GestionClientes()
        {
            InitializeComponent();
        }

        private void Txtpalabras_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsLetra(e);
        }
        private void Txtnumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsNumero(e);
        }

        private void Bguardar_Click(object sender, EventArgs e)
        {
            if (C_negocio.Validaciones.EstaVacio(TBnombre.Text) ||
               C_negocio.Validaciones.EstaVacio(TBapellido.Text) ||
               C_negocio.Validaciones.EstaVacio(TBdni.Text) ||
               C_negocio.Validaciones.EstaVacio(TBemail.Text) ||     
               C_negocio.Validaciones.EstaVacio(TBtelefono.Text))
            
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (C_negocio.Validaciones.mensajeConfirmacion())
                {
                    
                    string email = TBemail.Text;

                    if (!C_negocio.Validaciones.EmailCorrecto(email))
                    {
                        MessageBox.Show("El formato del correo electrónico no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int n = listadoClientes.Rows.Add();

                        listadoClientes.Rows[n].Cells[0].Value = TBdni.Text;
                        listadoClientes.Rows[n].Cells[1].Value = TBapellido.Text;
                        listadoClientes.Rows[n].Cells[2].Value = TBnombre.Text;
                        listadoClientes.Rows[n].Cells[3].Value = TBemail.Text;
                        listadoClientes.Rows[n].Cells[4].Value = TBtelefono.Text;

                        if (rBactivo.Checked)
                        {
                            listadoClientes.Rows[n].Cells[5].Value = "Activo";
                        }
                        else
                        {
                            listadoClientes.Rows[n].Cells[5].Value = "Inactivo";
                        }

                        // limpia campos
                        TBnombre.Clear();
                        TBapellido.Clear();
                        TBtelefono.Clear();
                        TBdni.Clear();
                        TBemail.Clear();

                    }
                }
            }
        }

        private void Beditar_Click(object sender, EventArgs e)
        {
            if (C_negocio.Validaciones.EstaVacio(TBnombre.Text) ||
               C_negocio.Validaciones.EstaVacio(TBapellido.Text) ||
               C_negocio.Validaciones.EstaVacio(TBdni.Text) ||
               C_negocio.Validaciones.EstaVacio(TBemail.Text) ||
               C_negocio.Validaciones.EstaVacio(TBtelefono.Text))
            {
                MessageBox.Show("No hay datos para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (C_negocio.Validaciones.mensajeEditar())
                {
                    // limpia campos
                    TBnombre.Clear();
                    TBapellido.Clear();
                    TBtelefono.Clear();
                    TBdni.Clear();
                    TBemail.Clear();
                }
            }
        }

        private void Beliminar_Click(object sender, EventArgs e)
        {
            if (C_negocio.Validaciones.EstaVacio(TBnombre.Text) ||
               C_negocio.Validaciones.EstaVacio(TBapellido.Text) ||
               C_negocio.Validaciones.EstaVacio(TBdni.Text) ||
               C_negocio.Validaciones.EstaVacio(TBemail.Text) ||
               C_negocio.Validaciones.EstaVacio(TBtelefono.Text))
            {
                MessageBox.Show("No hay datos para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (C_negocio.Validaciones.mensajeEliminar())
                {
                    // limpia campos
                    TBnombre.Clear();
                    TBapellido.Clear();
                    TBtelefono.Clear();
                    TBdni.Clear();
                    TBemail.Clear();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listadoClientes.Rows.Clear();
        }
    }
}
