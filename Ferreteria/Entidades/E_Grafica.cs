using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Grafica
    {
        private string totalVentas;
        private string totalCategorias;
        private string totalMarcas;
        private string totalProductos;
        private string totalEmpleados;
        private string totalClientes;
        private string totalProveedores;

        public string TotalVentas { get => totalVentas; set => totalVentas = value; }
        public string TotalCategorias { get => totalCategorias; set => totalCategorias = value; }
        public string TotalMarcas { get => totalMarcas; set => totalMarcas = value; }
        public string TotalProductos { get => totalProductos; set => totalProductos = value; }
        public string TotalEmpleados { get => totalEmpleados; set => totalEmpleados = value; }
        public string TotalClientes { get => totalClientes; set => totalClientes = value; }
        public string TotalProveedores { get => totalProveedores; set => totalProveedores = value; }
    }
}
