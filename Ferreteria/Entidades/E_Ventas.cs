using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Ventas
    {
        private string Id_Empleado;
        private string CodOrden;
        private string NombreCliente;
        private string NombreEmpleado;
        private string Search;
        private float Descuento;
        private int Cantidad;
        private decimal SubTotal;
        private decimal IVA;
        private decimal Total;

        public string Id_Empleado1 { get => Id_Empleado; set => Id_Empleado = value; }
        public string CodOrden1 { get => CodOrden; set => CodOrden = value; }
        public string NombreCliente1 { get => NombreCliente; set => NombreCliente = value; }
        public string NombreEmpleado1 { get => NombreEmpleado; set => NombreEmpleado = value; }
        public string Search1 { get => Search; set => Search = value; }
        public float Descuento1 { get => Descuento; set => Descuento = value; }
        public int Cantidad1 { get => Cantidad; set => Cantidad = value; }
        public decimal SubTotal1 { get => SubTotal; set => SubTotal = value; }
        public decimal IVA1 { get => IVA; set => IVA = value; }
        public decimal Total1 { get => Total; set => Total = value; }
    }
}
