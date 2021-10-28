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
    public partial class FrmProductos : Form
    {
        N_Productos objNegocio = new N_Productos();
        public FrmProductos()
        {
            InitializeComponent();
            MostrarDatos();
            HidenMoveColumns();
        }

        public void MostrarDatos()
        {
            N_Productos objNegocio = new N_Productos();
            dgvProductos.DataSource = objNegocio.ListarProductos();
            
        }
        // metodo para ocultar las foreing keys
        public void HidenMoveColumns()
        {
            dgvProductos.Columns[2].Visible = false;
            dgvProductos.Columns[5].Visible = false;
            dgvProductos.Columns[7].Visible = false;

            //modificando los widths
            dgvProductos.Columns[3].Width = 70;
            dgvProductos.Columns[4].Width = 200;

            // cambiando de posicion las primeras 2 columnas a ser las ultimas 2
            dgvProductos.Columns[0].DisplayIndex = 11;
            dgvProductos.Columns[1].DisplayIndex = 11;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
