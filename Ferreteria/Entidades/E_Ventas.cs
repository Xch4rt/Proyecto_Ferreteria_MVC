using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Ventas
    {
        private int Id_Empleado;
        private int Id_Orden;
        private int Id_Producto;
        private int Cantidad;
        private string CodOrden;
        private string NombreCliente;
        private string NombreEmpleado;
        private string Search;
        private decimal Descuento;
        private decimal SubTotal;
        private decimal IVA;
        private decimal Total;
        private decimal Precio;

        public decimal Precio1 { get => Precio; set => Precio = value; }
        public int Id_Empleado1 { get => Id_Empleado; set => Id_Empleado = value; }
        public int Id_Orden1 { get => Id_Orden; set => Id_Orden = value; }
        public int Id_Producto1 { get => Id_Producto; set => Id_Producto = value; }
        public int Cantidad1 { get => Cantidad; set => Cantidad = value; }
        public string CodOrden1 { get => CodOrden; set => CodOrden = value; }
        public string NombreCliente1 { get => NombreCliente; set => NombreCliente = value; }
        public string NombreEmpleado1 { get => NombreEmpleado; set => NombreEmpleado = value; }
        public string Search1 { get => Search; set => Search = value; }
        public decimal Descuento1 { get => Descuento; set => Descuento = value; }
        public decimal SubTotal1 { get => SubTotal; set => SubTotal = value; }
        public decimal IVA1 { get => IVA; set => IVA = value; }
        public decimal Total1 { get => Total; set => Total = value; }
    }
}
