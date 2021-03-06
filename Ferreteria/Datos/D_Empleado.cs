using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;
using Entidades;
using System.Data;

namespace Datos
{
    public class D_Empleado
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public void insertarEmpleado(E_Empleado empleado)
        {
            SqlCommand cmd = new SqlCommand("InsertarEmpleado", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Puesto", empleado.Puesto1);
            cmd.Parameters.AddWithValue("@PrimerNombre", empleado.PNombre1);
            cmd.Parameters.AddWithValue("@PrimerApellido", empleado.PApellido1);
            cmd.Parameters.AddWithValue("@SegundoNombre", empleado.SNombre1);
            cmd.Parameters.AddWithValue("@SegundoApellido", empleado.SApellido1);
            cmd.Parameters.AddWithValue("@FechaContrato", empleado.FechaContrato1);
            cmd.Parameters.AddWithValue("@Salario", empleado.Salario1);
            

            cmd.ExecuteNonQuery();
            conexion.Close();

        }
        
        public void EliminarEmpleado(int id)
        {
            SqlCommand cmd = new SqlCommand("SP_EliminarEmpleado", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IdEmpleado", id);


            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void ActualizarEmpleado(E_Empleado empleado)
        {
            SqlCommand cmd = new SqlCommand("SP_ActualizarEmpleado", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();
            cmd.Parameters.AddWithValue("@IdEmpleado", empleado.IdEmpleado1);
            cmd.Parameters.AddWithValue("@Puesto", empleado.Puesto1);
            cmd.Parameters.AddWithValue("@PrimerNombre", empleado.PNombre1);
            cmd.Parameters.AddWithValue("@PrimerApellido", empleado.PApellido1);
            cmd.Parameters.AddWithValue("@SegundoNombre", empleado.SNombre1);
            cmd.Parameters.AddWithValue("@SegundoApellido", empleado.SApellido1);
            cmd.Parameters.AddWithValue("@FechaContrato", empleado.FechaContrato1);
            cmd.Parameters.AddWithValue("@Salario", empleado.Salario1);
            //cmd.Parameters.AddWithValue("@IdUsuario", empleado.IdUsuario1);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public DataTable BuscarEmpleados(E_Empleado empleado)
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_BuscarEmpleado", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", empleado.Search1);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);

            conexion.Close();
            return table;
        }
        public DataTable ListarEmpleados()
        {
            DataTable table = new DataTable();
            SqlDataReader leerFilas;
            SqlCommand cmd = new SqlCommand("SP_ListarEmpleadosUsuarios", conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            leerFilas = cmd.ExecuteReader();
            table.Load(leerFilas);

            leerFilas.Close();
            conexion.Close();

            return table;
        }
        public DataTable ShowTotalEmployees() 
        {
            DataTable table = new DataTable();
            SqlDataReader leerfilas;
            SqlCommand cmd = new SqlCommand("SP_ListarEmpleados", conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            leerfilas = cmd.ExecuteReader();
            table.Load(leerfilas);

            leerfilas.Close();
            conexion.Close();

            return table;
        }
        public void ShowTotals(E_Empleado empleado)
        {
            SqlCommand cmd = new SqlCommand("summaryEmpleados", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter totalCategorias = new SqlParameter("@totalEmpleados", 0);
            totalCategorias.Direction = ParameterDirection.Output;

          

            cmd.Parameters.Add(totalCategorias);
   
            conexion.Open();

            cmd.ExecuteNonQuery();

            empleado.TotalEmpleado1 = Convert.ToInt32(cmd.Parameters["@totalEmpleados"].Value);
           

            conexion.Close();

        }
    }
}
