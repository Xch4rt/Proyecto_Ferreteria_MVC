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
    public class D_Categoria
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
    
        public List<E_Categorias> ListarCategorias(string buscar)
        {
            SqlDataReader leerFilas;
            SqlCommand cmd = new SqlCommand("SP_BuscarCategoria", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", buscar);

            leerFilas = cmd.ExecuteReader();

            List<E_Categorias> listar = new List<E_Categorias>();

            while (leerFilas.Read())
            {
                listar.Add(new E_Categorias
                {
                    IdCategoria1 = leerFilas.GetInt32(0),
                    CodigoCategoria1 = leerFilas.GetString(1),
                    NombreCategoria1 = leerFilas.GetString(2),
                    DescripcionCategoria1 = leerFilas.GetString(3)
                });

            }

            conexion.Close();
            leerFilas.Close();


            return listar;
        }

        public void insertarCategoria(E_Categorias Categoria)
        {
            SqlCommand cmd = new SqlCommand("SP_InsertarCategoria", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre", Categoria.NombreCategoria1);
            cmd.Parameters.AddWithValue("@Descripcion", Categoria.DescripcionCategoria1);


            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EditarCategoria(E_Categorias Categoria)
        {
            SqlCommand cmd = new SqlCommand("SP_EditarCategoria", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();


            cmd.Parameters.AddWithValue("@IdCategoria", Categoria.IdCategoria1);
            cmd.Parameters.AddWithValue("@Nombre", Categoria.NombreCategoria1);
            cmd.Parameters.AddWithValue("@Descripcion", Categoria.DescripcionCategoria1);


            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EliminarCategoria(E_Categorias Categoria)
        {
            SqlCommand cmd = new SqlCommand("SP_EliminarCategoria", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IdCategoria", Categoria.IdCategoria1);
            cmd.ExecuteNonQuery();

            conexion.Close();   
        }
    }
}
