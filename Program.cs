using FankyRecords.C_presentacion.Administrador;
using FankyRecords.C_presentacion.Administrativo;
using FankyRecords.C_presentacion.Vendedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FankyRecords.C_presentacion
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

            Application.Run(new Login());
            //Application.Run(new FormMenuVendedor());
            //Application.Run(new FormMenuAdministrativo());
        }
    }
}
