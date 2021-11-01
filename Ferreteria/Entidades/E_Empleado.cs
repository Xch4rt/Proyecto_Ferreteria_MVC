using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Empleado
    {
        private int IdEmpleado;
        private string CodigoEmpleado;
        private string PNombre;
        private string SNombre;
        private string PApellido;
        private string SApellido;
        private DateTime FechaContrato;
        private decimal Salario;

        public int IdEmpleado1 { get => IdEmpleado; set => IdEmpleado = value; }
        public string CodigoEmpleado1 { get => CodigoEmpleado; set => CodigoEmpleado = value; }
        public string PNombre1 { get => PNombre; set => PNombre = value; }
        public string SNombre1 { get => SNombre; set => SNombre = value; }
        public string PApellido1 { get => PApellido; set => PApellido = value; }
        public string SApellido1 { get => SApellido; set => SApellido = value; }
        public DateTime FechaContrato1 { get => FechaContrato; set => FechaContrato = value; }
        public decimal Salario1 { get => Salario; set => Salario = value; }
    }
}
