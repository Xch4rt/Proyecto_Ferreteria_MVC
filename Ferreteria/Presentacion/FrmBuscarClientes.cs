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
        public FrmBuscarClientes()
        {
            InitializeComponent();
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
        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            BuscarCliente(txtSearch.Text);
        }
    }
}
