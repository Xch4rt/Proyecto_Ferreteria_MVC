using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using Datos;
namespace Negocios
{
    public class N_Categoria
    {
        D_Categoria objData = new D_Categoria();

        public List<E_Categorias> listandoCategoria(string buscar)
        {
            return objData.ListarCategorias(buscar);
        }

        public void insertandoCategoria(E_Categorias Categoria)
        {
            objData.insertarCategoria(Categoria);
        }
        
        public void editandoCategoria(E_Categorias Categoria)
        {
            objData.EditarCategoria(Categoria);
        }

        public void eliminandoCategoria(E_Categorias Categoria)
        {
            objData.EliminarCategoria(Categoria);
        }
    }
}
