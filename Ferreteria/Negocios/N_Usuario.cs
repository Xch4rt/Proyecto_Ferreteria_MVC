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
    public class N_Usuario
    {
        D_Usuario objData = new D_Usuario();
        E_Usuario eProducto = new E_Usuario();

        public  DataTable Validar_acceso(string usuario, string contraseña)
        {
            return  objData.Validar_acceso(usuario, contraseña);
        }
    }
}
