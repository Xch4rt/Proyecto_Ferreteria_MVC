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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        // Metodo para que sea pantalla completa sin interrumpir la barra de tareas
        public void Screen_()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Screen_();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SideBar_Paint(object sender, PaintEventArgs e)
        {

        }
        

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // Instanciamos el metodo para abrir los forms
            OpenFormWrapper(new FrmDashboard());
        }

        private void btnGanancias_Click(object sender, EventArgs e)
        {
            OpenFormWrapper(new FrmGanancias());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            OpenFormWrapper(new FrmVentas());
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            OpenFormWrapper(new FrmCompras());
        }

        private void btnTrabajadores_Click(object sender, EventArgs e)
        {
            OpenFormWrapper(new FrmTrabajadores());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            OpenFormWrapper(new FrmClientes());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            OpenFormWrapper(new FrmProveedores());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            OpenFormWrapper(new FrmProductos());
        }

        private Form formActivate = null;

        private void OpenFormWrapper(Form FormChild)
        {
            if (formActivate != null)
                formActivate.Close();
            formActivate = FormChild;
            FormChild.TopLevel = false;

            FormChild.Dock = DockStyle.Fill;
            Wrapper.Controls.Add(FormChild);
            Wrapper.Tag = FormChild;
            FormChild.BringToFront();
            FormChild.Show();
        }
    }
}
