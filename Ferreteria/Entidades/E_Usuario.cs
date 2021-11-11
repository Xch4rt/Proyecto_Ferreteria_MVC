using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Usuario
    {
        private string Contraseña;
        private string Usuario;

        public string Contraseña1 { get => Contraseña; set => Contraseña = value; }
        public string Usuario1 { get => Usuario; set => Usuario = value; }

        public string getS()
        {
            return Usuario;
        }
        /*
        public string GetContraseña()
        {
            return GetContraseña();
        }

        public void SetContraseña(string value)
        {
            SetContraseña(value);
        }

        public string GetUsuario()
        {
            return GetUsuario();
        }

        public void SetUsuario(string value)
        {
            SetUsuario(value);
        }
        */
    }

   
}
