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
            //Verificamos que todos los campos estésn completos.
            if (C_negocio.Validaciones.EstaVacio(TBRazonSocial.Text) ||
                C_negocio.Validaciones.EstaVacio(TBcuit.Text) ||
                C_negocio.Validaciones.EstaVacio(TBcorreo.Text) ||
                C_negocio.Validaciones.EstaVacio(TBtelefono.Text) ||
                C_negocio.Validaciones.EstaVacio(TBdomiciliop.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validación previa de duplicados en la base de datos
            if (CN_Proveedores.ExisteProveedor(TBRazonSocial.Text))
            {
                MessageBox.Show("El proveedor ya existe. No se permiten duplicados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //validar correo
            string email = TBcorreo.Text;

            if (!C_negocio.Validaciones.EmailCorrecto(email))
            {
                MessageBox.Show("El formato del correo electrónico no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Crear objeto proveedor
            Proveedores proveedores = new Proveedores
            {
                RazonSocial = TBRazonSocial.Text,
                Correo = TBcorreo.Text,
                Cuit = TBcuit.Text,
                Domicilio = TBdomiciliop.Text,
                Telefono = TBtelefono.Text,
                Estado = RBactivop.Checked ? "Activo" : "Inactivo"
            };
            try
            {
                DialogResult ask = MessageBox.Show("¿Seguro que desea insertar un nuevo proveedor?", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ask == DialogResult.Yes)
                {
                    // Intentar guardar la categoría en la base de datos
                    CN_Proveedores.GuardarProveedor(proveedores);

                    MessageBox.Show("El proveedor: " + this.TBRazonSocial.Text + " " + "se inserto correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Recargar datos y limpiar formulario
                    CargarProveedores();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
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
                MessageBox.Show("Debe completar todos los campos para poder desactivar un proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Verificar si el proveedor existe en la base de datos
            Proveedores proveedorExistente = CN_Proveedores.ObtenerProveedoresPorID(proveedorIdSeleccionado);
            if (proveedorExistente == null)
            {
                MessageBox.Show("El proveedor seleccionado no se encuentra en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
                return;
            }
            if (C_negocio.Validaciones.mensajeEliminar())
            {
                CN_Proveedores.EliminarProveedor(proveedorIdSeleccionado);

                // Recargar datos y limpiar formulario
                CargarProveedores();
                Limpiar();
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
                return;
            }
            // Verificar si el proveedor existe en la base de datos
            Proveedores proveedorExistente = CN_Proveedores.ObtenerProveedoresPorID(proveedorIdSeleccionado);
            if (proveedorExistente == null)
            {
                MessageBox.Show("El proveedor seleccionado no se encuentra en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
                return;
            }
            // Crear objeto proveedor
            Proveedores proveedores = new Proveedores
            {
                ID_proveedor = proveedorIdSeleccionado, // Asignar el ID del proveedor seleccionado
                RazonSocial = TBRazonSocial.Text,
                Cuit = TBcuit.Text,
                Correo = TBcorreo.Text,
                Telefono = TBtelefono.Text,
                Domicilio = TBdomiciliop.Text,
                Estado = RBactivop.Checked ? "Activo" : "Inactivo"
            };
            try
            {
                DialogResult ask = MessageBox.Show("¿Seguro que desea editar proveedor?", "Confirmar edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ask == DialogResult.Yes)
                {
                    // Llamar al método de negocio para guardar/editar el proveedor
                    CN_Proveedores.GuardarProveedor(proveedores);

                    MessageBox.Show("El proveedor: " + this.TBRazonSocial.Text + " " + "se edito correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Recargar la lista de proveedores
                    CargarProveedores();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ValidarYBuscar();
        }

        private void ValidarYBuscar()
        {
            if (C_negocio.Validaciones.EstaVacio(TBBuscador.Text))
            {
                MessageBox.Show("Debe ingresar un dato para buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string terminoBusqueda = TBBuscador.Text;
                BuscarDatos(terminoBusqueda);
            }
        }

        private void BuscarDatos(string termino)
        {
            bool encontrado = false;
            string busqueda = termino.ToLower().Trim(); // Convertir a minúsculas y quitar espacios extra

            // Desactivar la selección para evitar conflictos
            DGlistaproveedores.ClearSelection();
            DGlistaproveedores.CurrentCell = null;

            foreach (DataGridViewRow row in DGlistaproveedores.Rows)
            {
                bool filaVisible = false;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null)
                        continue;

                    string textoCelda = cell.Value.ToString().ToLower().Trim();

                    // Separar el contenido de la celda en palabras (quitando espacios extras)
                    string[] palabrasCelda = textoCelda.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (busqueda.Contains(" "))
                    {
                        // Búsqueda multi-palabra: dividimos el término en palabras
                        string[] palabrasBusqueda = busqueda.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                        // Revisar cada segmento contiguo de palabras en la celda con la cantidad de palabras en la búsqueda
                        for (int i = 0; i <= palabrasCelda.Length - palabrasBusqueda.Length; i++)
                        {
                            bool coincideTodo = true;
                            for (int j = 0; j < palabrasBusqueda.Length; j++)
                            {
                                // Se usa StartsWith para permitir coincidencias parciales en cada palabra
                                if (!palabrasCelda[i + j].StartsWith(palabrasBusqueda[j]))
                                {
                                    coincideTodo = false;
                                    break;
                                }
                            }
                            if (coincideTodo)
                            {
                                filaVisible = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        // Búsqueda de una sola palabra: se comprueba si alguna palabra de la celda comienza con el término
                        if (palabrasCelda.Any(palabra => palabra.StartsWith(busqueda)))
                        {
                            filaVisible = true;
                        }
                    }

                    if (filaVisible)
                        break;
                }

                // Si la fila actual está oculta y es la fila con foco, cambiar a otra fila visible
                if (!filaVisible && DGlistaproveedores.CurrentRow == row)
                {
                    foreach (DataGridViewRow otraFila in DGlistaproveedores.Rows)
                    {
                        if (otraFila != row && otraFila.Visible)
                        {
                            DGlistaproveedores.CurrentCell = otraFila.Cells[0];
                            break;
                        }
                    }
                }

                // Aplicar la visibilidad a la fila
                row.Visible = filaVisible;
                if (filaVisible)
                    encontrado = true;
            }

            if (!encontrado)
            {
                MessageBox.Show("No se encontraron coincidencias.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBBuscador.Clear();
            }
        }

        private void GestionProveedores_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void CargarProveedores()
        {
            List<Proveedores> proveedores = CN_Proveedores.ListarProveedores();
            //var proveedoresActivos = proveedores.Where(c => c.Estado == "Activo").ToList();
            DGlistaproveedores.DataSource = proveedores;
        }

        private void Limpiar()
        {
            // Deselecciona la fila actual en el DataGridView
            DGlistaproveedores.ClearSelection();
            // Resetea el ID del cliente seleccionado
            proveedorIdSeleccionado = -1;
            TBRazonSocial.Clear();
            TBcuit.Clear();
            TBcorreo.Clear();
            TBtelefono.Clear();
            TBdomiciliop.Clear();
            RBactivop.Checked = true;
        }

        private void DGlistaproveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que el índice de fila es válido y que no es un encabezado (e.RowIndex >= 0)
            if (e.RowIndex >= 0)
            {
                // Deselecciona la fila actual en el DataGridView
                DGlistaproveedores.ClearSelection();

                // Limpia los controles de entrada
                Limpiar();

                // Resetea el ID del cliente seleccionado
                proveedorIdSeleccionado = -1;
            }
        }

        private void DGlistaproveedores_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void TBBuscador_TextChanged(object sender, EventArgs e)
        {
            if (TBBuscador.Text == "")
            {
                CargarProveedores();
            }
        }

        private void TBBuscador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidarYBuscar();  // Llama al método  ValidarYBuscar() cuando se presiona Enter
                e.SuppressKeyPress = true;  // Evita el sonido de la tecla
            }
        }
    }
}
