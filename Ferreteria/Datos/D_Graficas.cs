using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace Datos
{
    public class D_Graficas
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public DataTable GraficaBarra()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_CantidadProductos", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);

            conexion.Close();
            return table;
        }
        public DataTable GraficaPastel()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_CantidadRepresentaInventario", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);

            conexion.Close();
            return table;
        }
        public DataTable GraficaLineal()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_CantidadVentasEmpleado", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);

            conexion.Close();
            return table;
        }
    }
}
