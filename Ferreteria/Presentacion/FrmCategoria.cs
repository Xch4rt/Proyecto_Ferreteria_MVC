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
    public partial class FrmCategoria : Form
    {
        private string IdCategoria;
        private bool Editarse = false;

        E_Categorias objEntidad = new E_Categorias();
        N_Categoria objNegocio = new N_Categoria();
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClosePic_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            MostrarBuscarTable("");
            accionesTabla();
        }

        public void MostrarBuscarTable(string buscar)
        {
            N_Categoria objNegocio = new N_Categoria();
            tablaCategoria.DataSource = objNegocio.listandoCategoria(buscar);
        }

        public void accionesTabla()
        {
            tablaCategoria.Columns[0].Visible = false;
            tablaCategoria.Columns[1].Width = 60;
            tablaCategoria.Columns[2].Width = 170;

            tablaCategoria.ClearSelection();
        }

        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            MostrarBuscarTable(txtSearch.Text);
        }
        private void LimpiarCajas()
        {
            txtCod.Text = "";
            txtNombre.Text = "";
            txtDescription.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCajas();

            txtNombre.Focus();
            Editarse = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tablaCategoria.SelectedRows.Count > 0)
            {
                Editarse = true;
                IdCategoria = tablaCategoria.CurrentRow.Cells[0].Value.ToString();
                txtCod.Text = tablaCategoria.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = tablaCategoria.CurrentRow.Cells[2].Value.ToString();
                txtDescription.Text = tablaCategoria.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione fila que desea editar");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Editarse)
            {
                try
                {
                    objEntidad.NombreCategoria1 = txtNombre.Text.ToUpper();
                    objEntidad.DescripcionCategoria1 = txtDescription.Text.ToUpper();


                    objNegocio.insertandoCategoria(objEntidad);

                    MessageBox.Show("Se ha guardado el registro!");
                    MostrarBuscarTable("");
                    Editarse = false;
                    LimpiarCajas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error: " + ex);
                }
            }
            else
            {
                try
                {
                    objEntidad.IdCategoria1 = Convert.ToInt32(IdCategoria);
                    objEntidad.NombreCategoria1 = txtNombre.Text.ToUpper();
                    objEntidad.DescripcionCategoria1 = txtDescription.Text.ToUpper();


                    objNegocio.editandoCategoria(objEntidad);

                    MessageBox.Show("Se ha editado el registro!");
                    Editarse = false;
                    LimpiarCajas();
                    MostrarBuscarTable("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error: " + ex);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tablaCategoria.SelectedRows.Count > 0)
            {
                objEntidad.IdCategoria1 = Convert.ToInt32(tablaCategoria.CurrentRow.Cells[0].Value.ToString());
                objNegocio.eliminandoCategoria(objEntidad);

                MessageBox.Show("Se ha eliminado correctamente");
                MostrarBuscarTable("");

            }
            else
            {
                MessageBox.Show("Seleccione la fila a eliminar!");
            }
        }
    }
}
