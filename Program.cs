using FankyRecords.C_presentacion.Administrador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FankyRecords.C_presentacion.Administrador
//namespace FankyRecords.C_presentacion.Vendedor
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formMenuAdmin());
            //Application.Run(new formMenuVendedor());
            //Application.Run(new GestionUsuarios());
        }
    }
}
