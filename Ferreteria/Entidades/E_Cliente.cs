using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Cliente
    {
        private int IdCliente;
        private string CodigoCliente;
        private string PNombre;
        private string SNombre;
        private string PApellido;
        private string SApellido;
        private int NTelefono;
        private string Search;

        public int IdCliente1 { get => IdCliente; set => IdCliente = value; }
        public string CodigoCliente1 { get => CodigoCliente; set => CodigoCliente = value; }
        public string PNombre1 { get => PNombre; set => PNombre = value; }
        public string SNombre1 { get => SNombre; set => SNombre = value; }
        public string PApellido1 { get => PApellido; set => PApellido = value; }
        public string SApellido1 { get => SApellido; set => SApellido = value; }
        public int NTelefono1 { get => NTelefono; set => NTelefono = value; }
        public string Search1 { get => Search; set => Search = value; }
    }

}
