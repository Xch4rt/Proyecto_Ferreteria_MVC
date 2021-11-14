using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class N_Cliente
    {
        D_Cliente objDato = new D_Cliente();
        E_Cliente eCliente = new E_Cliente();

        public DataTable ListarClientes()
        {
            return objDato.MostarClientes();
        }
  
        public DataTable BuscarCliente(string search)
        {
            eCliente.Search1 = search;
            return objDato.BuscarClientes(eCliente);
        }
        public void InsertarCliente(E_Cliente cliente)
        {
            objDato.insertarCliente(cliente);
        }
        public void EditarCliente(E_Cliente cliente)
        {
            objDato.ActualizarCliente(cliente);
        }
        public void EliminarCliente(int id)
        {
            objDato.EliminarCliente(id);
        }
    }
}
