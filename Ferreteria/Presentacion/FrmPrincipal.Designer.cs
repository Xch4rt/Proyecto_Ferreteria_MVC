
namespace Presentacion
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.SideBar = new System.Windows.Forms.Panel();
            this.userName = new Bunifu.UI.WinForms.BunifuLabel();
            this.logout = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btnProveedores = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnClientes = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnTrabajadores = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnVentas = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnProductos = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnDashboard = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.Header = new System.Windows.Forms.Panel();
            this.PanelName = new Bunifu.UI.WinForms.BunifuLabel();
            this.BtnExit = new System.Windows.Forms.PictureBox();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SideBar.Controls.Add(this.userName);
            this.SideBar.Controls.Add(this.logout);
            this.SideBar.Controls.Add(this.btnProveedores);
            this.SideBar.Controls.Add(this.btnClientes);
            this.SideBar.Controls.Add(this.btnTrabajadores);
            this.SideBar.Controls.Add(this.btnVentas);
            this.SideBar.Controls.Add(this.btnProductos);
            this.SideBar.Controls.Add(this.btnDashboard);
            this.SideBar.Controls.Add(this.bunifuSeparator2);
            this.SideBar.Controls.Add(this.picUser);
            this.SideBar.Controls.Add(this.bunifuSeparator1);
            this.SideBar.Controls.Add(this.bunifuLabel2);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(240, 749);
            this.SideBar.TabIndex = 0;
            this.SideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.SideBar_Paint);
            // 
            // userName
            // 
            this.userName.AllowParentOverrides = false;
            this.userName.AutoEllipsis = false;
            this.userName.AutoSize = false;
            this.userName.CursorType = null;
            this.userName.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.userName.ForeColor = System.Drawing.Color.White;
            this.userName.Location = new System.Drawing.Point(3, 228);
            this.userName.Name = "userName";
            this.userName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userName.Size = new System.Drawing.Size(234, 45);
            this.userName.TabIndex = 16;
            this.userName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.userName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // logout
            // 
            this.logout.AllowFocused = false;
            this.logout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logout.AutoSizeHeight = true;
            this.logout.BorderRadius = 0;
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.IsCircle = true;
            this.logout.Location = new System.Drawing.Point(12, 702);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(35, 35);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logout.TabIndex = 15;
            this.logout.TabStop = false;
            this.logout.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.AllowAnimations = true;
            this.btnProveedores.AllowMouseEffects = true;
            this.btnProveedores.AllowToggling = false;
            this.btnProveedores.AnimationSpeed = 200;
            this.btnProveedores.AutoGenerateColors = false;
            this.btnProveedores.AutoRoundBorders = false;
            this.btnProveedores.AutoSizeLeftIcon = true;
            this.btnProveedores.AutoSizeRightIcon = true;
            this.btnProveedores.BackColor = System.Drawing.Color.Transparent;
            this.btnProveedores.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnProveedores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProveedores.BackgroundImage")));
            this.btnProveedores.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProveedores.ButtonText = "Proveedores";
            this.btnProveedores.ButtonTextMarginLeft = 0;
            this.btnProveedores.ColorContrastOnClick = 45;
            this.btnProveedores.ColorContrastOnHover = 45;
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnProveedores.CustomizableEdges = borderEdges1;
            this.btnProveedores.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProveedores.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnProveedores.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnProveedores.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnProveedores.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnProveedores.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.IconLeft = ((System.Drawing.Image)(resources.GetObject("btnProveedores.IconLeft")));
            this.btnProveedores.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnProveedores.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnProveedores.IconMarginLeft = 11;
            this.btnProveedores.IconPadding = 10;
            this.btnProveedores.IconRight = null;
            this.btnProveedores.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProveedores.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnProveedores.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnProveedores.IconSize = 25;
            this.btnProveedores.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnProveedores.IdleBorderRadius = 0;
            this.btnProveedores.IdleBorderThickness = 0;
            this.btnProveedores.IdleFillColor = System.Drawing.Color.Empty;
            this.btnProveedores.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnProveedores.IdleIconLeftImage")));
            this.btnProveedores.IdleIconRightImage = null;
            this.btnProveedores.IndicateFocus = false;
            this.btnProveedores.Location = new System.Drawing.Point(11, 550);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnProveedores.OnDisabledState.BorderRadius = 1;
            this.btnProveedores.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProveedores.OnDisabledState.BorderThickness = 1;
            this.btnProveedores.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnProveedores.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnProveedores.OnDisabledState.IconLeftImage = null;
            this.btnProveedores.OnDisabledState.IconRightImage = null;
            this.btnProveedores.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnProveedores.onHoverState.BorderRadius = 1;
            this.btnProveedores.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProveedores.onHoverState.BorderThickness = 1;
            this.btnProveedores.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnProveedores.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.onHoverState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnProveedores.onHoverState.IconLeftImage")));
            this.btnProveedores.onHoverState.IconRightImage = null;
            this.btnProveedores.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnProveedores.OnIdleState.BorderRadius = 1;
            this.btnProveedores.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProveedores.OnIdleState.BorderThickness = 1;
            this.btnProveedores.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnProveedores.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnProveedores.OnIdleState.IconLeftImage")));
            this.btnProveedores.OnIdleState.IconRightImage = null;
            this.btnProveedores.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnProveedores.OnPressedState.BorderRadius = 1;
            this.btnProveedores.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProveedores.OnPressedState.BorderThickness = 1;
            this.btnProveedores.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnProveedores.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.OnPressedState.IconLeftImage = null;
            this.btnProveedores.OnPressedState.IconRightImage = null;
            this.btnProveedores.Size = new System.Drawing.Size(223, 39);
            this.btnProveedores.TabIndex = 12;
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProveedores.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnProveedores.TextMarginLeft = 0;
            this.btnProveedores.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnProveedores.UseDefaultRadiusAndThickness = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.AllowAnimations = true;
            this.btnClientes.AllowMouseEffects = true;
            this.btnClientes.AllowToggling = false;
            this.btnClientes.AnimationSpeed = 200;
            this.btnClientes.AutoGenerateColors = false;
            this.btnClientes.AutoRoundBorders = false;
            this.btnClientes.AutoSizeLeftIcon = true;
            this.btnClientes.AutoSizeRightIcon = true;
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClientes.BackgroundImage")));
            this.btnClientes.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClientes.ButtonText = "Clientes";
            this.btnClientes.ButtonTextMarginLeft = 0;
            this.btnClientes.ColorContrastOnClick = 45;
            this.btnClientes.ColorContrastOnHover = 45;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnClientes.CustomizableEdges = borderEdges2;
            this.btnClientes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClientes.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClientes.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnClientes.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnClientes.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.IconLeft = ((System.Drawing.Image)(resources.GetObject("btnClientes.IconLeft")));
            this.btnClientes.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnClientes.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnClientes.IconMarginLeft = 11;
            this.btnClientes.IconPadding = 10;
            this.btnClientes.IconRight = null;
            this.btnClientes.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClientes.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnClientes.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnClientes.IconSize = 25;
            this.btnClientes.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnClientes.IdleBorderRadius = 0;
            this.btnClientes.IdleBorderThickness = 0;
            this.btnClientes.IdleFillColor = System.Drawing.Color.Empty;
            this.btnClientes.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnClientes.IdleIconLeftImage")));
            this.btnClientes.IdleIconRightImage = null;
            this.btnClientes.IndicateFocus = false;
            this.btnClientes.Location = new System.Drawing.Point(8, 505);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClientes.OnDisabledState.BorderRadius = 1;
            this.btnClientes.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClientes.OnDisabledState.BorderThickness = 1;
            this.btnClientes.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClientes.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClientes.OnDisabledState.IconLeftImage = null;
            this.btnClientes.OnDisabledState.IconRightImage = null;
            this.btnClientes.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnClientes.onHoverState.BorderRadius = 1;
            this.btnClientes.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClientes.onHoverState.BorderThickness = 1;
            this.btnClientes.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnClientes.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnClientes.onHoverState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnClientes.onHoverState.IconLeftImage")));
            this.btnClientes.onHoverState.IconRightImage = null;
            this.btnClientes.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnClientes.OnIdleState.BorderRadius = 1;
            this.btnClientes.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClientes.OnIdleState.BorderThickness = 1;
            this.btnClientes.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnClientes.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnClientes.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnClientes.OnIdleState.IconLeftImage")));
            this.btnClientes.OnIdleState.IconRightImage = null;
            this.btnClientes.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnClientes.OnPressedState.BorderRadius = 1;
            this.btnClientes.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClientes.OnPressedState.BorderThickness = 1;
            this.btnClientes.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnClientes.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnClientes.OnPressedState.IconLeftImage = null;
            this.btnClientes.OnPressedState.IconRightImage = null;
            this.btnClientes.Size = new System.Drawing.Size(223, 39);
            this.btnClientes.TabIndex = 11;
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClientes.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClientes.TextMarginLeft = 0;
            this.btnClientes.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnClientes.UseDefaultRadiusAndThickness = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnTrabajadores
            // 
            this.btnTrabajadores.AllowAnimations = true;
            this.btnTrabajadores.AllowMouseEffects = true;
            this.btnTrabajadores.AllowToggling = false;
            this.btnTrabajadores.AnimationSpeed = 200;
            this.btnTrabajadores.AutoGenerateColors = false;
            this.btnTrabajadores.AutoRoundBorders = false;
            this.btnTrabajadores.AutoSizeLeftIcon = true;
            this.btnTrabajadores.AutoSizeRightIcon = true;
            this.btnTrabajadores.BackColor = System.Drawing.Color.Transparent;
            this.btnTrabajadores.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnTrabajadores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrabajadores.BackgroundImage")));
            this.btnTrabajadores.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTrabajadores.ButtonText = "Trabajadores";
            this.btnTrabajadores.ButtonTextMarginLeft = 0;
            this.btnTrabajadores.ColorContrastOnClick = 45;
            this.btnTrabajadores.ColorContrastOnHover = 45;
            this.btnTrabajadores.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnTrabajadores.CustomizableEdges = borderEdges3;
            this.btnTrabajadores.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTrabajadores.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTrabajadores.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnTrabajadores.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnTrabajadores.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnTrabajadores.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTrabajadores.ForeColor = System.Drawing.Color.White;
            this.btnTrabajadores.IconLeft = ((System.Drawing.Image)(resources.GetObject("btnTrabajadores.IconLeft")));
            this.btnTrabajadores.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrabajadores.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnTrabajadores.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnTrabajadores.IconMarginLeft = 11;
            this.btnTrabajadores.IconPadding = 10;
            this.btnTrabajadores.IconRight = null;
            this.btnTrabajadores.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrabajadores.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnTrabajadores.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnTrabajadores.IconSize = 25;
            this.btnTrabajadores.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnTrabajadores.IdleBorderRadius = 0;
            this.btnTrabajadores.IdleBorderThickness = 0;
            this.btnTrabajadores.IdleFillColor = System.Drawing.Color.Empty;
            this.btnTrabajadores.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnTrabajadores.IdleIconLeftImage")));
            this.btnTrabajadores.IdleIconRightImage = null;
            this.btnTrabajadores.IndicateFocus = false;
            this.btnTrabajadores.Location = new System.Drawing.Point(8, 460);
            this.btnTrabajadores.Name = "btnTrabajadores";
            this.btnTrabajadores.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTrabajadores.OnDisabledState.BorderRadius = 1;
            this.btnTrabajadores.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTrabajadores.OnDisabledState.BorderThickness = 1;
            this.btnTrabajadores.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTrabajadores.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTrabajadores.OnDisabledState.IconLeftImage = null;
            this.btnTrabajadores.OnDisabledState.IconRightImage = null;
            this.btnTrabajadores.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnTrabajadores.onHoverState.BorderRadius = 1;
            this.btnTrabajadores.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTrabajadores.onHoverState.BorderThickness = 1;
            this.btnTrabajadores.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnTrabajadores.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnTrabajadores.onHoverState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnTrabajadores.onHoverState.IconLeftImage")));
            this.btnTrabajadores.onHoverState.IconRightImage = null;
            this.btnTrabajadores.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnTrabajadores.OnIdleState.BorderRadius = 1;
            this.btnTrabajadores.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTrabajadores.OnIdleState.BorderThickness = 1;
            this.btnTrabajadores.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnTrabajadores.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnTrabajadores.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnTrabajadores.OnIdleState.IconLeftImage")));
            this.btnTrabajadores.OnIdleState.IconRightImage = null;
            this.btnTrabajadores.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnTrabajadores.OnPressedState.BorderRadius = 1;
            this.btnTrabajadores.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTrabajadores.OnPressedState.BorderThickness = 1;
            this.btnTrabajadores.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnTrabajadores.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnTrabajadores.OnPressedState.IconLeftImage = null;
            this.btnTrabajadores.OnPressedState.IconRightImage = null;
            this.btnTrabajadores.Size = new System.Drawing.Size(223, 39);
            this.btnTrabajadores.TabIndex = 10;
            this.btnTrabajadores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTrabajadores.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTrabajadores.TextMarginLeft = 0;
            this.btnTrabajadores.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnTrabajadores.UseDefaultRadiusAndThickness = true;
            this.btnTrabajadores.Click += new System.EventHandler(this.btnTrabajadores_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.AllowAnimations = true;
            this.btnVentas.AllowMouseEffects = true;
            this.btnVentas.AllowToggling = false;
            this.btnVentas.AnimationSpeed = 200;
            this.btnVentas.AutoGenerateColors = false;
            this.btnVentas.AutoRoundBorders = false;
            this.btnVentas.AutoSizeLeftIcon = true;
            this.btnVentas.AutoSizeRightIcon = true;
            this.btnVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnVentas.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVentas.BackgroundImage")));
            this.btnVentas.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnVentas.ButtonText = "Ventas";
            this.btnVentas.ButtonTextMarginLeft = 0;
            this.btnVentas.ColorContrastOnClick = 45;
            this.btnVentas.ColorContrastOnHover = 45;
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnVentas.CustomizableEdges = borderEdges4;
            this.btnVentas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVentas.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnVentas.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnVentas.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnVentas.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnVentas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.IconLeft = ((System.Drawing.Image)(resources.GetObject("btnVentas.IconLeft")));
            this.btnVentas.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnVentas.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnVentas.IconMarginLeft = 11;
            this.btnVentas.IconPadding = 10;
            this.btnVentas.IconRight = null;
            this.btnVentas.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVentas.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnVentas.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnVentas.IconSize = 25;
            this.btnVentas.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnVentas.IdleBorderRadius = 0;
            this.btnVentas.IdleBorderThickness = 0;
            this.btnVentas.IdleFillColor = System.Drawing.Color.Empty;
            this.btnVentas.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnVentas.IdleIconLeftImage")));
            this.btnVentas.IdleIconRightImage = null;
            this.btnVentas.IndicateFocus = false;
            this.btnVentas.Location = new System.Drawing.Point(8, 415);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnVentas.OnDisabledState.BorderRadius = 1;
            this.btnVentas.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnVentas.OnDisabledState.BorderThickness = 1;
            this.btnVentas.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnVentas.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnVentas.OnDisabledState.IconLeftImage = null;
            this.btnVentas.OnDisabledState.IconRightImage = null;
            this.btnVentas.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnVentas.onHoverState.BorderRadius = 1;
            this.btnVentas.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnVentas.onHoverState.BorderThickness = 1;
            this.btnVentas.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnVentas.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnVentas.onHoverState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnVentas.onHoverState.IconLeftImage")));
            this.btnVentas.onHoverState.IconRightImage = null;
            this.btnVentas.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnVentas.OnIdleState.BorderRadius = 1;
            this.btnVentas.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnVentas.OnIdleState.BorderThickness = 1;
            this.btnVentas.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnVentas.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnVentas.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnVentas.OnIdleState.IconLeftImage")));
            this.btnVentas.OnIdleState.IconRightImage = null;
            this.btnVentas.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnVentas.OnPressedState.BorderRadius = 1;
            this.btnVentas.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnVentas.OnPressedState.BorderThickness = 1;
            this.btnVentas.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnVentas.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnVentas.OnPressedState.IconLeftImage = null;
            this.btnVentas.OnPressedState.IconRightImage = null;
            this.btnVentas.Size = new System.Drawing.Size(223, 39);
            this.btnVentas.TabIndex = 8;
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVentas.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnVentas.TextMarginLeft = 0;
            this.btnVentas.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnVentas.UseDefaultRadiusAndThickness = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.AllowAnimations = true;
            this.btnProductos.AllowMouseEffects = true;
            this.btnProductos.AllowToggling = false;
            this.btnProductos.AnimationSpeed = 200;
            this.btnProductos.AutoGenerateColors = false;
            this.btnProductos.AutoRoundBorders = false;
            this.btnProductos.AutoSizeLeftIcon = true;
            this.btnProductos.AutoSizeRightIcon = true;
            this.btnProductos.BackColor = System.Drawing.Color.Transparent;
            this.btnProductos.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnProductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProductos.BackgroundImage")));
            this.btnProductos.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProductos.ButtonText = "Productos";
            this.btnProductos.ButtonTextMarginLeft = 0;
            this.btnProductos.ColorContrastOnClick = 45;
            this.btnProductos.ColorContrastOnHover = 45;
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnProductos.CustomizableEdges = borderEdges5;
            this.btnProductos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProductos.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnProductos.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnProductos.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnProductos.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnProductos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.IconLeft = ((System.Drawing.Image)(resources.GetObject("btnProductos.IconLeft")));
            this.btnProductos.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnProductos.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnProductos.IconMarginLeft = 11;
            this.btnProductos.IconPadding = 10;
            this.btnProductos.IconRight = null;
            this.btnProductos.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductos.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnProductos.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnProductos.IconSize = 25;
            this.btnProductos.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnProductos.IdleBorderRadius = 0;
            this.btnProductos.IdleBorderThickness = 0;
            this.btnProductos.IdleFillColor = System.Drawing.Color.Empty;
            this.btnProductos.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnProductos.IdleIconLeftImage")));
            this.btnProductos.IdleIconRightImage = null;
            this.btnProductos.IndicateFocus = false;
            this.btnProductos.Location = new System.Drawing.Point(8, 370);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnProductos.OnDisabledState.BorderRadius = 1;
            this.btnProductos.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProductos.OnDisabledState.BorderThickness = 1;
            this.btnProductos.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnProductos.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnProductos.OnDisabledState.IconLeftImage = null;
            this.btnProductos.OnDisabledState.IconRightImage = null;
            this.btnProductos.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnProductos.onHoverState.BorderRadius = 1;
            this.btnProductos.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProductos.onHoverState.BorderThickness = 1;
            this.btnProductos.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnProductos.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnProductos.onHoverState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnProductos.onHoverState.IconLeftImage")));
            this.btnProductos.onHoverState.IconRightImage = null;
            this.btnProductos.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnProductos.OnIdleState.BorderRadius = 1;
            this.btnProductos.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProductos.OnIdleState.BorderThickness = 1;
            this.btnProductos.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnProductos.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnProductos.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnProductos.OnIdleState.IconLeftImage")));
            this.btnProductos.OnIdleState.IconRightImage = null;
            this.btnProductos.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnProductos.OnPressedState.BorderRadius = 1;
            this.btnProductos.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProductos.OnPressedState.BorderThickness = 1;
            this.btnProductos.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnProductos.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnProductos.OnPressedState.IconLeftImage = null;
            this.btnProductos.OnPressedState.IconRightImage = null;
            this.btnProductos.Size = new System.Drawing.Size(223, 39);
            this.btnProductos.TabIndex = 7;
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProductos.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnProductos.TextMarginLeft = 0;
            this.btnProductos.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnProductos.UseDefaultRadiusAndThickness = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.AllowAnimations = true;
            this.btnDashboard.AllowMouseEffects = true;
            this.btnDashboard.AllowToggling = false;
            this.btnDashboard.AnimationSpeed = 200;
            this.btnDashboard.AutoGenerateColors = false;
            this.btnDashboard.AutoRoundBorders = false;
            this.btnDashboard.AutoSizeLeftIcon = true;
            this.btnDashboard.AutoSizeRightIcon = true;
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnDashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.BackgroundImage")));
            this.btnDashboard.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.ButtonText = "Dashboard";
            this.btnDashboard.ButtonTextMarginLeft = 0;
            this.btnDashboard.ColorContrastOnClick = 45;
            this.btnDashboard.ColorContrastOnHover = 45;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btnDashboard.CustomizableEdges = borderEdges6;
            this.btnDashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashboard.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDashboard.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnDashboard.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnDashboard.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.IconLeft = ((System.Drawing.Image)(resources.GetObject("btnDashboard.IconLeft")));
            this.btnDashboard.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDashboard.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDashboard.IconMarginLeft = 11;
            this.btnDashboard.IconPadding = 10;
            this.btnDashboard.IconRight = null;
            this.btnDashboard.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDashboard.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDashboard.IconSize = 25;
            this.btnDashboard.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnDashboard.IdleBorderRadius = 0;
            this.btnDashboard.IdleBorderThickness = 0;
            this.btnDashboard.IdleFillColor = System.Drawing.Color.Empty;
            this.btnDashboard.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.IdleIconLeftImage")));
            this.btnDashboard.IdleIconRightImage = null;
            this.btnDashboard.IndicateFocus = false;
            this.btnDashboard.Location = new System.Drawing.Point(8, 325);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDashboard.OnDisabledState.BorderRadius = 1;
            this.btnDashboard.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.OnDisabledState.BorderThickness = 1;
            this.btnDashboard.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDashboard.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDashboard.OnDisabledState.IconLeftImage = null;
            this.btnDashboard.OnDisabledState.IconRightImage = null;
            this.btnDashboard.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnDashboard.onHoverState.BorderRadius = 1;
            this.btnDashboard.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.onHoverState.BorderThickness = 1;
            this.btnDashboard.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnDashboard.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.onHoverState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.onHoverState.IconLeftImage")));
            this.btnDashboard.onHoverState.IconRightImage = null;
            this.btnDashboard.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDashboard.OnIdleState.BorderRadius = 1;
            this.btnDashboard.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.OnIdleState.BorderThickness = 1;
            this.btnDashboard.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnDashboard.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.OnIdleState.IconLeftImage")));
            this.btnDashboard.OnIdleState.IconRightImage = null;
            this.btnDashboard.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnDashboard.OnPressedState.BorderRadius = 1;
            this.btnDashboard.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.OnPressedState.BorderThickness = 1;
            this.btnDashboard.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnDashboard.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.OnPressedState.IconLeftImage = null;
            this.btnDashboard.OnPressedState.IconRightImage = null;
            this.btnDashboard.Size = new System.Drawing.Size(223, 39);
            this.btnDashboard.TabIndex = 6;
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDashboard.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDashboard.TextMarginLeft = 0;
            this.btnDashboard.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDashboard.UseDefaultRadiusAndThickness = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator2.BackgroundImage")));
            this.bunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Round;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(8, 279);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator2.Size = new System.Drawing.Size(225, 14);
            this.bunifuSeparator2.TabIndex = 5;
            // 
            // picUser
            // 
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.Location = new System.Drawing.Point(55, 125);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(116, 97);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 3;
            this.picUser.TabStop = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Round;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(6, 105);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(225, 14);
            this.bunifuSeparator1.TabIndex = 2;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel2.Location = new System.Drawing.Point(70, 40);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(87, 20);
            this.bunifuLabel2.TabIndex = 1;
            this.bunifuLabel2.Text = "FERRETERIA";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Header.Controls.Add(this.PanelName);
            this.Header.Controls.Add(this.BtnExit);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(240, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1044, 60);
            this.Header.TabIndex = 1;
            // 
            // PanelName
            // 
            this.PanelName.AllowParentOverrides = false;
            this.PanelName.AutoEllipsis = false;
            this.PanelName.Cursor = System.Windows.Forms.Cursors.Default;
            this.PanelName.CursorType = System.Windows.Forms.Cursors.Default;
            this.PanelName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PanelName.ForeColor = System.Drawing.Color.White;
            this.PanelName.Location = new System.Drawing.Point(15, 21);
            this.PanelName.Name = "PanelName";
            this.PanelName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PanelName.Size = new System.Drawing.Size(0, 0);
            this.PanelName.TabIndex = 1;
            this.PanelName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.PanelName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Location = new System.Drawing.Point(997, 12);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(35, 35);
            this.BtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnExit.TabIndex = 0;
            this.BtnExit.TabStop = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Wrapper
            // 
            this.Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(240, 60);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(1044, 689);
            this.Wrapper.TabIndex = 2;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 749);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.SideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.SideBar.ResumeLayout(false);
            this.SideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.PictureBox BtnExit;
        private System.Windows.Forms.Panel Wrapper;
        private Bunifu.UI.WinForms.BunifuLabel PanelName;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.PictureBox picUser;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnVentas;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnProductos;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDashboard;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnProveedores;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnClientes;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnTrabajadores;
        private Bunifu.UI.WinForms.BunifuPictureBox logout;
        public Bunifu.UI.WinForms.BunifuLabel userName;
    }
}