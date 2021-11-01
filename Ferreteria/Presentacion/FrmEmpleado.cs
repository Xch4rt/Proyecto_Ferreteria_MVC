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
    public partial class FrmEmpleado : Form
    {
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
            var v = Convert.ToDateTime(dateContratacion.Text.Trim()).ToShortDateString();

            MessageBox.Show($"{NombreC[0]}", v);
        }

        private void ClosePic_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
