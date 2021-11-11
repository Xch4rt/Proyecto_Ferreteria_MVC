using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocios;
using Entidades;
namespace Presentacion
{
    public partial class FrmTotalEmpleados : Form
    {
        public FrmTotalEmpleados()
        {
            InitializeComponent();
            MostrarDatos();
        }

        private void ClosePic_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void MostrarDatos()
        {
            N_Empleado objEmpleado = new N_Empleado();
            tablaEmpleado.DataSource = objEmpleado.ShowTotalEmployees();
        }
    }
}
