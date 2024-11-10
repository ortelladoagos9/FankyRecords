using FankyRecords.C_datos;
using FankyRecords.C_entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FankyRecords.C_negocio
{
    public class NegocioClientes
    {
        private DatosClientes CD_Clientes;

        public NegocioClientes()
        {
            CD_Clientes= new DatosClientes();
        }

        public Clientes GuardarCliente(Clientes cliente)
        {
            if (cliente.ID_cliente == 0)
            {
                CD_Clientes.AgregarCliente(cliente);
            }
            else
            {
                CD_Clientes.EditarCliente(cliente);
            }
            return cliente;
        }

        public bool ExisteDocumento(string documento)
        {
            return CD_Clientes.ExisteDocumento(documento);
        }
        public bool ExisteTelefono(string telefono)
        {
            return CD_Clientes.ExisteTelefono(telefono);
        }
        public bool ExisteCorreo(string correo)
        {
            return CD_Clientes.ExisteCorreo(correo);
        }

        public List<Clientes> ListarClientes()
        {
            return CD_Clientes.ListarClientes();
        }

        public void EliminarCliente(int ID_cliente)
        {
            CD_Clientes.EliminarCliente(ID_cliente);
        }


    }
}
