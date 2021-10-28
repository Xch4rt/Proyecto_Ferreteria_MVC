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

        public DataTable ListarProductos()
        {
            return objData.ListarProductos();
        }
    }
}
