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

        public DataTable GrafCategorias()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("ProductosCategoria", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);

            conexion.Close();
            return table;
        }


        public DataTable GrafProductosPreferidos()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_TopTresProdPreferidos", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);

            conexion.Close();
            return table;
        }

        public void SummaryTotals(E_Grafica grafica)
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("summaryTotals", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter totalVentas = new SqlParameter("@totalVentas", 0);
            totalVentas.Direction = ParameterDirection.Output;

            SqlParameter CantCategorias = new SqlParameter("@CantCategorias", 0);
            CantCategorias.Direction = ParameterDirection.Output;

            SqlParameter CantMarcas = new SqlParameter("@CantMarcas", 0);
            CantMarcas.Direction = ParameterDirection.Output;

            SqlParameter CantProductos = new SqlParameter("@CantProductos", 0);
            CantProductos.Direction = ParameterDirection.Output;

            SqlParameter CantEmpleados = new SqlParameter("@CantEmpleados", 0);
            CantEmpleados.Direction = ParameterDirection.Output;

            SqlParameter CantClientes = new SqlParameter("@CantClientes", 0);
            CantClientes.Direction = ParameterDirection.Output;

            SqlParameter CantProveedores = new SqlParameter("@CantProveedores", 0);
            CantProveedores.Direction = ParameterDirection.Output;

            

            cmd.Parameters.Add(totalVentas);
            cmd.Parameters.Add(CantCategorias);
            cmd.Parameters.Add(CantMarcas);
            cmd.Parameters.Add(CantProductos);
            cmd.Parameters.Add(CantEmpleados);
            cmd.Parameters.Add(CantClientes);
            cmd.Parameters.Add(CantProveedores);


            conexion.Open();

            cmd.ExecuteNonQuery();

            grafica.TotalVentas = cmd.Parameters["@totalVentas"].Value.ToString();
            grafica.TotalCategorias = cmd.Parameters["@CantCategorias"].Value.ToString();
            grafica.TotalMarcas = cmd.Parameters["@CantMarcas"].Value.ToString();
            grafica.TotalProductos = cmd.Parameters["@CantProductos"].Value.ToString();
            grafica.TotalEmpleados = cmd.Parameters["@CantEmpleados"].Value.ToString();
            grafica.TotalClientes = cmd.Parameters["@CantClientes"].Value.ToString();
            grafica.TotalProveedores = cmd.Parameters["@CantProveedores"].Value.ToString();

            conexion.Close();
        }
    }
}
