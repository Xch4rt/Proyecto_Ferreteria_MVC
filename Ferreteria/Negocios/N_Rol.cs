using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using Datos;
namespace Negocios
{
    public class N_Rol
    {
        D_Rol objData = new D_Rol();

        public List<E_Rol> listandoRoles(string buscar)
        {
            return objData.ListarRoles(buscar);
        }
    }
}
