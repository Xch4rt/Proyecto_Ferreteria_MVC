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

        public FrmRoles()
        {
            InitializeComponent();
        }

        private void ClosePic_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
