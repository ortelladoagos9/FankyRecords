using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FankyRecords.C_datos;
using FankyRecords.C_entidad;
using System.Data.SqlClient;
using System.Data;
using FankyRecords.C_presentacion.Administrador;
using System.Windows.Forms;
using FankyRecords.C_presentacion.Modales;

namespace FankyRecords.C_negocio
{
    internal class NegocioVentas
    {
        private DatosVenta CD_Ventas;

        public NegocioVentas()
        {
            CD_Ventas = new DatosVenta();
        }

        public int ObtenerCorrelativo()
        {
            return CD_Ventas.ObtenerCorrelativo();
        }

        public Clientes ObtenerDatosCliente(int idCliente)
        {
            return CD_Ventas.ObtenerDatosCliente(idCliente);
        }

        public (string Nombre, string Descripcion) ObtenerDatosProducto(int idProducto)
        {
            return CD_Ventas.ObtenerDatosProducto(idProducto);
        }

        public bool RegistrarVenta(Venta venta, DataTable detalleVenta, out string Mensaje)
        {
            return CD_Ventas.RegistrarVentas(venta, detalleVenta, out Mensaje);
        }

        public Venta ObtenerVenta(string numero)
        {
            return CD_Ventas.ObtenerVenta(numero);
        }

        public List<Venta> ListarVentas()
        {
            return CD_Ventas.ListarVentas();
        }
    }
}
