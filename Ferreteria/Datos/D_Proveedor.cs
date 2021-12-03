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
    public class D_Proveedor
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public void insertarProveedor(E_Proveedor proveedor)
        {
            SqlCommand cmd = new SqlCommand("SP_InsertarProveedor", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NombreCompany", proveedor.NombreCompany1);
            cmd.Parameters.AddWithValue("@NombreContacto", proveedor.Contacto1);
            cmd.Parameters.AddWithValue("@Direccion", proveedor.Direccion1);
            cmd.Parameters.AddWithValue("@Telf", proveedor.Telf1);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }
        public void EliminarProveedor(int id)
        {
            SqlCommand cmd = new SqlCommand("SP_EliminarProveedor", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IdProveedor", id);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void ActualizarProveedor(E_Proveedor proveedor)
        {
            SqlCommand cmd = new SqlCommand("SP_ActualizarProveedor", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();
            cmd.Parameters.AddWithValue("@IdProveedor", proveedor.IdProveedor1);
            cmd.Parameters.AddWithValue("@NombreCompany", proveedor.NombreCompany1);
            cmd.Parameters.AddWithValue("@NombreContacto", proveedor.Contacto1);
            cmd.Parameters.AddWithValue("@Direccion", proveedor.Direccion1);
            cmd.Parameters.AddWithValue("@Telf", proveedor.Telf1);
            

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public DataTable BuscarProveedor(E_Proveedor proveedor)
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_BuscarProveedor", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", proveedor.Search1);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);

            conexion.Close();
            return table;
        }
        public DataTable ListarProveedor()
        {
            DataTable table = new DataTable();
            SqlDataReader leerFilas;
            SqlCommand cmd = new SqlCommand("SP_ListarProveedores", conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            leerFilas = cmd.ExecuteReader();
            table.Load(leerFilas);

            leerFilas.Close();
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

        public void ShowTotals(E_Proveedor proveedor)
        {
            SqlCommand cmd = new SqlCommand("summaryProveedores", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter totalProveedor = new SqlParameter("@totalProveedores", 0);
            totalProveedor.Direction = ParameterDirection.Output;

           

            cmd.Parameters.Add(totalProveedor);
            

            conexion.Open();

            cmd.ExecuteNonQuery();

            proveedor.totalProveedor1 = Convert.ToInt32(cmd.Parameters["@totalProveedores"].Value);
            
            conexion.Close();

        }



    }
}
