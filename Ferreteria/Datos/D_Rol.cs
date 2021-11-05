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
    public class D_Rol
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public List<E_Rol> ListarRoles(string buscar)
        {
            SqlDataReader leerFilas;
            SqlCommand cmd = new SqlCommand("SP_BuscarRol", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", buscar);

            leerFilas = cmd.ExecuteReader();

            List<E_Rol> listar = new List<E_Rol>();

            while (leerFilas.Read())
            {
                listar.Add(new E_Rol
                {
                    IdRol1 = leerFilas.GetInt32(0),
                    Rol1 = leerFilas.GetString(1)
                });

            }

            conexion.Close();
            leerFilas.Close();


            return listar;
        }
    }
}
