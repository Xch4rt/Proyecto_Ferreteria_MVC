using Entidades;
using Negocios;
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
    public partial class FrmCliente : Form
    {
        N_Cliente nCliente = new N_Cliente();
        E_Cliente eCliente = new E_Cliente();
        public Boolean Updates = false;
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void TopForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void ClosePic_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string Nombres = txtNombres.Text;
            string[] NombresC = Nombres.Split(' ');

            string Apellidos = txtApellidos.Text;
            string[] ApellidosC = Apellidos.Split(' ');


            if (!Updates)
            {
                try
                {
                    eCliente.PNombre1 = NombresC[0];
                    eCliente.SNombre1 = NombresC[1];
                    eCliente.PApellido1 = ApellidosC[0];
                    eCliente.SApellido1 = ApellidosC[1];
                    eCliente.NTelefono1 = Convert.ToInt32(txtTelefono.Text);
                    nCliente.InsertarCliente(eCliente);
                    MessageBox.Show("El cliente " + NombresC[0] + " " + ApellidosC[0] + " se ha guardado exitosamente ");
                    txtNombres.Clear();
                    txtApellidos.Clear();
                    txtTelefono.Clear();


                }
                catch (Exception ex)
                {

                }
            }
            if (Updates)
            {
                try
                {
                    eCliente.PNombre1 = NombresC[0];
                    eCliente.SNombre1 = NombresC[1];
                    eCliente.PApellido1 = ApellidosC[0];
                    eCliente.SApellido1 = ApellidosC[1];
                    eCliente.NTelefono1 = Convert.ToInt32(txtTelefono.Text);

                    nCliente.EditarCliente(eCliente);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha actualizado correctamente");
                }
            }
        }
    }
}
