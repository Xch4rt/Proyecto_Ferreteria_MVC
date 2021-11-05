using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Usuarios
    {
        private string Username;
        private string Password;
        private string Estado;
        private int IdEmpleado;
        private int IdRol;

        public string Username1 { get => Username; set => Username = value; }
        public string Password1 { get => Password; set => Password = value; }
        public string Estado1 { get => Estado; set => Estado = value; }
        public int IdEmpleado1 { get => IdEmpleado; set => IdEmpleado = value; }
        public int IdRol1 { get => IdRol; set => IdRol = value; }
    }
}
