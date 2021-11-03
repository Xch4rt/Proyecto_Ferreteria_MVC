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
    public partial class FrmTrabajadores : Form
    {
        N_Empleado objEmpleado = new N_Empleado();
        public FrmTrabajadores()
        {
            InitializeComponent();
            MostrarDatos();
        }
        public void MostrarDatos()
        {
            N_Empleado objEmpleado = new N_Empleado();
            dgvEmpleados.DataSource = objEmpleado.ListarEmpleados();
        }

        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            BuscarEmpleado(txtSearch.Text);
        }
        public void BuscarEmpleado(string search)
        {
            N_Empleado nEmpleado = new N_Empleado();
            dgvEmpleados.DataSource = nEmpleado.BuscarEmpleado(search);
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            FrmEmpleado frmEmpleado = new FrmEmpleado();
            frmEmpleado.ShowDialog();
            //frmProd.Updates = false;
            MostrarDatos(); // para que se refresque
            //ShowTotal();
        }
    }
}
