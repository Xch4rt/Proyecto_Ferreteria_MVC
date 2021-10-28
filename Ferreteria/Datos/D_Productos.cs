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
    }
}
