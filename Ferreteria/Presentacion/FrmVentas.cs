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
    public partial class FrmVentas : Form
    {
        N_Ventas objNegocio = new N_Ventas();
        public FrmVentas()
        {
            InitializeComponent();
            MostrarDatos();
            HidenMoveColumns();
            LastOrderID();
        }

        public void HidenMoveColumns()
        {
            dgvProductos.Columns[0].Visible = false;
            dgvProductos.Columns[3].Visible = false;
            dgvProductos.Columns[5].Visible = false;
            dgvProductos.Columns[7].Visible = false;

            //modificando los widths
            dgvProductos.Columns[1].Width = 50; 
            dgvProductos.Columns[8].Width = 50;
            dgvProductos.Columns[9].Width = 50;

            dgvProductos.Columns[2].Width = 150;
            dgvProductos.Columns[4].Width = 150;
            dgvProductos.Columns[6].Width = 150;

        }

        public void MostrarDatos()
        {
            N_Ventas objNegocio = new N_Ventas();
            dgvProductos.DataSource = objNegocio.ListarProductos();

        }
        public void BuscarProductos(string search)
        {
            N_Ventas nVentas = new N_Ventas();
            dgvProductos.DataSource = nVentas.BuscarProductos(search);
        }

        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            BuscarProductos(txtSearch.Text);
        }
        public void LastOrderID()
        {
            E_Ventas eVen = new E_Ventas();
            N_Ventas nVen = new N_Ventas();

            nVen.LastOrderID(eVen);
            lblIdOrden.Text = eVen.CodOrden1;
        }
    }
}
