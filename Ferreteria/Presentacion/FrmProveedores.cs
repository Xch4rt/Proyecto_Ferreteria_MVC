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
    public partial class FrmProveedores : Form
    {
        N_Proveedor objProveedor = new N_Proveedor();
        public FrmProveedores()
        {
            InitializeComponent();
            MostrarDatos();
            HidenMoveColumns();
        }
        public void MostrarDatos()
        {
            N_Proveedor objProveedor = new N_Proveedor();
            dgvProveedores.DataSource = objProveedor.ListarProveedores();
        }
        public void HidenMoveColumns()
        {
            //modificando los widths
            dgvProveedores.Columns[1].Width = 50;
            dgvProveedores.Columns[0].Width = 50;
            dgvProveedores.Columns[3].Width = 40;
            dgvProveedores.Columns[4].Width = 50;
            dgvProveedores.Columns[5].Width = 60;
            dgvProveedores.Columns[7].Width = 40;
            //dgvEmpleados.Columns[11].Width = 80;
            //dgvClientes.Columns[9].Width = 100;

            // cambiando de posicion las primeras 2 columnas a ser las ultimas 2
            dgvProveedores.Columns[0].DisplayIndex = 7;
            dgvProveedores.Columns[1].DisplayIndex = 7;
            dgvProveedores.Columns[2].Visible = false;
            dgvProveedores.Columns[6].Visible = false;
        }
        public void BuscarProveedor(string search)
        {
            N_Proveedor objProveedor = new N_Proveedor();
            dgvProveedores.DataSource = objProveedor.BuscarProveedores(search);
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            FrmProveedor frmProveedor = new FrmProveedor();
            frmProveedor.ShowDialog();
            frmProveedor.Updates = false;
            MostrarDatos(); // para que se refresque
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProveedores.Rows[e.RowIndex].Cells["ELIMINAR"].Selected)
            {
                int indexDel = Convert.ToInt32(dgvProveedores.Rows[e.RowIndex].Cells[2].Value.ToString());
                objProveedor.EliminarProveedores(indexDel);

                MostrarDatos();



            }
            else if (dgvProveedores.Rows[e.RowIndex].Cells["EDITAR"].Selected)
            {
                int indexUpdt = Convert.ToInt32(dgvProveedores.Rows[e.RowIndex].Cells[2].Value.ToString());
                FrmProveedor frmP = new FrmProveedor(indexUpdt);
                frmP.Updates = true;

                // procedemos a cargar el formulario del FrmProducto
                frmP.txtNombreEmpresa.Text = dgvProveedores.Rows[e.RowIndex].Cells["NOMBRE COMPAÑIA"].Value.ToString();
                frmP.txtNombreContacto.Text = dgvProveedores.Rows[e.RowIndex].Cells["NOMBRE CONTACTO"].Value.ToString();
                frmP.txtDireccionEmpresa.Text = dgvProveedores.Rows[e.RowIndex].Cells["DIRECCION"].Value.ToString();
                frmP.txtTelefonoEmpresa.Text = dgvProveedores.Rows[e.RowIndex].Cells["TELEFONO"].Value.ToString();
                


                frmP.ShowDialog();
                MostrarDatos();

            }
        }

        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            BuscarProveedor(txtSearch.Text);
        }

        public void ShowTotal()
        {
            E_Proveedor ePro = new E_Proveedor();
            N_Proveedor nPro = new N_Proveedor();

            nPro.ShowingTotales(ePro);
            lblProd.Text = ePro.TotalProveedores1.ToString();

        }
    }
}
