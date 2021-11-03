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
            HidenMoveColumns();
        }
        public void MostrarDatos()
        {
            N_Empleado objEmpleado = new N_Empleado();
            dgvEmpleados.DataSource = objEmpleado.ListarEmpleados();
        }
        public void ShowTotal()
        {
            E_Empleado eEmp = new E_Empleado();
            N_Empleado nEmp = new N_Empleado();
            /*
            nPro.ShowingTotales(ePro);
            lblCantidEmpl.Text = ePro.TotalCategorias;
            lblMarcas.Text = ePro.TotalMarcas;
            lblProd.Text = ePro.TotalProductos;
            lblTotales.Text = ePro.TotalStock;*/
        }
        public void HidenMoveColumns()
        {
            dgvEmpleados.Columns[2].Visible = false;


            //modificando los widths
            dgvEmpleados.Columns[1].Width = 70;
            dgvEmpleados.Columns[0].Width = 70;
            dgvEmpleados.Columns[3].Width = 70;
            dgvEmpleados.Columns[11].Width = 80;
            dgvEmpleados.Columns[9].Width = 100;

            // cambiando de posicion las primeras 2 columnas a ser las ultimas 2
            dgvEmpleados.Columns[0].DisplayIndex = 11;
            dgvEmpleados.Columns[1].DisplayIndex = 11;
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
