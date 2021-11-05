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
        private bool Editarse = false;
        E_Rol objEntidad = new E_Rol();
        N_Rol objNegocio = new N_Rol();

        public FrmRoles()
        {
            InitializeComponent(); 
            CmbRoles();
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
            for(int i = 2; i<6;i++)
            {
                nombreCompleto[j] = tablaEmpleadoRol.CurrentRow.Cells[i].Value.ToString(); j++;
            }
            if (tablaEmpleadoRol.SelectedRows.Count > 0)
            {
                
                txtNombre.Text = String.Join(" ", nombreCompleto);


            }
            else
            {
                MessageBox.Show("Seleccione fila que desea editar");
            }
        }
    }
}
