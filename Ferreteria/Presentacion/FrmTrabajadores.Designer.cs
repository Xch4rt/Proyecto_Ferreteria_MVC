
namespace Presentacion
{
    partial class FrmTrabajadores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrabajadores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlInfo = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlCantidadEmpleados = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlTotalProductosVendidos = new Bunifu.UI.WinForms.BunifuPanel();
            this.TopEmpleado = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuSeparator3 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblCategorias = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dgvEmpleados = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.EDITAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuSeparator6 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnNuevoEmpleado = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAsignarRol = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnExcel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.pnlCantidadEmpleados.SuspendLayout();
            this.pnlTotalProductosVendidos.SuspendLayout();
            this.TopEmpleado.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.bunifuPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pnlCantidadEmpleados);
            this.flowLayoutPanel1.Controls.Add(this.pnlTotalProductosVendidos);
            this.flowLayoutPanel1.Controls.Add(this.TopEmpleado);
            this.flowLayoutPanel1.Controls.Add(this.pnlInfo);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1044, 689);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlInfo.BackgroundImage")));
            this.pnlInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlInfo.BorderColor = System.Drawing.Color.Transparent;
            this.pnlInfo.BorderRadius = 3;
            this.pnlInfo.BorderThickness = 1;
            this.pnlInfo.Controls.Add(this.btnExcel);
            this.pnlInfo.Controls.Add(this.btnAsignarRol);
            this.pnlInfo.Controls.Add(this.btnNuevoEmpleado);
            this.pnlInfo.Controls.Add(this.txtSearch);
            this.pnlInfo.Controls.Add(this.bunifuSeparator6);
            this.pnlInfo.Controls.Add(this.pictureBox6);
            this.pnlInfo.Controls.Add(this.dgvEmpleados);
            this.pnlInfo.Location = new System.Drawing.Point(3, 141);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.ShowBorders = true;
            this.pnlInfo.Size = new System.Drawing.Size(1041, 580);
            this.pnlInfo.TabIndex = 1;
            // 
            // pnlCantidadEmpleados
            // 
            this.pnlCantidadEmpleados.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlCantidadEmpleados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCantidadEmpleados.BackgroundImage")));
            this.pnlCantidadEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCantidadEmpleados.BorderColor = System.Drawing.Color.Transparent;
            this.pnlCantidadEmpleados.BorderRadius = 3;
            this.pnlCantidadEmpleados.BorderThickness = 1;
            this.pnlCantidadEmpleados.Controls.Add(this.bunifuPanel1);
            this.pnlCantidadEmpleados.Location = new System.Drawing.Point(3, 3);
            this.pnlCantidadEmpleados.Name = "pnlCantidadEmpleados";
            this.pnlCantidadEmpleados.ShowBorders = true;
            this.pnlCantidadEmpleados.Size = new System.Drawing.Size(342, 132);
            this.pnlCantidadEmpleados.TabIndex = 1;
            // 
            // pnlTotalProductosVendidos
            // 
            this.pnlTotalProductosVendidos.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlTotalProductosVendidos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTotalProductosVendidos.BackgroundImage")));
            this.pnlTotalProductosVendidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTotalProductosVendidos.BorderColor = System.Drawing.Color.Transparent;
            this.pnlTotalProductosVendidos.BorderRadius = 3;
            this.pnlTotalProductosVendidos.BorderThickness = 1;
            this.pnlTotalProductosVendidos.Controls.Add(this.bunifuPanel2);
            this.pnlTotalProductosVendidos.Location = new System.Drawing.Point(351, 3);
            this.pnlTotalProductosVendidos.Name = "pnlTotalProductosVendidos";
            this.pnlTotalProductosVendidos.ShowBorders = true;
            this.pnlTotalProductosVendidos.Size = new System.Drawing.Size(342, 132);
            this.pnlTotalProductosVendidos.TabIndex = 0;
            // 
            // TopEmpleado
            // 
            this.TopEmpleado.BackgroundColor = System.Drawing.Color.Transparent;
            this.TopEmpleado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TopEmpleado.BackgroundImage")));
            this.TopEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TopEmpleado.BorderColor = System.Drawing.Color.Transparent;
            this.TopEmpleado.BorderRadius = 3;
            this.TopEmpleado.BorderThickness = 1;
            this.TopEmpleado.Controls.Add(this.bunifuPanel3);
            this.TopEmpleado.Location = new System.Drawing.Point(699, 3);
            this.TopEmpleado.Name = "TopEmpleado";
            this.TopEmpleado.ShowBorders = true;
            this.TopEmpleado.Size = new System.Drawing.Size(342, 132);
            this.TopEmpleado.TabIndex = 1;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.lblCategorias);
            this.bunifuPanel1.Controls.Add(this.bunifuLabel3);
            this.bunifuPanel1.Controls.Add(this.bunifuSeparator2);
            this.bunifuPanel1.Controls.Add(this.pictureBox1);
            this.bunifuPanel1.Location = new System.Drawing.Point(49, 9);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(290, 120);
            this.bunifuPanel1.TabIndex = 2;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.bunifuLabel4);
            this.bunifuPanel2.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel2.Controls.Add(this.bunifuSeparator1);
            this.bunifuPanel2.Controls.Add(this.pictureBox2);
            this.bunifuPanel2.Location = new System.Drawing.Point(49, 9);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(290, 120);
            this.bunifuPanel2.TabIndex = 3;
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BorderRadius = 3;
            this.bunifuPanel3.BorderThickness = 1;
            this.bunifuPanel3.Controls.Add(this.bunifuLabel5);
            this.bunifuPanel3.Controls.Add(this.bunifuLabel2);
            this.bunifuPanel3.Controls.Add(this.bunifuSeparator3);
            this.bunifuPanel3.Controls.Add(this.pictureBox3);
            this.bunifuPanel3.Location = new System.Drawing.Point(49, 9);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(290, 120);
            this.bunifuPanel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(14, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(16, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 60);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator2.BackgroundImage")));
            this.bunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(3, 69);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator2.Size = new System.Drawing.Size(284, 14);
            this.bunifuSeparator2.TabIndex = 2;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(6, 69);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(284, 14);
            this.bunifuSeparator1.TabIndex = 3;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator3.BackgroundImage")));
            this.bunifuSeparator3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator3.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator3.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(3, 69);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator3.Size = new System.Drawing.Size(284, 14);
            this.bunifuSeparator3.TabIndex = 3;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuLabel3.Location = new System.Drawing.Point(14, 89);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(185, 20);
            this.bunifuLabel3.TabIndex = 3;
            this.bunifuLabel3.Text = "CANTIDAD DE EMPLEADOS";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuLabel1.Location = new System.Drawing.Point(14, 89);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(263, 20);
            this.bunifuLabel1.TabIndex = 4;
            this.bunifuLabel1.Text = "CANTIDAD DE PRODUCTOS VENDIDOS";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuLabel2.Location = new System.Drawing.Point(16, 89);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(126, 20);
            this.bunifuLabel2.TabIndex = 4;
            this.bunifuLabel2.Text = "MEJOR EMPLEADO";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblCategorias
            // 
            this.lblCategorias.AllowParentOverrides = false;
            this.lblCategorias.AutoEllipsis = false;
            this.lblCategorias.AutoSize = false;
            this.lblCategorias.CursorType = null;
            this.lblCategorias.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.lblCategorias.Location = new System.Drawing.Point(208, 18);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCategorias.Size = new System.Drawing.Size(55, 45);
            this.lblCategorias.TabIndex = 8;
            this.lblCategorias.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblCategorias.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.AutoSize = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.bunifuLabel4.Location = new System.Drawing.Point(221, 18);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(55, 45);
            this.bunifuLabel4.TabIndex = 8;
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.AutoSize = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.bunifuLabel5.Location = new System.Drawing.Point(217, 18);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(55, 45);
            this.bunifuLabel5.TabIndex = 8;
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowCustomTheming = false;
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvEmpleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEmpleados.ColumnHeadersHeight = 40;
            this.dgvEmpleados.ColumnHeadersVisible = false;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EDITAR,
            this.ELIMINAR});
            this.dgvEmpleados.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvEmpleados.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvEmpleados.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEmpleados.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvEmpleados.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEmpleados.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvEmpleados.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvEmpleados.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvEmpleados.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvEmpleados.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEmpleados.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvEmpleados.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEmpleados.CurrentTheme.Name = null;
            this.dgvEmpleados.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmpleados.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvEmpleados.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEmpleados.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvEmpleados.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpleados.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEmpleados.EnableHeadersVisualStyles = false;
            this.dgvEmpleados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvEmpleados.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvEmpleados.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvEmpleados.HeaderForeColor = System.Drawing.Color.White;
            this.dgvEmpleados.Location = new System.Drawing.Point(24, 118);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEmpleados.RowHeadersVisible = false;
            this.dgvEmpleados.RowTemplate.Height = 40;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(993, 362);
            this.dgvEmpleados.TabIndex = 9;
            this.dgvEmpleados.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // EDITAR
            // 
            this.EDITAR.HeaderText = "EDITAR";
            this.EDITAR.Image = ((System.Drawing.Image)(resources.GetObject("EDITAR.Image")));
            this.EDITAR.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EDITAR.Name = "EDITAR";
            this.EDITAR.ReadOnly = true;
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.HeaderText = "ELIMINAR";
            this.ELIMINAR.Image = ((System.Drawing.Image)(resources.GetObject("ELIMINAR.Image")));
            this.ELIMINAR.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ELIMINAR.Name = "ELIMINAR";
            this.ELIMINAR.ReadOnly = true;
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = false;
            this.txtSearch.AcceptsTab = false;
            this.txtSearch.AnimationSpeed = 200;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.AutoSizeHeight = true;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSearch.BorderRadius = 1;
            this.txtSearch.BorderThickness = 1;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.Color.White;
            this.txtSearch.HideSelection = true;
            this.txtSearch.IconLeft = null;
            this.txtSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.IconPadding = 10;
            this.txtSearch.IconRight = null;
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(70, 12);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSearch.Modified = false;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnIdleState = stateProperties8;
            this.txtSearch.Padding = new System.Windows.Forms.Padding(3);
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearch.PlaceholderText = "Enter text";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(401, 39);
            this.txtSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TextMarginBottom = 0;
            this.txtSearch.TextMarginLeft = 3;
            this.txtSearch.TextMarginTop = 1;
            this.txtSearch.TextPlaceholder = "Enter text";
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.WordWrap = true;
            this.txtSearch.TextChange += new System.EventHandler(this.txtSearch_TextChange);
            // 
            // bunifuSeparator6
            // 
            this.bunifuSeparator6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator6.BackgroundImage")));
            this.bunifuSeparator6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator6.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator6.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator6.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator6.LineThickness = 1;
            this.bunifuSeparator6.Location = new System.Drawing.Point(65, 48);
            this.bunifuSeparator6.Name = "bunifuSeparator6";
            this.bunifuSeparator6.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator6.Size = new System.Drawing.Size(406, 14);
            this.bunifuSeparator6.TabIndex = 11;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(18, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(41, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // btnNuevoEmpleado
            // 
            this.btnNuevoEmpleado.ActiveBorderThickness = 1;
            this.btnNuevoEmpleado.ActiveCornerRadius = 20;
            this.btnNuevoEmpleado.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.btnNuevoEmpleado.ActiveForecolor = System.Drawing.Color.White;
            this.btnNuevoEmpleado.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.btnNuevoEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevoEmpleado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevoEmpleado.BackgroundImage")));
            this.btnNuevoEmpleado.ButtonText = "AGREGAR EMPLEADO";
            this.btnNuevoEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnNuevoEmpleado.IdleBorderThickness = 1;
            this.btnNuevoEmpleado.IdleCornerRadius = 20;
            this.btnNuevoEmpleado.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.btnNuevoEmpleado.IdleForecolor = System.Drawing.Color.White;
            this.btnNuevoEmpleado.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.btnNuevoEmpleado.Location = new System.Drawing.Point(24, 67);
            this.btnNuevoEmpleado.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            this.btnNuevoEmpleado.Size = new System.Drawing.Size(199, 43);
            this.btnNuevoEmpleado.TabIndex = 13;
            this.btnNuevoEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevoEmpleado.Click += new System.EventHandler(this.btnNuevoEmpleado_Click);
            // 
            // btnAsignarRol
            // 
            this.btnAsignarRol.ActiveBorderThickness = 1;
            this.btnAsignarRol.ActiveCornerRadius = 20;
            this.btnAsignarRol.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.btnAsignarRol.ActiveForecolor = System.Drawing.Color.White;
            this.btnAsignarRol.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.btnAsignarRol.BackColor = System.Drawing.SystemColors.Control;
            this.btnAsignarRol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAsignarRol.BackgroundImage")));
            this.btnAsignarRol.ButtonText = "ASIGNAR ROL";
            this.btnAsignarRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignarRol.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarRol.ForeColor = System.Drawing.Color.White;
            this.btnAsignarRol.IdleBorderThickness = 1;
            this.btnAsignarRol.IdleCornerRadius = 20;
            this.btnAsignarRol.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.btnAsignarRol.IdleForecolor = System.Drawing.Color.White;
            this.btnAsignarRol.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.btnAsignarRol.Location = new System.Drawing.Point(818, 12);
            this.btnAsignarRol.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAsignarRol.Name = "btnAsignarRol";
            this.btnAsignarRol.Size = new System.Drawing.Size(199, 43);
            this.btnAsignarRol.TabIndex = 14;
            this.btnAsignarRol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExcel
            // 
            this.btnExcel.ActiveBorderThickness = 1;
            this.btnExcel.ActiveCornerRadius = 20;
            this.btnExcel.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.btnExcel.ActiveForecolor = System.Drawing.Color.White;
            this.btnExcel.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.btnExcel.BackColor = System.Drawing.SystemColors.Control;
            this.btnExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.BackgroundImage")));
            this.btnExcel.ButtonText = "EXCEL";
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.IdleBorderThickness = 1;
            this.btnExcel.IdleCornerRadius = 20;
            this.btnExcel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.btnExcel.IdleForecolor = System.Drawing.Color.White;
            this.btnExcel.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.btnExcel.Location = new System.Drawing.Point(818, 65);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(199, 43);
            this.btnExcel.TabIndex = 15;
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmTrabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 689);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTrabajadores";
            this.Text = "FrmTrabajadores";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlCantidadEmpleados.ResumeLayout(false);
            this.pnlTotalProductosVendidos.ResumeLayout(false);
            this.TopEmpleado.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            this.bunifuPanel3.ResumeLayout(false);
            this.bunifuPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuPanel pnlCantidadEmpleados;
        private Bunifu.UI.WinForms.BunifuPanel pnlTotalProductosVendidos;
        private Bunifu.UI.WinForms.BunifuPanel TopEmpleado;
        private Bunifu.UI.WinForms.BunifuPanel pnlInfo;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel lblCategorias;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridViewImageColumn EDITAR;
        private System.Windows.Forms.DataGridViewImageColumn ELIMINAR;
        private Bunifu.UI.WinForms.BunifuTextBox txtSearch;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNuevoEmpleado;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExcel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAsignarRol;
    }
}