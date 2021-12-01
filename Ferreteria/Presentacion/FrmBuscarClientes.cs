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
    public partial class FrmBuscarClientes : Form
    {
        N_Cliente objCliente = new N_Cliente();
        public string[] fullname;
        public string NombreCliente;
        public int IdCliente;
     
        public FrmBuscarClientes()
        {
            InitializeComponent();
            MostrarDatos();
            HidenMoveColumns();
        }
        public void BuscarCliente(string search)
        {
            N_Cliente nCliente = new N_Cliente();
            dgvClientes.DataSource = nCliente.BuscarCliente(search);
        }
        public void MostrarDatos()
        {
            N_Cliente objCliente = new N_Cliente();
            dgvClientes.DataSource = objCliente.ListarClientes();
        }
        public void HidenMoveColumns()
        {
            //modificando los widths
            dgvClientes.Columns[1].Width = 45;
            dgvClientes.Columns[2].Width = 50;
            dgvClientes.Columns[3].Width = 50;
            dgvClientes.Columns[4].Width = 50;
            dgvClientes.Columns[5].Width = 50;
            dgvClientes.Columns[6].Width = 50;
            //dgvEmpleados.Columns[11].Width = 80;
            //dgvClientes.Columns[9].Width = 100;

            // cambiando de posicion las primeras 2 columnas a ser las ultimas 2

            dgvClientes.Columns[0].Visible = false;
        }
        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            BuscarCliente(txtSearch.Text);
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var indexNo = dgvClientes.Rows[e.RowIndex].Index.ToString();
            string[] fullname = { 
                    dgvClientes.Rows[e.RowIndex].Cells[2].Value.ToString(),//primer nombre
                    dgvClientes.Rows[e.RowIndex].Cells[3].Value.ToString(),//segundo nombre
                    dgvClientes.Rows[e.RowIndex].Cells[4].Value.ToString(),//primer apellido
                    dgvClientes.Rows[e.RowIndex].Cells[5].Value.ToString() //segundo apellido
            };
            NombreCliente = fullname[0] + " " + fullname[2];
            IdCliente = Int32.Parse(dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString());//id cliente
           
            
            Close();
            //MessageBox.Show(string.Join(" ",fullname));
        }

        public string getNombreCliente()
        {

            return NombreCliente;
        }

        public int getIdCliente()
        {

            return IdCliente;
        }

        private void ClosePic_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            //var indexNo = dgvClientes.Rows[e.RowIndex].Index.ToString();
            //string[] fullname = {
            //        dgvClientes.Rows[e.RowIndex].Cells[2].Value.ToString(),//primer nombre
            //        dgvClientes.Rows[e.RowIndex].Cells[3].Value.ToString(),//segundo nombre
            //        dgvClientes.Rows[e.RowIndex].Cells[4].Value.ToString(),//primer apellido
            //        dgvClientes.Rows[e.RowIndex].Cells[5].Value.ToString() //segundo apellido
            //};
            //NombreCliente = fullname[0] + " " + fullname[2];
            //IdCliente = Int32.Parse(dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString());//id cliente


            //Close();
            ////MessageBox.Show(string.Join(" ",fullname));
        }
    }
}
