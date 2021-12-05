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
            

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmBtnDashboard frmDash = new FrmBtnDashboard();
            frmDash.ShowDialog();
        }
    }
}
