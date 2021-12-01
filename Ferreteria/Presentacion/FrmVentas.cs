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
        List<E_Ventas> DetalleVenta;
        decimal price;
        string nombreCliente="Inserte nombre de cliente";
        int idCliente;
        
 

        public FrmVentas()
        {
            InitializeComponent();
            MostrarDatos();
            HidenMoveColumns();
            LastOrderID();
           // FillTableFacturados();
           
        }

        public FrmVentas(string NombreUsuario)
        {
            InitializeComponent();
            MostrarDatos();
            HidenMoveColumns();
            LastOrderID();
            FillTableFacturados();
            lblNombre.Text = NombreUsuario;
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

            //nVen.LastOrderID(eVen);
            //lblIdOrden.Text = eVen.CodOrden1;
        }
        public void FillTableFacturados()
        {
            dgvFacturados.ColumnCount = 6;
            dgvFacturados.Columns[2].Name = "Codigo";
            dgvFacturados.Columns[3].Name = "Nombre";
            dgvFacturados.Columns[4].Name = "SubTotal";
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgvFacturados);
            fila.Cells[2].Value = "codigo";
            fila.Cells[3].Value = "nombre";
            fila.Cells[4].Value = "subtotal";

            dgvFacturados.Rows.Add(fila);

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmBuscarClientes frmBClientes = new FrmBuscarClientes();
            frmBClientes.ShowDialog();
            nombreCliente = frmBClientes.getNombreCliente();
            idCliente = frmBClientes.getIdCliente();
            lblCliente.Text = nombreCliente;
        }
        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            price = Convert.ToDecimal(dgvProductos.Rows[e.RowIndex].Cells[4].Value.ToString());
        }
        private void AddtoDgvFacturar()
        {
            DetalleVenta = new List<E_Ventas>();
            E_Ventas Prod_agregar = new E_Ventas() { // Es solo un ejemplo
                Precio1 = price,
                Cantidad1 = Convert.ToInt32(txtCantidad.ToString()),
                Descuento1 = Convert.ToDecimal(ddDiscount.SelectedValue.ToString()),
                Id_Orden1 = 1,
                Id_Producto1 = 1
            };
        }

        private void bunifuPanel3_Click(object sender, EventArgs e)
        {

        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            
        }
    }
}
