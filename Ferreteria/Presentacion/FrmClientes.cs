
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmClientes : Form
    {
        N_Cliente objCliente = new N_Cliente();
        public FrmClientes()
        {
            InitializeComponent();
            MostrarDatos();
            HidenMoveColumns();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        public void HidenMoveColumns()
        {
            //modificando los widths
            dgvClientes.Columns[1].Width = 50;
            dgvClientes.Columns[0].Width = 50;
            dgvClientes.Columns[3].Width = 70;
            dgvClientes.Columns[2].Width = 60;
            //dgvEmpleados.Columns[11].Width = 80;
            //dgvClientes.Columns[9].Width = 100;

            // cambiando de posicion las primeras 2 columnas a ser las ultimas 2
            dgvClientes.Columns[0].DisplayIndex = 8;
            dgvClientes.Columns[1].DisplayIndex = 8;
            dgvClientes.Columns[2].Visible = false;
        }

        public void MostrarDatos()
        {
            N_Cliente objCliente = new N_Cliente();
            dgvClientes.DataSource = objCliente.ListarClientes();
        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {
            BuscarCliente(txtSearch.Text);
        }

        public void BuscarCliente(string search)
        {
            N_Cliente nCliente = new N_Cliente();
            dgvClientes.DataSource = nCliente.BuscarCliente(search);
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.ShowDialog();
            frmCliente.Updates = false;
            MostrarDatos(); // para que se refresque

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.Rows[e.RowIndex].Cells["ELIMINAR"].Selected)
            {
                int indexDel = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells[2].Value.ToString());
                objCliente.EliminarCliente(indexDel);

                MostrarDatos();
                

               
            }
            else if (dgvClientes.Rows[e.RowIndex].Cells["EDITAR"].Selected)
            {
                FrmCliente frmC = new FrmCliente();
                frmC.Updates = true;

                // procedemos a cargar el formulario del FrmProducto
                frmC.txtNombres.Text = dgvClientes.Rows[e.RowIndex].Cells["PRIMER NOMBRE"].Value.ToString() + " " + dgvClientes.Rows[e.RowIndex].Cells["SEGUNDO NOMBRE"].Value.ToString();
                frmC.txtApellidos.Text = dgvClientes.Rows[e.RowIndex].Cells["PRIMER APELLIDO"].Value.ToString() + " " + dgvClientes.Rows[e.RowIndex].Cells["SEGUNDO APELLIDO"].Value.ToString();
                frmC.txtTelefono.Text = dgvClientes.Rows[e.RowIndex].Cells["NUMERO DE TELEFONO"].Value.ToString();


                frmC.ShowDialog();
                MostrarDatos();
                
            }
        }
    }
}
