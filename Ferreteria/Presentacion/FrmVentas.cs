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
        E_Ventas ventas = new E_Ventas();
        List<E_Ventas> DetalleVenta;
        decimal price;
        string nombreCliente="Inserte nombre de cliente";
        int idCliente;
        int idEmpleado;
        DateTime FechaCompra = DateTime.Now;
        public int cantidad;
        int[] idProductos = new int[100];
        int[] Vcantidad = new int[100];
        decimal[] Vsubtotales = new decimal[100];
        decimal[] VDescuentos = new decimal[100];
        decimal[] Vprice = new decimal[100];
        int LastOrder;
        decimal descuento = 0;
        decimal total = 0;
        int contador = 0;
        decimal subtotal = 0;
        decimal iva = 0;
        decimal iva_ = 0.15m;

       







        public FrmVentas()
        {
            InitializeComponent();
            MostrarDatos();
            HidenMoveColumns();
            LastOrderID();
            FillTableFacturados();
            // FillTableFacturados();

        }

        public FrmVentas(string NombreUsuario,int idEmpleado)
        {
            InitializeComponent();
            MostrarDatos();
            HidenMoveColumns();
            LastOrderID();
            FillTableFacturados();
            lblNombre.Text = NombreUsuario;
            lblFecha.Text = DateTime.Now.ToString();
            this.idEmpleado = idEmpleado;
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
            //fila.CreateCells(dgvFacturados);
            //fila.Cells[2].Value = "codigo";
            //fila.Cells[3].Value = "nombre";
            //fila.Cells[4].Value = "subtotal";

            dgvFacturados.Columns[0].DisplayIndex = 4;
            dgvFacturados.Columns[1].DisplayIndex = 4;


            //dgvFacturados.Rows.Add(fila);

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
        

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

            cantidad = Convert.ToInt32(txtCantidad.Text);

            switch (ddDiscount.SelectedIndex)
            {
                case 0: descuento = 0.05m; break;
                case 1: descuento = 0.15m; break;
                case 2: descuento = 0.25m;break;
                case 3: descuento = 0.30m; break;
                case 4: descuento = 0.50m; break;
                case 5: descuento = 0.75m;break;
            }

            int indexRow = dgvProductos.CurrentRow.Index;

            //dgvProductos.Rows[indexRow].Cells[0].Value.ToString();//id producto
            
            
               
                idProductos[contador]= Convert.ToInt32(dgvProductos.Rows[indexRow].Cells[0].Value.ToString());
            
                Vcantidad[contador] = cantidad;
            
                VDescuentos[contador] = descuento;

                Vsubtotales[contador]= (Convert.ToDecimal(dgvProductos.Rows[indexRow].Cells[8].Value.ToString()) * cantidad) * (1 - descuento);

                Vprice[contador] = Convert.ToDecimal(dgvProductos.Rows[indexRow].Cells[8].Value.ToString());
                contador++;


            subtotal = subtotal + ((Convert.ToDecimal(dgvProductos.Rows[indexRow].Cells[8].Value.ToString()) * cantidad)* (1-descuento));

            iva = (subtotal * iva_);


            total =(subtotal + iva);

            lblIva.Text = iva.ToString();
            lblTotal.Text = total.ToString();
           


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgvFacturados);
            fila.Cells[2].Value = dgvProductos.Rows[indexRow].Cells[1].Value.ToString(); 
            fila.Cells[3].Value = dgvProductos.Rows[indexRow].Cells[2].Value.ToString(); 
            fila.Cells[4].Value = (Convert.ToDecimal(dgvProductos.Rows[indexRow].Cells[8].Value.ToString()) * cantidad) * (1 - descuento);




            dgvFacturados.Rows.Add(fila);

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            DataTable dato;
            ventas.FechaCompra1 = this.FechaCompra;
            ventas.Id_Cliente1 = this.idCliente;
            ventas.Id_Empleado1 = this.idEmpleado;

            objNegocio.InsertarOrden(ventas);
            //decimal price = 0;
            dato = objNegocio.LastOrderID();
            if (dato!=null)
            {
                if (dato.Rows.Count > 0)
                {
                    LastOrder = Convert.ToInt32(dato.Rows[0][0]);
                }
                
            }
            else
            {
                LastOrder = 1;
                
            }

           



            for (int i = 0; i < dgvFacturados.Rows.Count; i++)
            {
                //price = Convert.ToDecimal((dgvProductos.Rows[i].Cells[8].Value));
                ventas.Precio1 = Vprice[i];
                ventas.Cantidad1 = Vcantidad[i];
                ventas.Descuento1 = VDescuentos[i];
                ventas.Id_Orden1 = LastOrder;
                ventas.Id_Producto1 = idProductos[i];
                objNegocio.InsertarDetalleOrden(ventas);
            }

            FrmReporteFactura frmReporteFactura = new FrmReporteFactura(LastOrder);
            frmReporteFactura.Show();
           

          




        }

        private void ddDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
