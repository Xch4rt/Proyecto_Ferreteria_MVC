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
    public partial class FrmEmpleado : Form
    {
        public bool Updates = false;
        E_Empleado eEmpleado = new E_Empleado();
        N_Empleado nEmpleado = new N_Empleado();
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            string[] NombreC = Nombre.Split(' ');
            DateTime fecha = dateContratacion.Value;
            // Para Guardar como date en sql
            

            //MessageBox.Show($"{NombreC[0]}", Fecha);
            if (!Updates)
            {
                try
                {
                    eEmpleado.PNombre1 = NombreC[0];
                    eEmpleado.SNombre1 = NombreC[1];
                    eEmpleado.PApellido1 = NombreC[2];
                    eEmpleado.SApellido1 = NombreC[3];
                    eEmpleado.FechaContrato1 = fecha;
                    eEmpleado.Salario1 = Convert.ToDecimal(txtSalario.Text);
                    eEmpleado.Puesto1 = txtPuesto.Text;
                    nEmpleado.InsertarEmpleado(eEmpleado);
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
                    eEmpleado.IdEmpleado1 = Convert.ToInt32(txtIdEmpleado.Text);
                    eEmpleado.PNombre1 = NombreC[0];
                    eEmpleado.SNombre1 = NombreC[1];
                    eEmpleado.PApellido1 = NombreC[2];
                    eEmpleado.SApellido1 = NombreC[3];
                    eEmpleado.FechaContrato1 = fecha;
                    eEmpleado.Puesto1 = txtPuesto.Text;
                    eEmpleado.Salario1 = Convert.ToDecimal(txtSalario.Text);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar la categoria " + ex);
                }
            }
        }
        private void ClosePic_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
