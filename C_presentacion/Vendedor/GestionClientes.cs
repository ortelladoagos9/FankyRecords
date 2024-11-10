using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FankyRecords.C_datos;
using FankyRecords.C_entidad;
using FankyRecords.C_negocio;


namespace FankyRecords.C_presentacion.Vendedor
{
    public partial class GestionClientes : Form
    {
        private readonly DatosClientes CD_Clientes;
        private readonly NegocioClientes CN_Clientes;
        private int clienteSeleccionado;
        public GestionClientes()
        {
            InitializeComponent();
            CD_Clientes= new DatosClientes();
            CN_Clientes= new NegocioClientes();
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
            GuardarCliente();
        }

        private void GuardarCliente()
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
                // Validación previa de duplicados en la base de datos
                if (CN_Clientes.ExisteDocumento(TBdni.Text))
                {
                    MessageBox.Show("El documento ya existe. No se permiten duplicados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                if (CN_Clientes.ExisteTelefono(TBtelefono.Text))
                {
                    MessageBox.Show("El telefono ya existe. No se permiten duplicados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                if (CN_Clientes.ExisteCorreo(TBemail.Text))
                {
                    MessageBox.Show("El correo ya existe. No se permiten duplicados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                if (C_negocio.Validaciones.mensajeConfirmacion())
                {

                    string email = TBemail.Text;

                    if (!C_negocio.Validaciones.EmailCorrecto(email))
                    {
                        MessageBox.Show("El formato del correo electrónico no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (C_negocio.Validaciones.mensajeConfirmacion())
                        {
                            Clientes clientes = new Clientes();
                            clientes.Documento = TBdni.Text;
                            clientes.Nombre = TBnombre.Text;
                            clientes.Apellido = TBapellido.Text;
                            clientes.Correo = TBemail.Text;
                            clientes.Telefono = TBtelefono.Text;
                            clientes.Estado = rBactivo.Checked ? "Activo" : "Inactivo";


                            CN_Clientes.GuardarCliente(clientes);

                            CargarClientes();

                            Limpiar();
                        }
                    }
                }
            }
        }

        private void GestionClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            List<Clientes> clientes = CN_Clientes.ListarClientes();
            listadoClientes.DataSource = clientes;
        }

        private void listadoClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // Verifica que el índice de fila es válido
            {
                DataGridViewRow row = listadoClientes.Rows[e.RowIndex];

                // Solo accede a las columnas si el índice es válido y la celda no es nula
                if (row.Cells["ID_cliente"] != null)
                {
                    clienteSeleccionado = Convert.ToInt32(row.Cells["ID_cliente"].Value);
                }
                if (row.Cells["Documento"] != null)
                {
                    TBdni.Text = row.Cells["Documento"].Value.ToString();
                }
                if (row.Cells["Nombre"] != null)
                {
                    TBnombre.Text = row.Cells["Nombre"].Value.ToString();
                }
                if (row.Cells["Apellido"] != null)
                {
                    TBapellido.Text = row.Cells["Apellido"].Value.ToString();
                }
                if (row.Cells["Correo"] != null)
                {
                    TBemail.Text = row.Cells["Correo"].Value.ToString();
                }
                if (row.Cells["Telefono"] != null)
                {
                    TBtelefono.Text = row.Cells["Telefono"].Value.ToString();
                }

                if (row.Cells["Estado"] != null)
                {
                    string estado = row.Cells["Estado"].Value.ToString();
                    rBactivo.Checked = estado == "Activo";
                    rBinactivo.Checked = estado == "Inactivo";
                }
            }
        }


        private void Beditar_Click(object sender, EventArgs e)
        {
            EditarCliente();
        }

        private void EditarCliente()
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
                    // Crear objeto proveedor
                    Clientes clientes= new Clientes
                    {
                        ID_cliente= clienteSeleccionado, // Asignar el ID del proveedor seleccionado
                        Documento = TBdni.Text,
                        Nombre = TBnombre.Text,
                        Apellido = TBapellido.Text,
                        Correo = TBemail.Text,
                        Telefono = TBtelefono.Text,
                        Estado = rBactivo.Checked ? "Activo" : "Inactivo"
                    };

                    // Llamar al método de negocio para guardar/editar el proveedor
                    CN_Clientes.GuardarCliente(clientes);

                    // Recargar la lista de proveedores
                    CargarClientes();
                    Limpiar();
                }
            }
        }

        private void Beliminar_Click(object sender, EventArgs e)
        {
            EliminarClientes();
        }
        private void EliminarClientes()
        {
            if (C_negocio.Validaciones.EstaVacio(TBdni.Text) ||
               C_negocio.Validaciones.EstaVacio(TBnombre.Text) ||
               C_negocio.Validaciones.EstaVacio(TBapellido.Text) ||
               C_negocio.Validaciones.EstaVacio(TBtelefono.Text) ||
               C_negocio.Validaciones.EstaVacio(TBemail.Text))
            {
                MessageBox.Show("No hay datos para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (C_negocio.Validaciones.mensajeEliminar())
                {
                    CN_Clientes.EliminarCliente(clienteSeleccionado);

                    // Recargar datos y limpiar formulario
                    CargarClientes();
                    Limpiar();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (C_negocio.Validaciones.EstaVacio(TBBuscador.Text))
            {
                MessageBox.Show("Debe ingresar un dato del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string terminoBusqueda = TBBuscador.Text;
                BuscarDatos(terminoBusqueda);
            }
        }
        //Metodo para buscar datos en el datagrid
        private void BuscarDatos(string termino)
        {
            foreach (DataGridViewRow row in listadoClientes.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(termino))
                    {
                        row.Selected = true;
                        listadoClientes.FirstDisplayedScrollingRowIndex = row.Index;
                        return;
                    }
                }
            }
            MessageBox.Show("No se encontraron coincidencias.");
        }


        private void Limpiar()
        {
            TBnombre.Clear();
            TBapellido.Clear();
            TBtelefono.Clear();
            TBdni.Clear();
            TBemail.Clear();

        }

        private void listadoClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Blimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
