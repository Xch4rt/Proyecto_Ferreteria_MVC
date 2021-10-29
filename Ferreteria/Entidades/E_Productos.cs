using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Productos
    {
        private int IdProducto;
        private string CodigoProducto;
        private string Producto;
        private int IdCategoria;
        private int IdMarca;
        private decimal PrecioCompra;
        private decimal PrecioVenta;
        private int Stock;
        private string Search;

        private string totalCategorias;
        private string totalMarcas;
        private string totalProductos;
        private string totalStock;

        public int IdProducto1 { get => IdProducto; set => IdProducto = value; }
        public string CodigoProducto1 { get => CodigoProducto; set => CodigoProducto = value; }
        public string Producto1 { get => Producto; set => Producto = value; }
        public int IdCategoria1 { get => IdCategoria; set => IdCategoria = value; }
        public int IdMarca1 { get => IdMarca; set => IdMarca = value; }
        public decimal PrecioCompra1 { get => PrecioCompra; set => PrecioCompra = value; }
        public decimal PrecioVenta1 { get => PrecioVenta; set => PrecioVenta = value; }
        public int Stock1 { get => Stock; set => Stock = value; }

        public string Search1 { get => Search; set => Search = value; }
        public string TotalCategorias { get => totalCategorias; set => totalCategorias = value; }
        public string TotalMarcas { get => totalMarcas; set => totalMarcas = value; }
        public string TotalProductos { get => totalProductos; set => totalProductos = value; }
        public string TotalStock { get => totalStock; set => totalStock = value; }
    }
}
