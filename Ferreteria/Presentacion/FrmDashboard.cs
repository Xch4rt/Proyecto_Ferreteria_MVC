using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmDashboard : Form
    {
        Bunifu.Dataviz.WinForms.BunifuDatavizBasic.DataPoint data;
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
            Random random = new Random();

            data.addLabely("MON", random.Next(0, 50).ToString());
            data.addLabely("TUE", random.Next(0, 50).ToString());
            data.addLabely("WED", random.Next(0, 50).ToString());
            data.addLabely("THU", random.Next(0, 50).ToString());
            data.addLabely("FRI", random.Next(0, 50).ToString());
            data.addLabely("SAT", random.Next(0, 50).ToString());
            data.addLabely("SUN", random.Next(0, 50).ToString());


            canvas.addData(data);
            bunifuDatavizBasic1.Render(canvas);
        }
        private void chartwlabel1()
        {
            data = new Bunifu.Dataviz.WinForms.BunifuDatavizBasic.DataPoint(Bunifu.Dataviz.WinForms.BunifuDatavizBasic._type.Bunifu_pie);
            Bunifu.Dataviz.WinForms.BunifuDatavizBasic.Canvas canvas = new Bunifu.Dataviz.WinForms.BunifuDatavizBasic.Canvas();
            Random random = new Random();

            data.addLabely("MON", random.Next(0, 50).ToString());
            data.addLabely("TUE", random.Next(0, 50).ToString());
            data.addLabely("WED", random.Next(0, 50).ToString());
            data.addLabely("THU", random.Next(0, 50).ToString());
            data.addLabely("FRI", random.Next(0, 50).ToString());
            data.addLabely("SAT", random.Next(0, 50).ToString());
            data.addLabely("SUN", random.Next(0, 50).ToString());


            canvas.addData(data);
            bunifuDatavizBasic2.Render(canvas);
        }
        private void chartwlabel3()
        {
            data = new Bunifu.Dataviz.WinForms.BunifuDatavizBasic.DataPoint(Bunifu.Dataviz.WinForms.BunifuDatavizBasic._type.Bunifu_column);
            Bunifu.Dataviz.WinForms.BunifuDatavizBasic.Canvas canvas = new Bunifu.Dataviz.WinForms.BunifuDatavizBasic.Canvas();
            Random random = new Random();

            data.addLabely("MON", random.Next(0, 50).ToString());
            data.addLabely("TUE", random.Next(0, 50).ToString());
            data.addLabely("WED", random.Next(0, 50).ToString());
            data.addLabely("THU", random.Next(0, 50).ToString());
            data.addLabely("FRI", random.Next(0, 50).ToString());
            data.addLabely("SAT", random.Next(0, 50).ToString());
            data.addLabely("SUN", random.Next(0, 50).ToString());


            canvas.addData(data);
            bunifuDatavizBasic3.Render(canvas);
        }
    }
}
