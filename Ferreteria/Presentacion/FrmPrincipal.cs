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
namespace Presentacion
{
    public partial class FrmPrincipal : Form
    {
        E_Usuario eUsuario = new E_Usuario();
        string usernames;
        public int idEmpleado;
        string rol;
        public FrmPrincipal(string nombreUsuario, int idEmpleado, string rol)
        {
            InitializeComponent();
            this.usernames = nombreUsuario;
            this.idEmpleado = idEmpleado;
            this.rol = rol;
            SwitchRol(this.rol);
            userName.Text = nombreUsuario;
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
     
        public void SwitchRol(string roles)
        {
            switch(roles)
            {
                case "Jefe":
                    btnClientes.Enabled = true;
                    btnDashboard.Enabled = true;
                    btnVentas.Enabled = true;
                    btnCompras.Enabled = true;
                    btnTrabajadores.Enabled = true;
                    btnProveedores.Enabled = true;
                    btnProductos.Enabled = true; 
                    break;
                case "Administrador":
                    btnProveedores.Enabled = true;
                    btnTrabajadores.Enabled = true;
                    btnClientes.Enabled = true;
                    btnProductos.Enabled = true;
                    btnDashboard.Enabled = false;
                    btnVentas.Enabled = false;
                    btnCompras.Enabled = false;
                    break;
                case "Bodega":;
                    btnCompras.Enabled = true;
                    btnProveedores.Enabled = true;
                    btnProductos.Enabled = true;
                    btnDashboard.Enabled = false;
                    btnTrabajadores.Enabled = false;
                    btnClientes.Enabled = false;
                    btnVentas.Enabled = false;
                    break;
                case "Vendedor":
                    btnClientes.Enabled = true;
                    btnVentas.Enabled = true;
                    btnCompras.Enabled = false;
                    btnProveedores.Enabled = false;
                    btnProductos.Enabled = false;
                    btnDashboard.Enabled = false;
                    btnTrabajadores.Enabled = false;
                    break;
            }
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
            PanelName.Text = "DASHBOARD";
        }

        private void btnGanancias_Click(object sender, EventArgs e)
        {
            OpenFormWrapper(new FrmGanancias());
            PanelName.Text = "GANANCIAS";
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            OpenFormWrapper(new FrmVentas(usernames,idEmpleado));
            PanelName.Text = "VENTAS";
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            OpenFormWrapper(new FrmCompras());
            PanelName.Text = "COMPRAS";
        }

        private void btnTrabajadores_Click(object sender, EventArgs e)
        {
            OpenFormWrapper(new FrmTrabajadores());
            PanelName.Text = "TRABAJADORES";
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            OpenFormWrapper(new FrmClientes());
            PanelName.Text = "CLIENTES";
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            OpenFormWrapper(new FrmProveedores());
            PanelName.Text = "PROVEEDORES";
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            OpenFormWrapper(new FrmProductos());
            PanelName.Text = " PRODUCTOS";
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

        private void logout_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();

            this.Hide();

            frmLogin.Show();
        }
    }
}
