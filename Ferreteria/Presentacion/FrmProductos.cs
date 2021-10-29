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
            ShowTotal();
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
        // metodo para buscar productos
        public void BuscarProductos(string search)
        {
            N_Productos nProducto = new N_Productos();
            dgvProductos.DataSource = nProducto.BuscarProductos(search);
        }

        
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            BuscarProductos(txtSearch.Text);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            FrmProducto frmProd = new FrmProducto();
            frmProd.ShowDialog();
            frmProd.Update = false;
            MostrarDatos(); // para que se refresque
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.Rows[e.RowIndex].Cells["ELIMINAR"].Selected)
            {
                int indexDel = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells[2].Value.ToString());
                objNegocio.EliminarProducto(indexDel);

                MostrarDatos();
                ShowTotal();
            }
            else if (dgvProductos.Rows[e.RowIndex].Cells["EDITAR"].Selected)
            {
                FrmProducto frmP = new FrmProducto();
                frmP.Update = true;

                // procedemos a cargar el formulario del FrmProducto
                frmP.txtId.Text = dgvProductos.Rows[e.RowIndex].Cells["ID PRODUCTO"].Value.ToString();
                frmP.txtCod.Text = dgvProductos.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
                frmP.txtNombreProducto.Text = dgvProductos.Rows[e.RowIndex].Cells["PRODUCTO"].Value.ToString();
                frmP.txtPrecioCompra.Text = dgvProductos.Rows[e.RowIndex].Cells["PRECIO COMPRA"].Value.ToString();
                frmP.txtPrecioVenta.Text = dgvProductos.Rows[e.RowIndex].Cells["PRECIO VENTA"].Value.ToString();
                frmP.txtStock.Text = dgvProductos.Rows[e.RowIndex].Cells["STOCK"].Value.ToString();
                frmP.cmbBrand.Text = dgvProductos.Rows[e.RowIndex].Cells["CATEGORIA"].Value.ToString();
                frmP.cmbCategory.Text = dgvProductos.Rows[e.RowIndex].Cells["MARCA"].Value.ToString();

                frmP.ShowDialog();
                MostrarDatos();
                ShowTotal();
            }
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FrmCategoria frmC = new FrmCategoria();
            frmC.ShowDialog();
            ShowTotal();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            FrmMarcas frmM = new FrmMarcas();
            frmM.ShowDialog();
            ShowTotal();
        }
        public void ShowTotal()
        {
            E_Productos ePro = new E_Productos();
            N_Productos nPro = new N_Productos();

            nPro.ShowingTotales(ePro);
            lblCategorias.Text = ePro.TotalCategorias;
            lblMarcas.Text = ePro.TotalMarcas;
            lblProd.Text = ePro.TotalProductos;
            lblTotales.Text = ePro.TotalStock;
        }
    }
}
