using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;
using Negocios;

namespace Presentacion
{
    public partial class FrmProducto : Form
    {
        public bool Update = false;
        E_Productos eProducto = new E_Productos();
        N_Productos nProducto = new N_Productos();
        public FrmProducto()
        {
            InitializeComponent();
            CmbCategorias();
            CmbMarcas();
        }

        // para rellenar los combobox
        public void CmbCategorias()
        {
            N_Categoria nCategorias = new N_Categoria();
            cmbCategory.DataSource = nCategorias.listandoCategoria("");
            cmbCategory.ValueMember = "IdCategoria1";// aki
            cmbCategory.DisplayMember = "NombreCategoria1";
        }
        public void CmbMarcas()
        {
            N_Marca nMarca = new N_Marca();
            cmbBrand.DataSource = nMarca.ListarMarcas("");
            cmbBrand.ValueMember = "IdMarca1";// aki
            cmbBrand.DisplayMember = "NombreMarca1";
        }

        private void ClosePic_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Update)
            {
                try
                {
                    eProducto.Producto1 = txtNombreProducto.Text;
                    eProducto.PrecioCompra1 = Convert.ToDecimal(txtPrecioCompra.Text);
                    eProducto.PrecioVenta1 = Convert.ToDecimal(txtPrecioVenta.Text);
                    eProducto.Stock1 = Convert.ToInt32(txtStock.Text);
                    eProducto.IdCategoria1 = Convert.ToInt32(cmbCategory.SelectedValue);
                    eProducto.IdMarca1 = Convert.ToInt32(cmbBrand.SelectedValue);

                    nProducto.CrearProducto(eProducto);
                    Close();


                } catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar la categoria " + ex);
                }
            }
            if (Update)
            {
                try
                {
                    eProducto.IdProducto1 = Convert.ToInt32(txtId.Text);
                    eProducto.Producto1 = txtNombreProducto.Text;
                    eProducto.PrecioCompra1 = Convert.ToDecimal(txtPrecioCompra.Text);
                    eProducto.PrecioVenta1 = Convert.ToDecimal(txtPrecioVenta.Text);
                    eProducto.Stock1 = Convert.ToInt32(txtStock.Text);
                    eProducto.IdCategoria1 = Convert.ToInt32(cmbCategory.SelectedValue);
                    eProducto.IdMarca1 = Convert.ToInt32(cmbBrand.SelectedValue);

                } catch(Exception ex)
                {
                    MessageBox.Show("No se pudo guardar la categoria " + ex);
                }
            }
        }
    }
}
