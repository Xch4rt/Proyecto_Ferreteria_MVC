using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Proveedor
    {
        private string NombreCompany;
        private string Contacto;
        private string Direccion;
        private int Telf;
        private int IdProveedor;
        private string Search;
        private int totalProveedor;

        public int totalProveedor1 { get => totalProveedor; set => totalProveedor = value; }
        public string Search1 { get => Search; set => Search = value; }
        public int IdProveedor1 { get => IdProveedor; set => IdProveedor = value; }
        public string NombreCompany1 { get => NombreCompany; set => NombreCompany = value; }
        public string Contacto1 { get => Contacto; set => Contacto = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public int Telf1 { get => Telf; set => Telf = value; }
    }
}
