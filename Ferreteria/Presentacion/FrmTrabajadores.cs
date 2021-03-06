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
            ShowTotal();
            HidenMoveColumns();
        }
        public void MostrarDatos()
        {
            N_Empleado objEmpleado = new N_Empleado();
            dgvTrabajadores.DataSource = objEmpleado.ListarEmpleados();
        }

        public void HidenMoveColumns()
        {
            //modificando los widths
            dgvTrabajadores.Columns[1].Width = 50;
            dgvTrabajadores.Columns[0].Width = 50;
            dgvTrabajadores.Columns[4].Width = 70;
            dgvTrabajadores.Columns[3].Width = 60;
            //dgvEmpleados.Columns[11].Width = 80;
            dgvTrabajadores.Columns[9].Width = 100;

            dgvTrabajadores.Columns[2].Visible = false;
            // cambiando de posicion las primeras 2 columnas a ser las ultimas 2
            dgvTrabajadores.Columns[0].DisplayIndex = 11;
            dgvTrabajadores.Columns[1].DisplayIndex = 11;
        }

        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            BuscarEmpleado(txtSearch.Text);
        }
        public void BuscarEmpleado(string search)
        {
            N_Empleado nEmpleado = new N_Empleado();
            dgvTrabajadores.DataSource = nEmpleado.BuscarEmpleado(search);
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            FrmEmpleado frmEmpleado = new FrmEmpleado();
            frmEmpleado.ShowDialog();
            frmEmpleado.Updates = false;
            MostrarDatos(); // para que se refresque
            ShowTotal();
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTrabajadores.Rows[e.RowIndex].Cells["ELIMINAR"].Selected)
            {
                int indexDel = Convert.ToInt32(dgvTrabajadores.Rows[e.RowIndex].Cells[2].Value.ToString());
                objEmpleado.EliminarEmpleado(indexDel);

                MostrarDatos();
                ShowTotal();



            }
            else if (dgvTrabajadores.Rows[e.RowIndex].Cells["EDITAR"].Selected)
            {
                int indexUpdt = Convert.ToInt32(dgvTrabajadores.Rows[e.RowIndex].Cells[2].Value.ToString());
                
                FrmEmpleado frmE = new FrmEmpleado(indexUpdt);
                frmE.Updates = true;

                // procedemos a cargar el formulario del FrmProducto
                
                frmE.txtNombre.Text = dgvTrabajadores.Rows[e.RowIndex].Cells["PRIMER NOMBRE"].Value.ToString() + " " + dgvTrabajadores.Rows[e.RowIndex].Cells["SEGUNDO NOMBRE"].Value.ToString()+" "+ dgvTrabajadores.Rows[e.RowIndex].Cells["PRIMER APELLIDO"].Value.ToString()+" "+ dgvTrabajadores.Rows[e.RowIndex].Cells["SEGUNDO APELLIDO"].Value.ToString();
                frmE.dateContratacion.Value = Convert.ToDateTime(dgvTrabajadores.Rows[e.RowIndex].Cells["FECHA CONTRATO"].Value.ToString());
                frmE.txtPuesto.Text = dgvTrabajadores.Rows[e.RowIndex].Cells["PUESTO"].Value.ToString();
                frmE.txtSalario.Text = dgvTrabajadores.Rows[e.RowIndex].Cells["SALARIO"].Value.ToString();



                frmE.ShowDialog();
                MostrarDatos();
                ShowTotal();

            }
        }

        private void btnAsignarRol_Click(object sender, EventArgs e)
        {
            FrmRoles frmRol = new FrmRoles();
            frmRol.ShowDialog();
            MostrarDatos();
            ShowTotal();
        }
        public void ShowTotal()
        {
            E_Empleado eEmp = new E_Empleado();
            N_Empleado nEmp = new N_Empleado();

            nEmp.ShowingTotales(eEmp);
            lblTotalEmpleados.Text = eEmp.TotalEmpleado1.ToString();
  
        }
    }
}
