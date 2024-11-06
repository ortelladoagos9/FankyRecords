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
    public partial class GestionProveedores : Form
    {
        private readonly DatosProveedores CD_Proveedores;
        private readonly NegocioProveedores CN_Proveedores;
        private int proveedorSeleccionado;
        //int contador = 0;

        public GestionProveedores()
        {
            InitializeComponent();
            this.CBbuscar.SelectedIndex = 0;
            CD_Proveedores = new DatosProveedores();
            CN_Proveedores = new NegocioProveedores();
        }

        private void Bguardar_Click(object sender, EventArgs e)
        {
            GuardarProveedores();
        }

        private void GuardarProveedores()
        {
            if (C_negocio.Validaciones.EstaVacio(TBRazonSocial.Text) ||
              C_negocio.Validaciones.EstaVacio(TBcuit.Text) ||
              C_negocio.Validaciones.EstaVacio(TBcorreo.Text) ||
              C_negocio.Validaciones.EstaVacio(TBtelefono.Text) ||
              C_negocio.Validaciones.EstaVacio(TBdomiciliop.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Validación previa de duplicados en la base de datos
            if (CN_Proveedores.ExisteCuit(TBcuit.Text))
            {
                MessageBox.Show("El cuit ya existe. No se permiten duplicados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }
            if (CN_Proveedores.ExisteTelefono(TBtelefono.Text))
            {
                MessageBox.Show("El telefono ya existe. No se permiten duplicados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }
            if (CN_Proveedores.ExisteCorreo(TBcorreo.Text))
            {
                MessageBox.Show("El correo ya existe. No se permiten duplicados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }

            if (CN_Proveedores.ExisteRazonSocial(TBRazonSocial.Text))
            {
                MessageBox.Show("El Razon Social ya existe. No se permiten duplicados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
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
                        Proveedores proveedores = new Proveedores();
                        proveedores.RazonSocial = TBRazonSocial.Text;
                        proveedores.Cuit = TBcuit.Text;
                        proveedores.Domicilio = TBdomiciliop.Text;
                        proveedores.Correo = TBcorreo.Text;
                        proveedores.Telefono = TBtelefono.Text;
                        proveedores.Estado = RBactivop.Checked ? "Activo" : "Inactivo";


                        CN_Proveedores.GuardarProveedor(proveedores);

                        CargarProveedores();

                        Limpiar();
                    }
                }
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

                // Solo accede a las columnas si el índice es válido y la celda no es nula
                if (row.Cells["ID_proveedor"] != null)
                {
                   proveedorSeleccionado = Convert.ToInt32(row.Cells["ID_proveedor"].Value);
                }
                if (row.Cells["RazonSocial"] != null)
                {
                    TBRazonSocial.Text = row.Cells["RazonSocial"].Value.ToString();
                }
                if (row.Cells["Cuit"] != null)
                {
                    TBcuit.Text = row.Cells["Cuit"].Value.ToString();
                }
                if (row.Cells["Domicilio"] != null)
                {
                    TBdomiciliop.Text = row.Cells["Domicilio"].Value.ToString();
                }
                if (row.Cells["Correo"] != null)
                {
                    TBcorreo.Text = row.Cells["Correo"].Value.ToString();
                }
                if (row.Cells["Telefono"] != null)
                {
                    TBtelefono.Text = row.Cells["Telefono"].Value.ToString();
                }

                if (row.Cells["Estado"] != null)
                {
                    string estado = row.Cells["Estado"].Value.ToString();
                    RBactivop.Checked = estado == "Activo";
                    RBinactivop.Checked = estado == "Inactivo";
                }
            }
        }

        private void Txtnumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsNumero(e);
        }

        private void Beliminar_Click(object sender, EventArgs e)
        {
            EliminarProveedores();
        }

        private void EliminarProveedores()
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
                    CN_Proveedores.EliminarProveedor(proveedorSeleccionado);

                    // Recargar datos y limpiar formulario
                    CargarProveedores();
                    Limpiar();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar(); // Limpiar todos los campos

        }

        private void Beditar_Click(object sender, EventArgs e)
        {
            EditarProveedores();
        }
        private void EditarProveedores()
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
                        ID_proveedor = proveedorSeleccionado, // Asignar el ID del proveedor seleccionado
                        RazonSocial = TBRazonSocial.Text,
                        Cuit = TBcuit.Text,
                        Correo = TBcorreo.Text,
                        Telefono = TBtelefono.Text,
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

        private void Limpiar()
        {
            TBRazonSocial.Clear();
            TBcuit.Clear();
            TBcorreo.Clear();
            TBtelefono.Clear();
            TBdomiciliop.Clear();
        }
    }
}
