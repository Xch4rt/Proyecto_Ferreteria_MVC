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
    public class D_Marcas
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Marcas> ListarMarcas(string buscar)
        {
            SqlDataReader leerFilas;
            SqlCommand cmd = new SqlCommand("SP_BuscarMarca", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", buscar);

            leerFilas = cmd.ExecuteReader();

            List<E_Marcas> listar = new List<E_Marcas>();

            while (leerFilas.Read())
            {
                listar.Add(new E_Marcas
                {
                    IdMarca1 = leerFilas.GetInt32(0),
                    CodigoMarca1 = leerFilas.GetString(1),
                    NombreMarca1 = leerFilas.GetString(2),
                    DescripcionMarca1 = leerFilas.GetString(3)
                });

            }

            conexion.Close();
            leerFilas.Close();


            return listar;
        }

        public void insertarMarcas(E_Marcas Marca)
        {
            SqlCommand cmd = new SqlCommand("SP_InsertarMarca", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre", Marca.NombreMarca1);
            cmd.Parameters.AddWithValue("@Descripcion", Marca.DescripcionMarca1);


            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EditarMarcas(E_Marcas Marca)
        {
            SqlCommand cmd = new SqlCommand("SP_EditarMarca", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();


            cmd.Parameters.AddWithValue("@IdCategoria", Marca.IdMarca1);
            cmd.Parameters.AddWithValue("@Nombre", Marca.NombreMarca1);
            cmd.Parameters.AddWithValue("@Descripcion", Marca.DescripcionMarca1);


            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EliminarMarcas(E_Marcas Marca)
        {
            SqlCommand cmd = new SqlCommand("SP_EliminarMarca", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IdCategoria", Marca.IdMarca1);
            cmd.ExecuteNonQuery();

            conexion.Close();
        }

    }
}
