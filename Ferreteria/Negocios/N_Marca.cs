using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidades;
namespace Negocios
{
    public class N_Marca
    {
        D_Marcas objDato = new D_Marcas();

        public List<E_Marcas> ListarMarcas(string buscar)
        {
            return objDato.ListarMarcas(buscar);
        }

        public void InsertarMarca(E_Marcas Marca)
        {
            objDato.insertarMarcas(Marca);
        }
        
        public void EditarMarcas(E_Marcas Marca)
        {
            objDato.EditarMarcas(Marca);
        }

        public void EliminarMarcas(E_Marcas Marca)
        {
            objDato.EliminarMarcas(Marca);
        }
    }
}
