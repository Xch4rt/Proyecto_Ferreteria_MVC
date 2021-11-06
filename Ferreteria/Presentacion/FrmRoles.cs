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
    public partial class FrmRoles : Form
    {
        private string IdCategoria;
        private bool Updates = false;
        E_Usuarios eUsuarios = new E_Usuarios();
        N_Usuarios nUsuarios = new N_Usuarios();
        private string option = "Habilitado";
        public FrmRoles()
        {
            InitializeComponent(); 
            CmbRoles();
            MostrarBuscarTable("");
        }

        private void ClosePic_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void CmbRoles()
        {
            N_Rol nRol = new N_Rol();
            cmbRoles.DataSource = nRol.listandoRoles("");
            cmbRoles.ValueMember = "IdRol1";// aki
            cmbRoles.DisplayMember = "Rol1";
        }

        private void FrmRoles_Load(object sender, EventArgs e)
        {
            MostrarBuscarTable("");
            accionesTabla();
        }
        public void MostrarBuscarTable(string buscar)
        {
            N_Empleado nEmpleado = new N_Empleado();
            tablaEmpleadoRol.DataSource = nEmpleado.BuscarEmpleado(buscar);
        }
        public void accionesTabla()
        {
            tablaEmpleadoRol.Columns[0].Visible = false;
            tablaEmpleadoRol.Columns[6].Visible = false;
            tablaEmpleadoRol.Columns[8].Visible = false;
            tablaEmpleadoRol.Columns[10].Visible = false;

            // Widths personalizados
            tablaEmpleadoRol.Columns[1].Width = 55;
            tablaEmpleadoRol.Columns[2].Width = 70;
            tablaEmpleadoRol.Columns[3].Width = 70;
            tablaEmpleadoRol.Columns[4].Width = 70;
            tablaEmpleadoRol.Columns[5].Width = 70;
            tablaEmpleadoRol.Columns[9].Width = 55;
            tablaEmpleadoRol.ClearSelection();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            string[] nombreCompleto = new string[4];
            int j = 0;
            
            if (tablaEmpleadoRol.SelectedRows.Count > 0)
            {
                for (int i = 2; i < 6; i++)
                {
                    nombreCompleto[j] = tablaEmpleadoRol.CurrentRow.Cells[i].Value.ToString(); j++;
                }

                txtNombre.Text = String.Join(" ", nombreCompleto);


            }
            else
            {
                MessageBox.Show("Seleccione fila que desea editar");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Updates)
            {
                try
                {
                    eUsuarios.Username1 = txtUsername.Text;
                    eUsuarios.Password1 = txtPassword.Text;
                    eUsuarios.Estado1 = option;
                    eUsuarios.IdRol1 = cmbRoles.SelectedIndex + 1;
                    eUsuarios.IdEmpleado1 = Convert.ToInt32(tablaEmpleadoRol.CurrentRow.Cells[0].Value.ToString());
                    nUsuarios.CrearUsuario(eUsuarios);

                    MostrarBuscarTable("");
                    //Close();




                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar la categoria " + ex);
                }
            }
            if (Updates)
            {
                try
                {
                    /*eProducto.IdProducto1 = Convert.ToInt32(txtId.Text);
                    eProducto.Producto1 = txtNombreProducto.Text;
                    eProducto.PrecioCompra1 = Convert.ToDecimal(txtPrecioCompra.Text);
                    eProducto.PrecioVenta1 = Convert.ToDecimal(txtPrecioVenta.Text);
                    eProducto.Stock1 = Convert.ToInt32(txtStock.Text);
                    eProducto.IdCategoria1 = Convert.ToInt32(cmbCategory.SelectedValue);
                    eProducto.IdMarca1 = Convert.ToInt32(cmbBrand.SelectedValue);
                    */
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar la categoria " + ex);
                }
            }
        }

        private void ToggleOptionUser_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                option = "Habilitado";
            }
            else
            {
                option = "Deshabilitado";
            }
        }
    }
}
