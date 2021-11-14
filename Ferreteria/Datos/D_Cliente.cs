using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Cliente
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public void insertarCliente(E_Cliente cliente)
        {
            SqlCommand cmd = new SqlCommand("SP_InsertarCliente", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@PrimerNombre", cliente.PNombre1);
            cmd.Parameters.AddWithValue("@SegundoNombre", cliente.SNombre1);
            cmd.Parameters.AddWithValue("@PrimerApellido", cliente.PApellido1);
            cmd.Parameters.AddWithValue("@SegundoApellido", cliente.SApellido1);
            cmd.Parameters.AddWithValue("@NumTelf", cliente.NTelefono1);


            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EliminarCliente(int id)
        {
            SqlCommand cmd = new SqlCommand("SP_EliminarCliente", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IdCliente", id);


            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void ActualizarCliente(E_Cliente cliente)
        {
            SqlCommand cmd = new SqlCommand("SP_ActualizarCliente", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();
            cmd.Parameters.AddWithValue("@PrimerNombre", cliente.PNombre1);
            cmd.Parameters.AddWithValue("@SegundoNombre", cliente.SNombre1);
            cmd.Parameters.AddWithValue("@PrimerApellido", cliente.PApellido1);
            cmd.Parameters.AddWithValue("@SegundoApellido", cliente.SApellido1);
            cmd.Parameters.AddWithValue("@NumTelf", cliente.NTelefono1);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public DataTable BuscarClientes(E_Cliente cliente)
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_BuscarCliente", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", cliente.Search1);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);

            conexion.Close();
            return table;
        }
 
        public DataTable MostarClientes()
        {
            DataTable table = new DataTable();
            SqlDataReader leerfilas;
            SqlCommand cmd = new SqlCommand("SP_ListarClientes", conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            leerfilas = cmd.ExecuteReader();
            table.Load(leerfilas);

            leerfilas.Close();
            conexion.Close();

            return table;
        }

    }
}

