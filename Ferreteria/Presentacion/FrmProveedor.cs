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
    public partial class FrmProveedor : Form
    {
        N_Proveedor nProveedor = new N_Proveedor();
        E_Proveedor eProveedor = new E_Proveedor();
        public Boolean Updates = false;
        public int id;
        public FrmProveedor()
        {
            InitializeComponent();
        }
        public FrmProveedor(int ide)
        {
            //InitializeComponent();
            this.id = ide;
        }

        private void ClosePic_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          


            if (!Updates)
            {
                try
                {
                    
                    eProveedor.NombreCompany1 = txtNombreEmpresa.Text;
                    eProveedor.Contacto1 = txtNombreContacto.Text;
                    eProveedor.Direccion1 = txtDireccionEmpresa.Text;
                    eProveedor.Telf1 = Convert.ToInt32(txtTelefonoEmpresa.Text);
                    nProveedor.InsertarProveedores(eProveedor);
                    MessageBox.Show("El proveedor " + txtNombreEmpresa.Text + " "  + " se ha guardado exitosamente ");
                    txtNombreEmpresa.Clear();
                    txtNombreContacto.Clear();
                    txtDireccionEmpresa.Clear();
                    txtTelefonoEmpresa.Clear();
                   

                }
                catch (Exception ex)
                {

                }
            }
            if (Updates)
            {
                try
                {
                    
                    eProveedor.IdProveedor1 = id;
                    eProveedor.NombreCompany1 = txtNombreEmpresa.Text;
                    eProveedor.Contacto1 = txtNombreContacto.Text;
                    eProveedor.Direccion1 = txtDireccionEmpresa.Text;
                    eProveedor.Telf1 = Convert.ToInt32(txtTelefonoEmpresa.Text);

                    nProveedor.EditarProveedores(eProveedor);
                    MessageBox.Show("Se ha actualizado correctamente");

                }
                catch (Exception ex)
                {
                   
                }
            }
        }
    }
}
