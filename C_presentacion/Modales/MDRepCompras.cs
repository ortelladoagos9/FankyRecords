using System;
using System.Collections.Generic;
using System.ComponentModel;
using FankyRecords.C_entidad;
using FankyRecords.C_negocio;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FankyRecords.C_presentacion.Modales
{
    public partial class MDRepCompras : Form
    {

        public MDRepCompras()
        {
            InitializeComponent();
            this.KeyPreview = true;

        }

        public void MDRepCompras_Load(object sender, EventArgs e)
        {

        }
    }
}
/*public partial class MDCompra : Form
  {
      public Compra CompraMD { get; set; }
      private readonly NegocioCompras CN_Compras;

      public MDCompra()
      {
          InitializeComponent();
          this.KeyPreview = true;
          CN_Compras = new NegocioCompras();
      }*/
