using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using FankyRecords.C_presentacion;
using System.Windows.Forms;

namespace FankyRecords.C_negocio
{
    internal class Validaciones
    {
        public static bool EsLetra(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
               // Si no es una letra, cancela el evento
               e.Handled = true;
            }
               return char.IsLetter(e.KeyChar);
        }
        public static bool EsConcatenacionTexto(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                // Si no es una letra, cancela el evento
                e.Handled = true;
            }
            return char.IsLetter(e.KeyChar);
        }
        public static bool EsNumero(KeyPressEventArgs e)
        {
            // Verifica si el carácter presionado no es un número
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número, cancela el evento
                e.Handled = true;
            }
            return char.IsDigit(e.KeyChar);
        }
        public static bool EsDecimal(KeyPressEventArgs e)
        {
            // Permite solo números, punto decimal, backspace y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            return char.IsDigit(e.KeyChar);
        }
        
        public static bool EstaVacio(string e)
        {
            string campo = e.ToString();
            return string.IsNullOrEmpty(campo);
        }

        public static bool ContraseñaCorrecta(string e, string e2)
        {
            string password = e.ToString();
            string confirmPassword = e2.ToString();

            // Validar si las contraseñas coinciden
            if (password != confirmPassword)
            {
                return false;
            }

            // Validar si la contraseña contiene espacios en blanco
            if (password.Contains(" "))
            {
                return false;
            }
         
            return true; // Si pasa todas las validaciones, la contraseña es correcta.
        }

        public static bool EmailCorrecto(string e)
        {
            string email = e;

            // Expresión regular para validar el formato de correo electrónico
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            // Verificar si el email tiene el formato válido
            if (!Regex.IsMatch(email, emailPattern))
            {
                return false;
            }
            return true;
        }




    }
}
