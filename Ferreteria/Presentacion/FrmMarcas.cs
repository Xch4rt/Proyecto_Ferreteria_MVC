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
    public partial class FrmMarcas : Form
    {
        private string IdCategoria;
        private bool Editarse = false;

        E_Marcas objEntidad = new E_Marcas();
        N_Marca objNegocio = new N_Marca();
        public FrmMarcas()
        {
            InitializeComponent();
        }

        private void ClosePic_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            MostrarBuscarTable("");
            accionesTabla();
        }

        public void MostrarBuscarTable(string buscar)
        {
            N_Marca objNegocio = new N_Marca();
            tablaMarca.DataSource = objNegocio.ListarMarcas(buscar);
        }

        public void accionesTabla()
        {
            tablaMarca.Columns[0].Visible = false;
            tablaMarca.Columns[1].Width = 60;
            tablaMarca.Columns[2].Width = 170;

            tablaMarca.ClearSelection();
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

        // BUTTONS ACTIONS
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCajas();

            txtNombre.Focus();
            Editarse = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tablaMarca.SelectedRows.Count > 0)
            {
                Editarse = true;
                IdCategoria = tablaMarca.CurrentRow.Cells[0].Value.ToString();
                txtCod.Text = tablaMarca.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = tablaMarca.CurrentRow.Cells[2].Value.ToString();
                txtDescription.Text = tablaMarca.CurrentRow.Cells[3].Value.ToString();
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
                    objEntidad.NombreMarca1 = txtNombre.Text.ToUpper();
                    objEntidad.DescripcionMarca1 = txtDescription.Text.ToUpper();


                    objNegocio.InsertarMarca(objEntidad);

                    //MessageBox.Show("Se ha guardado el registro!");
                    FrmSuccess.showFormAlert("Se ha guardado exitosamente!", FrmSuccess.AlertType.success);
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
                    objEntidad.IdMarca1 = Convert.ToInt32(IdCategoria);
                    objEntidad.NombreMarca1 = txtNombre.Text.ToUpper();
                    objEntidad.DescripcionMarca1 = txtDescription.Text.ToUpper();


                    objNegocio.EditarMarcas(objEntidad);

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
            if (tablaMarca.SelectedRows.Count > 0)
            {
                objEntidad.IdMarca1 = Convert.ToInt32(tablaMarca.CurrentRow.Cells[0].Value.ToString());
                objNegocio.EliminarMarcas(objEntidad);

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
