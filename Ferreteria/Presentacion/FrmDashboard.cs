using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Entidades;
using System.Collections;
using Entidades;
using Negocios;
namespace Presentacion
{
    public partial class FrmDashboard : Form
    {
        Bunifu.Dataviz.WinForms.BunifuDatavizBasic.DataPoint data;
        N_Graficas nGrafica = new N_Graficas();
        public FrmDashboard()
        {
            InitializeComponent();
            chartVentasEmpleados();
            chartCantidadInventario();
            ShowTotal();

        }
        private void chartVentasEmpleados()
        {
            DataTable dato;
            dato = nGrafica.GraficaLineal();

            ArrayList Cantidad = new ArrayList();
            ArrayList Nombres = new ArrayList();

            for (int i = 0; i < dato.Rows.Count; i++)
            {
                Nombres.Add(dato.Rows[i][1].ToString());
                Cantidad.Add(Convert.ToInt32(dato.Rows[i][0]));
            }

            VentasEmpleados.Series[0].Points.DataBindXY(Nombres, Cantidad);
        }
        private void chartCantidadInventario()
        {
            DataTable dato;
            dato = nGrafica.GraficaPastel();

            ArrayList Porcentajes = new ArrayList();
            ArrayList Nombre = new ArrayList();

            for (int i = 0; i < dato.Rows.Count; i++)
            {
                Porcentajes.Add(Convert.ToDecimal(dato.Rows[i][0]));
                Nombre.Add(dato.Rows[i][1].ToString());
            }

            chartPie.Series[0].Points.DataBindXY(Nombre, Porcentajes);
        }

        public void ShowTotal()
        {
            E_Grafica eGra = new E_Grafica();
            N_Graficas nGra = new N_Graficas();

            nGra.ShowingTotales(eGra);
            cantCategorias.Text = eGra.TotalCategorias;
            cantMarcas.Text = eGra.TotalMarcas;
            cantProductos.Text = eGra.TotalProductos;
            cantVentas.Text = eGra.TotalVentas;
            cantEmpleados.Text = eGra.TotalEmpleados;
            cantProveedores.Text = eGra.TotalProveedores;
            cantClientes.Text = eGra.TotalClientes;
        }
    }
}
