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
    public class N_Proveedor
    {
        D_Proveedor objDato = new D_Proveedor();
        E_Proveedor eProveedor = new E_Proveedor();

        public DataTable ListarProveedores()
        {
            return objDato.ListarProveedor();
        }

        public DataTable BuscarProveedores(string search)
        {
            eProveedor.Search1 = search;
            return objDato.BuscarProveedor(eProveedor);
        }
        public void InsertarProveedores(E_Proveedor proveedor)
        {
            objDato.insertarProveedor(proveedor);
        }
        public void EditarProveedores(E_Proveedor proveedor)
        {
            objDato.ActualizarProveedor(proveedor);
        }
        public void EliminarProveedores(int id)
        {
            objDato.EliminarProveedor(id);
        }
        public void ShowingTotales(E_Proveedor proveedor)
        {
            objDato.ShowTotals(proveedor);
        }
    }
}
