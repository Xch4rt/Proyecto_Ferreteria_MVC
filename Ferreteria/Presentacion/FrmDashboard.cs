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
    public partial class FrmDashboard : Form
    {
        Bunifu.Dataviz.WinForms.BunifuDatavizBasic.DataPoint data;
        N_Graficas nGrafica = new N_Graficas();
        public FrmDashboard()
        {
            InitializeComponent();
            chartwlabel2();
            chartwlabel1();
            chartwlabel3();
        }
        private void chartwlabel2() // linear
        {
            data = new Bunifu.Dataviz.WinForms.BunifuDatavizBasic.DataPoint(Bunifu.Dataviz.WinForms.BunifuDatavizBasic._type.Bunifu_line);
            Bunifu.Dataviz.WinForms.BunifuDatavizBasic.Canvas canvas = new Bunifu.Dataviz.WinForms.BunifuDatavizBasic.Canvas();

            DataTable dato;
            dato = nGrafica.GraficaLineal();

            string[] productos = new string[dato.Rows.Count]; //{ "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            int[] cantidades = new int[dato.Rows.Count];//{
            for (int j = 0; j < dato.Rows.Count; j++)
            {
                productos[j] = dato.Rows[j][1].ToString();
                cantidades[j] = Convert.ToInt32(dato.Rows[j][0]);
            }
            for (int i = 0; i < dato.Rows.Count; i++)
            {
                data.addLabely(productos[i], cantidades[i].ToString());
            }
            canvas.addData(data);
            bunifuDatavizBasic1.Render(canvas);
        }
        private void chartwlabel1()
        {
            data = new Bunifu.Dataviz.WinForms.BunifuDatavizBasic.DataPoint(Bunifu.Dataviz.WinForms.BunifuDatavizBasic._type.Bunifu_pie);
            Bunifu.Dataviz.WinForms.BunifuDatavizBasic.Canvas canvas = new Bunifu.Dataviz.WinForms.BunifuDatavizBasic.Canvas();
            
            DataTable dato;
            dato = nGrafica.GraficaPastel();

            string[] productos = new string[dato.Rows.Count]; //{ "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            int[] cantidades = new int[dato.Rows.Count];//{ 1, 2, 3, 4, 5, 6, 7 };

            for (int j = 0; j < dato.Rows.Count; j++)
            {
                productos[j] = dato.Rows[j][1].ToString();
                cantidades[j] = Convert.ToInt32(dato.Rows[j][0]);
            }
            for (int i = 0; i < dato.Rows.Count; i++)
            {
                data.addLabely(productos[i], cantidades[i].ToString());
            }

            canvas.addData(data);
            bunifuDatavizBasic2.Render(canvas);
        }
        private void chartwlabel3()
        {
            DataTable dato;
            dato = nGrafica.GraficaBarra();

            data = new Bunifu.Dataviz.WinForms.BunifuDatavizBasic.DataPoint(Bunifu.Dataviz.WinForms.BunifuDatavizBasic._type.Bunifu_column);
            Bunifu.Dataviz.WinForms.BunifuDatavizBasic.Canvas canvas = new Bunifu.Dataviz.WinForms.BunifuDatavizBasic.Canvas();
            
            string[] productos = new string[dato.Rows.Count]; //{ "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            int[] cantidades = new int[dato.Rows.Count];//{ 1, 2, 3, 4, 5, 6, 7 };

            for (int j = 0; j < dato.Rows.Count; j++)
            {
                productos[j] = dato.Rows[j][1].ToString();
                cantidades[j] = Convert.ToInt32(dato.Rows[j][0]);
            }

            for (int i = 0; i < dato.Rows.Count; i++)
            {
                data.addLabely(productos[i], cantidades[i].ToString());
            }
            
            /*
            data.addLabely("MON", random.Next(0, 50).ToString());
            data.addLabely("TUE", random.Next(0, 50).ToString());
            data.addLabely("WED", random.Next(0, 50).ToString());
            data.addLabely("THU", random.Next(0, 50).ToString());
            data.addLabely("FRI", random.Next(0, 50).ToString());
            data.addLabely("SAT", random.Next(0, 50).ToString());
            data.addLabely("SUN", random.Next(0, 50).ToString());
            */

            canvas.addData(data);
            bunifuDatavizBasic3.Render(canvas);
        }
    }
}
