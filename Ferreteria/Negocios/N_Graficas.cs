using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using Entidades;
namespace Negocios
{
    public class N_Graficas
    {
        D_Graficas objDato = new D_Graficas();
        public DataTable GraficaBarra()
        {
            
            return objDato.GraficaBarra();
        }
        public DataTable GraficaPastel()
        {

            return objDato.GraficaPastel();
        }
        public DataTable GraficaLineal()
        {

            return objDato.GraficaLineal();
        }
    }
}
