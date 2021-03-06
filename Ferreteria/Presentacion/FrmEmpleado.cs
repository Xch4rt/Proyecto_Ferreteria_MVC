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
        public int id;
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        public FrmEmpleado(int ide)
        {
            InitializeComponent();
            this.id = ide;
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
                    Close();


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
                    eEmpleado.IdEmpleado1 = id;
                    eEmpleado.PNombre1 = NombreC[0];
                    eEmpleado.SNombre1 = NombreC[1];
                    eEmpleado.PApellido1 = NombreC[2];
                    eEmpleado.SApellido1 = NombreC[3];
                    eEmpleado.FechaContrato1 = fecha;
                    eEmpleado.Puesto1 = txtPuesto.Text;
                    eEmpleado.Salario1 = Convert.ToDecimal(txtSalario.Text);
                    nEmpleado.EditarEmpleado(eEmpleado);
                    MessageBox.Show("Se ha actualizado el empleado correctamente");

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

        private void txtIdEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }

        private void dateContratacion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel8_Click(object sender, EventArgs e)
        {

        }

        private void txtPuesto_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel6_Click(object sender, EventArgs e)
        {

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel7_Click(object sender, EventArgs e)
        {

        }
    }
}
