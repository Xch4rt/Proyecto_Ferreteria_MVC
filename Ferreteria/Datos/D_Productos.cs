using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using Entidades;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
    public class D_Productos
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public DataTable ListarProductos()
        {
            DataTable table = new DataTable();
            SqlDataReader leerFilas;
            SqlCommand cmd = new SqlCommand("SP_ListarProductos", conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            leerFilas = cmd.ExecuteReader();
            table.Load(leerFilas);

            leerFilas.Close();
            conexion.Close();

            return table;
        }

        public DataTable BuscarProductos(E_Productos product)
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_BuscarProductos", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", product.Search1);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);

            conexion.Close();
            return table;

        }

        public void EliminarProducto(int id)
        {
            SqlCommand cmd = new SqlCommand("SP_EliminarProductos", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IdProducto", id);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void CrearProducto(E_Productos product)
        {
            SqlCommand cmd = new SqlCommand("SP_CrearProducto", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            cmd.Parameters.AddWithValue("@Producto", product.Producto1);
            cmd.Parameters.AddWithValue("@Precio_Compra", product.PrecioCompra1);
            cmd.Parameters.AddWithValue("@Precio_Venta", product.PrecioVenta1);
            cmd.Parameters.AddWithValue("@Stock", product.Stock1);
            cmd.Parameters.AddWithValue("@IdCategoria", product.IdCategoria1);
            cmd.Parameters.AddWithValue("@IdMarca", product.IdMarca1);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void ActualizarProducto(E_Productos product)
        {
            SqlCommand cmd = new SqlCommand("SP_ActualizarProducto", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();
            cmd.Parameters.AddWithValue("@IdProducto", product.IdProducto1);
            cmd.Parameters.AddWithValue("@Producto", product.Producto1);
            cmd.Parameters.AddWithValue("@Precio_Compra", product.PrecioCompra1);
            cmd.Parameters.AddWithValue("@Precio_Venta", product.PrecioVenta1);
            cmd.Parameters.AddWithValue("@Stock", product.Stock1);
            cmd.Parameters.AddWithValue("@IdCategoria", product.IdCategoria1);
            cmd.Parameters.AddWithValue("@IdMarca", product.IdMarca1);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
