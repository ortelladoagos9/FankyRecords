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

        public static bool EstaVacio(string e)
        {
            string campo = e.ToString();
            return string.IsNullOrEmpty(campo);
        }
  
       

    }
}
