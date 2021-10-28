using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Datos;
using Entidades;

namespace Negocios
{
    public class N_Productos
    {
        D_Productos objData = new D_Productos();
        E_Productos eProducto = new E_Productos();

        public DataTable ListarProductos()
        {
            return objData.ListarProductos();
        }
        public DataTable BuscarProductos(string search)
        {
            eProducto.Search1 = search;
            return objData.BuscarProductos(eProducto);
        }
        public void CrearProducto(E_Productos product)
        {
            objData.CrearProducto(product);
        }
        public void ActualizarProducto(E_Productos product)
        {
            objData.ActualizarProducto(product);
        }
        public void EliminarProducto(int id)
        {
            objData.EliminarProducto(id);
        }
    }
}
