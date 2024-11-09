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
using FankyRecords.C_negocio;
using FankyRecords.C_datos;
using FankyRecords.C_entidad;

namespace FankyRecords.C_presentacion.Administrador
{
    public partial class GestionProveedores : Form
    {
        private readonly DatosProveedores CD_Proveedores;
        private readonly NegocioProveedores CN_Proveedores;
        private int proveedorIdSeleccionado; // Variable para almacenar el Id del proveedor seleccionado

        public GestionProveedores()
        {
            InitializeComponent();
            CD_Proveedores = new DatosProveedores();
            CN_Proveedores = new NegocioProveedores();

        }

        private void Bguardar_Click(object sender, EventArgs e)
        {
            GuardarProveedores();
        }


        private void GuardarProveedores()
        {
            try
            {
                //Verificamos que todos los campos estésn completos.
                if (C_negocio.Validaciones.EstaVacio(TBRazonSocial.Text) ||
                  C_negocio.Validaciones.EstaVacio(TBcuit.Text) ||
                  C_negocio.Validaciones.EstaVacio(TBcorreo.Text) ||
                  C_negocio.Validaciones.EstaVacio(TBtelefono.Text) ||
                  C_negocio.Validaciones.EstaVacio(TBdomiciliop.Text))
                {
                    MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Validación previa de duplicados en la base de datos
                if (CN_Proveedores.ExisteProveedor(TBRazonSocial.Text))
                {
                    MessageBox.Show("El proveedor ya existe. No se permiten duplicados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpiar();
                    return;
                }
                    //validar correo
                    string email = TBcorreo.Text;

                    if (!C_negocio.Validaciones.EmailCorrecto(email))
                    {
                        MessageBox.Show("El formato del correo electrónico no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                     //Confirmacion para continuar
                     if (C_negocio.Validaciones.mensajeConfirmacion())
                     {
                         // Crear objeto proveedor
                          Proveedores proveedores = new Proveedores
                          {
                             RazonSocial = TBRazonSocial.Text,
                             Estado = RBactivop.Checked ? "Activo" : "Inactivo"
                          };

                          // Intentar guardar la categoría en la base de datos
                          CN_Proveedores.GuardarProveedor(proveedores);

                          // Recargar datos y limpiar formulario
                          CargarProveedores();

                          Limpiar();
                     }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   

        private void Txtnumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsNumero(e);
        }

        private void Beliminar_Click(object sender, EventArgs e)
        {
            EliminarProveedor();
        }

        private void EliminarProveedor()
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
                    CN_Proveedores.EliminarProveedor(proveedorIdSeleccionado);

                    // Recargar datos y limpiar formulario
                    CargarProveedores();
                    Limpiar();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos
            Limpiar();
        }

        private void Beditar_Click(object sender, EventArgs e)
        {
            EditarProveedors();
        }

        private void EditarProveedors()
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
                    // Crear objeto proveedor
                   Proveedores proveedores = new Proveedores
                    {
                        ID_proveedor = proveedorIdSeleccionado, // Asignar el ID del proveedor seleccionado
                        RazonSocial = TBRazonSocial.Text,
                        Cuit = TBcuit.Text,
                        Correo = TBcorreo.Text,
                        Telefono= TBtelefono.Text,
                        Domicilio = TBdomiciliop.Text,
                        Estado = RBactivop.Checked ? "Activo" : "Inactivo"
                    };

                    // Llamar al método de negocio para guardar/editar el proveedor
                    CN_Proveedores.GuardarProveedor(proveedores);

                    // Recargar la lista de proveedores
                    CargarProveedores();
                    Limpiar();
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

        private void GestionProveedores_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void CargarProveedores()
        {
            List<Proveedores> proveedores = CN_Proveedores.ListarProveedores();
            DGlistaproveedores.DataSource = proveedores;
        }

        private void listadoProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica que el índice de fila es válido
            {
                DataGridViewRow row = DGlistaproveedores.Rows[e.RowIndex];

                // Accede al ID_proveedor si existe en el DataGridView
                if (row.Cells["ID_proveedor"] != null)
                {
                    proveedorIdSeleccionado = Convert.ToInt32(row.Cells["ID_proveedor"].Value);
                }

                // Rellenar otros campos del proveedor seleccionado
                if (row.Cells["RazonSocial"] != null)
                {
                    TBRazonSocial.Text = row.Cells["RazonSocial"].Value.ToString();
                }

                if (row.Cells["Cuit"] != null)
                {
                    TBcuit.Text = row.Cells["Cuit"].Value.ToString();
                }

                if (row.Cells["Correo"] != null)
                {
                    TBcorreo.Text = row.Cells["Correo"].Value.ToString();
                }

                if (row.Cells["Domicilio"] != null)
                {
                    TBdomiciliop.Text = row.Cells["Domicilio"].Value.ToString();
                }

              /*  if (row.Cells["Telefono"] != null)
                {
                    TBtelefono.Text = row.Cells["Telefono"].Value.ToString();
                }*/

                if (row.Cells["Estado"] != null)
                {
                    string estado = row.Cells["Estado"].Value.ToString();
                    RBactivop.Checked = estado == "Activo";
                    RBinactivop.Checked = estado == "Inactivo";
                }
            }
        }

        private void Limpiar()
        {
            TBRazonSocial.Clear();
            TBcuit.Clear();
            TBcorreo.Clear();
            TBtelefono.Clear();
            TBdomiciliop.Clear();
            RBactivop.Checked = true;
        }

        private void TBdomiciliop_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
