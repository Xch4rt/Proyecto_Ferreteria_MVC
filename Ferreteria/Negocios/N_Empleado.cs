using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidades;
namespace Negocios
{
    public class N_Empleado
    {
        D_Empleado objDato = new D_Empleado();
        E_Empleado eEmpleado = new E_Empleado();

        public DataTable ListarEmpleados()
        {
            return objDato.ListarEmpleados();
        }
        public DataTable BuscarEmpleado(string search)
        {
            eEmpleado.Search1 = search;
            return objDato.BuscarEmpleados(eEmpleado);
        }
        public void InsertarEmpleado(E_Empleado empleado)
        {
            objDato.insertarEmpleado(empleado);
        }
        public void EditarEmpleado(E_Empleado empleado)
        {
            objDato.ActualizarEmpleado(empleado);
        }
        public void EliminarEmpleado(int id)
        {
            objDato.EliminarEmpleado(id);
        }
    }
}
