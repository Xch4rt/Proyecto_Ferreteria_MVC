using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocios;
using Entidades;

namespace Presentacion
{
    public partial class FrmLogin : Form
    {
        public string usernames;
        N_Usuario nUsuario = new N_Usuario();
        E_Usuario eUsuario = new E_Usuario();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void bunifuPictureBox2_Click(object sender, EventArgs e)
        {

        }



        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAcces_Click(object sender, EventArgs e)
        {
            DataTable dato;
            dato = nUsuario.Validar_acceso(this.txtUsername.Text, this.txtPassword.Text);


            if (dato != null)
            {
                if (dato.Rows.Count > 0)
                {
                    if (dato.Rows[0][0].ToString() == "Acceso Exitoso")
                    {
                        usernames = dato.Rows[0][1].ToString();
                       
                        MessageBox.Show("Bienvenido al Sistema "+ usernames, "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmPrincipal frmPrincipal = new FrmPrincipal(usernames);
                        this.Hide();
                        frmPrincipal.Show();


                    }
                    else
                    {
                        MessageBox.Show("Acceso Denegado al Sistema de Reservaciones", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            else
            {
                MessageBox.Show("No hay conexión al servidor " + (dato == null).ToString(), "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

