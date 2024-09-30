using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FankyRecords.C_presentacion.Administrador
{
    public partial class registrarVentas : Form
    {
        decimal sumaSubtotal = 0;
        public registrarVentas()
        {
            InitializeComponent();
            this.cbTipoDoc.SelectedIndex = 0;
            // Inicializar el temporizador
            delayTimer = new System.Windows.Forms.Timer();
            delayTimer.Interval = 2000; // Ajusta el intervalo según tus necesidades (en milisegundos)
            delayTimer.Tick += DelayTimer_Tick;
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (C_negocio.Validaciones.EstaVacio(cbTipoDoc.Text) ||
               C_negocio.Validaciones.EstaVacio(TBNroDocumento.Text) ||
               C_negocio.Validaciones.EstaVacio(TBCodProducto.Text) ||
               C_negocio.Validaciones.EstaVacio(TBPrecio.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (C_negocio.Validaciones.mensajeConfirmacion())
                {
                    decimal subtotal = numCantidad.Value * Convert.ToDecimal(TBPrecio.Text);
                    sumaSubtotal += subtotal;
                    TBTotalAPagar.Text = sumaSubtotal.ToString();

                    int n = listadoVentaProducto.Rows.Add();

                    listadoVentaProducto.Rows[n].Cells[0].Value = TBProducto.Text;
                    listadoVentaProducto.Rows[n].Cells[1].Value = TBPrecio.Text;
                    listadoVentaProducto.Rows[n].Cells[2].Value = numCantidad.Text;
                    listadoVentaProducto.Rows[n].Cells[3].Value = subtotal;

                    // limpia campos
                    TBPrecio.Clear();
                    numCantidad.Value = 1;
                    TBNombreCompleto.Clear();
                    TBCodProducto.Clear();
                    TBNroDocumento.Clear();
                    cbTipoDoc.SelectedIndex = -1;  // Deselect the ComboBox

                    permitirTextChanged = true;
                }
            }
        }
       
        private void TBRecibe_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsDecimal(e); 
        }

        private void Txtnumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsNumero(e);
        }

        private void Txtpalabras_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsConcatenacionTexto(e);
        }

        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
            delayTimer.Stop();
            
            if (C_negocio.Validaciones.EstaVacio(TBTotalAPagar.Text) ||
               C_negocio.Validaciones.EstaVacio(TBRecibe.Text) ||
               C_negocio.Validaciones.EstaVacio(TBCambio.Text))
            {
                MessageBox.Show("Debe indicar cuánto efectivo se recibió o completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                permitirTextChanged = false; // Desactivamos el evento TextChanged
                // Mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas crear la venta?",
                                                          "Confirmación",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    TBTotalAPagar.Clear();
                    TBCambio.Clear();
                    TBRecibe.Clear();

                    MessageBox.Show("La venta ha sido creada correctamente.",
                                        "Éxito",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La operación de crear venta ha sido cancelada.",
                                         "Cancelado",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Warning);
                }

            }

        }

        private System.Windows.Forms.Timer delayTimer;
        private bool permitirTextChanged = true; // Variable para controlar la ejecución del evento

        private void TBRecibe_TextChanged(object sender, EventArgs e)
        {
            if (!permitirTextChanged) return; // Si permitirTextChanged es falso, salimos del evento

            delayTimer.Stop(); // Detener el temporizador si ya estaba corriendo
            delayTimer.Start(); // Iniciar el temporizador
        }
        private void DelayTimer_Tick(object sender, EventArgs e)
        {
            delayTimer.Stop();

            decimal recibe, totalPagar;

            // Intenta convertir los valores, manejando posibles errores
            if (!decimal.TryParse(TBRecibe.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out recibe) ||
                !decimal.TryParse(TBTotalAPagar.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out totalPagar))
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos en el campo 'Recibe'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBCambio.Clear();
                return; // Salir de la función si hay errores de conversión
            }

            if (recibe >= totalPagar)
            {
                decimal cambio = recibe - totalPagar;
                TBCambio.Text = cambio.ToString(CultureInfo.InvariantCulture); // Usar CultureInfo para consistencia
            }
            else if (string.IsNullOrEmpty(TBRecibe.Text))
            {
                TBCambio.Clear();
            }
            else
            {
                MessageBox.Show("Debe ingresar un número mayor o igual al total", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBCambio.Clear();
            }
        }

       
    }
}
