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
    public class N_Ventas
    {
        D_Ventas objData = new D_Ventas();
        E_Ventas eVentas = new E_Ventas();
        E_Productos eProductos = new E_Productos();

        public DataTable ListarProductos()
        {
            return objData.ListarProductos();
        }
        public DataTable BuscarProductos(string search)
        {
            eProductos.Search1 = search;
            return objData.BuscarProductos(eProductos);
        }
        public DataTable LastOrderID()
        {
           return  objData.lastOrdenId();
        }

        public void InsertarOrden(E_Ventas eVentas)
        {
            objData.InsertarOrden(eVentas);
        }
        public void InsertarDetalleOrden(E_Ventas eVentas)
        {
            objData.InsertarDetalleOrden(eVentas);
        }
        public DataTable LastCodID()
        {
            return objData.LastCodID();
        }
    }
}
