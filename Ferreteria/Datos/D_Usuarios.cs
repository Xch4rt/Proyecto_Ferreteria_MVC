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
    public class D_Usuarios
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public void CrearUsuario(E_Usuarios usuarios)
        {
            SqlCommand cmd = new SqlCommand("SP_InsertarUsuario", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            cmd.Parameters.AddWithValue("@usuario", usuarios.Username1);
            cmd.Parameters.AddWithValue("@contraseña", usuarios.Password1);
            cmd.Parameters.AddWithValue("@Estado", usuarios.Estado1);
            cmd.Parameters.AddWithValue("@IdEmpleado", usuarios.IdEmpleado1);
            cmd.Parameters.AddWithValue("@IdRol", usuarios.IdRol1);


            cmd.ExecuteNonQuery();
            conexion.Close();
        }

    }
}
