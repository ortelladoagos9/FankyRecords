﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FankyRecords.C_presentacion.Administrativo
{
    public partial class FormMenuAdministrativo : Form
    {
        public FormMenuAdministrativo()
        {
            InitializeComponent();
        }

        private void IconSalirAdministrativo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IconExpandirAdministrativo_Click(object sender, EventArgs e)
        {
            // Si el formulario ya está maximizado, restaurarlo
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;  // Restaurar el tamaño normal
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;  // Maximizar el formulario
            }
        }

        private void IconMinimizarAdministrativo_Click(object sender, EventArgs e)
        {
            // Cambia el estado del formulario a minimizado
            this.WindowState = FormWindowState.Minimized;
        }

        
    }
}
