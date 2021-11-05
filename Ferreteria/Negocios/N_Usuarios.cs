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
    public class N_Usuarios
    {
        D_Usuarios objData = new D_Usuarios();
        E_Usuarios eProducto = new E_Usuarios();

        public void CrearUsuario(E_Usuarios usuario)
        {
            objData.CrearUsuario(usuario);
        }
    }
}
