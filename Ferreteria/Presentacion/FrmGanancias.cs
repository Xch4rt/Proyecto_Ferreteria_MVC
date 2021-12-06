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
    public partial class FrmGanancias : Form
    {
        N_Proveedor objNegocio = new N_Proveedor();
        public int index = 0;
        public FrmGanancias()
        {
            InitializeComponent();
            MostrarDatos();
            HidenMoveColumns();
        }

        private void ClosePic_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void MostrarDatos()
        {
            N_Proveedor objNegocio = new N_Proveedor();
            dgvProveedores.DataSource = objNegocio.ListarProveedores();
        }
        public void HidenMoveColumns()
        {
            //modificando los widths
            dgvProveedores.Columns[1].Width = 30;
            dgvProveedores.Columns[2].Width = 60;
            dgvProveedores.Columns[3].Width = 40;
            dgvProveedores.Columns[4].Width = 50;
            dgvProveedores.Columns[5].Width = 60;
            //dgvProveedores.Columns[7].Width = 40;
            //dgvEmpleados.Columns[11].Width = 80;
            //dgvClientes.Columns[9].Width = 100;

            // cambiando de posicion las primeras 2 columnas a ser las ultimas 2
            //dgvProveedores.Columns[0].DisplayIndex = 7;
            //dgvProveedores.Columns[1].DisplayIndex = 7;
            //dgvProveedores.Columns[2].Visible = false;
            dgvProveedores.Columns[0].Visible = false;
        }
        public void BuscarProveedor(string search)
        {
            N_Proveedor objProveedor = new N_Proveedor();
            dgvProveedores.DataSource = objProveedor.BuscarProveedores(search);
        }
        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            BuscarProveedor(txtSearch.Text);
        }

        private void dgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var indexNo = dgvProveedores.Rows[e.RowIndex].Index.ToString();
            index = Convert.ToInt32(dgvProveedores.Rows[e.RowIndex].Cells[0].Value); //id proveedor

           // MessageBox.Show(index.ToString());
           
            Close();
        }
        public int getIdProveedor()
        {
            return index;
        }
    }
}
