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
    public class D_Ventas
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

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
        public DataTable lastOrdenId()
        {
            DataTable table = new DataTable();
            SqlDataReader leerFilas;
            SqlCommand cmd = new SqlCommand("SP_LastOrderID", conexion);
            cmd.CommandType = CommandType.Text;
            conexion.Open();

            leerFilas = cmd.ExecuteReader();
            table.Load(leerFilas);

            leerFilas.Close();
            conexion.Close();

            return table;


        }

        public void InsertarOrden(E_Ventas eVentas)
        {
            SqlCommand cmd = new SqlCommand("SP_InsertarOrden", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            cmd.Parameters.AddWithValue("@Fecha", eVentas.FechaCompra1);
            cmd.Parameters.AddWithValue("@IdEmpleado", eVentas.Id_Empleado1);
            cmd.Parameters.AddWithValue("@IdCliente", eVentas.Id_Cliente1);
            

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void InsertarDetalleOrden(E_Ventas eVentas)
        {
            SqlCommand cmd = new SqlCommand("SP_InsertarDetalleOrden", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            cmd.Parameters.AddWithValue("@Precio", eVentas.Precio1);
            cmd.Parameters.AddWithValue("@Cantidad", eVentas.Cantidad1);
            cmd.Parameters.AddWithValue("@Descuento", eVentas.Descuento1);
            cmd.Parameters.AddWithValue("@IdOrden", eVentas.Id_Orden1);
            cmd.Parameters.AddWithValue("@IdProducto", eVentas.Id_Producto1);


            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public DataTable LastCodID()
        {
            DataTable table = new DataTable();
            SqlDataReader leerFilas;
            SqlCommand cmd = new SqlCommand("SP_LastCodID", conexion);
            cmd.CommandType = CommandType.Text;
            conexion.Open();

            leerFilas = cmd.ExecuteReader();
            table.Load(leerFilas);

            leerFilas.Close();
            conexion.Close();

            return table;
        }
    }
}
