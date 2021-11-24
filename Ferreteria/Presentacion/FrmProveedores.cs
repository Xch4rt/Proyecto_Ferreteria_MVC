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
namespace Presentacion
{
    public partial class FrmProveedores : Form
    {
        N_Proveedor objProveedor = new N_Proveedor();
        public FrmProveedores()
        {
            InitializeComponent();
            MostrarDatos();
            //HidenMoveColumns();
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
            dgvProveedores.Columns[3].Width = 70;
            dgvProveedores.Columns[2].Width = 60;
            //dgvEmpleados.Columns[11].Width = 80;
            //dgvClientes.Columns[9].Width = 100;

            // cambiando de posicion las primeras 2 columnas a ser las ultimas 2
            dgvProveedores.Columns[0].DisplayIndex = 8;
            dgvProveedores.Columns[1].DisplayIndex = 8;
            dgvProveedores.Columns[2].Visible = false;
        }
        public void BuscarProveedor(string search)
        {
            N_Proveedor objProveedor = new N_Proveedor();
            dgvProveedores.DataSource = objProveedor.BuscarProveedores(search);
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente(); // FrmProveedor frmProveedor = new FrmProveedor();
            frmCliente.ShowDialog(); // frmProveedor.ShowDialog();
            frmCliente.Updates = false;
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
                FrmCliente frmC = new FrmCliente();
                frmC.Updates = true;

                // procedemos a cargar el formulario del FrmProducto
                frmC.txtNombres.Text = dgvProveedores.Rows[e.RowIndex].Cells["PRIMER NOMBRE"].Value.ToString() + " " + dgvProveedores.Rows[e.RowIndex].Cells["SEGUNDO NOMBRE"].Value.ToString();
                frmC.txtApellidos.Text = dgvProveedores.Rows[e.RowIndex].Cells["PRIMER APELLIDO"].Value.ToString() + " " + dgvProveedores.Rows[e.RowIndex].Cells["SEGUNDO APELLIDO"].Value.ToString();
                frmC.txtTelefono.Text = dgvProveedores.Rows[e.RowIndex].Cells["NUMERO DE TELEFONO"].Value.ToString();


                frmC.ShowDialog();
                MostrarDatos();

            }
        }

        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            BuscarProveedor(txtSearch.Text);
        }
    }
}
