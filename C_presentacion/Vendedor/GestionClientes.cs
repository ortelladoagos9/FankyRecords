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
                    return;
                }
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

                string email = TBemail.Text;

                if (!C_negocio.Validaciones.EmailCorrecto(email))
                {
                    MessageBox.Show("El formato del correo electrónico no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            Clientes clientes = new Clientes();
            clientes.Documento = TBdni.Text;
            clientes.Nombre = TBnombre.Text;
            clientes.Apellido = TBapellido.Text;
            clientes.Correo = TBemail.Text;
            clientes.Telefono = TBtelefono.Text;
            clientes.Estado = rBactivo.Checked ? "Activo" : "Inactivo";
            try
            {
                DialogResult ask = MessageBox.Show("¿Seguro que desea insertar un nuevo cliente?", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ask == DialogResult.Yes)
                {
                    // Intentar guardar la categoría en la base de datos
                    CN_Clientes.GuardarCliente(clientes);

                    MessageBox.Show("El cliente: " + this.TBnombre.Text + " " + this.TBapellido.Text + " " + "se inserto correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Recargar datos y limpiar formulario
                    CargarClientes();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
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
                    return;
                }
                // Verificar si el cliente existe en la base de datos
                Clientes clienteExistente = CN_Clientes.ObtenerClientePorID(clienteSeleccionado);
                if (clienteExistente == null)
                {
                    MessageBox.Show("El cliente seleccionado no se encuentra en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpiar();
                    return;
                }
                // Crear objeto clientes
                Clientes clientes = new Clientes
                {
                    ID_cliente = clienteSeleccionado, // Asignar el ID del proveedor seleccionado
                    Documento = TBdni.Text,
                    Nombre = TBnombre.Text,
                    Apellido = TBapellido.Text,
                    Correo = TBemail.Text,
                    Telefono = TBtelefono.Text,
                    Estado = rBactivo.Checked ? "Activo" : "Inactivo"
                };
                try
                {
                    DialogResult ask = MessageBox.Show("¿Seguro que desea editar cliente?", "Confirmar edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (ask == DialogResult.Yes)
                    {
                        // Llamar al método de negocio para guardar/editar el proveedor
                        CN_Clientes.GuardarCliente(clientes);

                        MessageBox.Show("El cliente: " + this.TBnombre.Text + " " + this.TBapellido.Text + " " + "se edito correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Recargar datos y limpiar formulario
                        CargarClientes();
                        Limpiar();
                    }
                }
                catch (Exception ex)
                {
                     MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                return;
            }
            // Verificar si el cliente existe en la base de datos
            Clientes clienteExistente = CN_Clientes.ObtenerClientePorID(clienteSeleccionado);
            if (clienteExistente == null)
            {
                MessageBox.Show("El cliente seleccionado no se encuentra en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
                return;
            }
            if (C_negocio.Validaciones.mensajeEliminar())
            {
                CN_Clientes.EliminarCliente(clienteSeleccionado);

                // Recargar datos y limpiar formulario
                CargarClientes();
                Limpiar();
            }
            
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
            bool encontrado = false;

            // Desactivar la selección temporalmente para evitar conflictos al ocultar filas
            listadoClientes.ClearSelection();

            // Iterar sobre todas las filas del DataGridView
            foreach (DataGridViewRow row in listadoClientes.Rows)
            {
                bool filaVisible = false;

                // Iterar sobre todas las celdas de la fila
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().StartsWith(termino.ToLower()))
                    {
                        filaVisible = true;
                        encontrado = true;
                        break; // Detener la búsqueda en esta fila si ya hay coincidencia
                    }
                }

                // Cambiar la fila actual para evitar que esté en una fila que se va a hacer invisible
                if (!filaVisible && listadoClientes.CurrentRow == row)
                {
                    listadoClientes.CurrentCell = null; // Deseleccionar la celda actual
                }

                // Mostrar u ocultar la fila según si hubo coincidencia
                row.Visible = filaVisible;
            }

            // Mostrar mensaje si no se encontraron coincidencias
            if (!encontrado)
            {
                MessageBox.Show("No se encontraron coincidencias.");
            }
        }

        private void Limpiar()
        {
            TBnombre.Clear();
            TBapellido.Clear();
            TBtelefono.Clear();
            TBdni.Clear();
            TBemail.Clear();
            rBactivo.Checked = true;

        }

        private void Blimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void listadoClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que el índice de fila es válido y que no es un encabezado (e.RowIndex >= 0)
            if (e.RowIndex >= 0)
            {
                // Deselecciona la fila actual en el DataGridView
                listadoClientes.ClearSelection();

                // Limpia los controles de entrada
                Limpiar();

                // Resetea el ID del cliente seleccionado
                clienteSeleccionado = -1; 
            }
        }

        private void TBBuscador_TextChanged(object sender, EventArgs e)
        {
            if (TBBuscador.Text == "")
            {
                CargarClientes();
            }
        }
    }
}
