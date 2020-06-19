namespace GestionJardin
{
    partial class frmConceptos2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConceptos2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBusqueda = new MetroFramework.Controls.MetroPanel();
            this.txtBuscarConcepto = new MetroFramework.Controls.MetroTextBox();
            this.lblControlOtros = new System.Windows.Forms.Label();
            this.cbo_Conceptos = new MetroFramework.Controls.MetroComboBox();
            this.txt_Otros = new MetroFramework.Controls.MetroTextBox();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.panelData = new System.Windows.Forms.Panel();
            this.dgv_ConVisualizar = new MetroFramework.Controls.MetroGrid();
            this.panelAcciones = new System.Windows.Forms.Panel();
            this.lblDeshabilitar = new System.Windows.Forms.Label();
            this.btnBloqueoInactivar = new FontAwesome.Sharp.IconButton();
            this.lblControlFechaAlta = new System.Windows.Forms.Label();
            this.lblErAnio = new System.Windows.Forms.Label();
            this.lblErrorAnio = new System.Windows.Forms.Label();
            this.lblErrorSemestre = new System.Windows.Forms.Label();
            this.lblControlFecha = new System.Windows.Forms.Label();
            this.lblControlAnio = new System.Windows.Forms.Label();
            this.lblControlMonto = new System.Windows.Forms.Label();
            this.lblErrorFecha = new System.Windows.Forms.Label();
            this.lblEditar = new System.Windows.Forms.Label();
            this.btnBloqueoEditar = new FontAwesome.Sharp.IconButton();
            this.cbo_Estado = new MetroFramework.Controls.MetroComboBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.dt_FechaAlta = new MetroFramework.Controls.MetroDateTime();
            this.txtAnio = new MetroFramework.Controls.MetroTextBox();
            this.txtMonto = new MetroFramework.Controls.MetroTextBox();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblAyuda = new MetroFramework.Controls.MetroLabel();
            this.btnGuardarIngresar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGuardarEd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancelarIngresar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelBusqueda.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ConVisualizar)).BeginInit();
            this.panelAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panelBusqueda.Controls.Add(this.lblControlOtros);
            this.panelBusqueda.Controls.Add(this.cbo_Conceptos);
            this.panelBusqueda.Controls.Add(this.txt_Otros);
            this.panelBusqueda.Controls.Add(this.txtBuscarConcepto);
            this.panelBusqueda.HorizontalScrollbarBarColor = true;
            this.panelBusqueda.HorizontalScrollbarHighlightOnWheel = false;
            this.panelBusqueda.HorizontalScrollbarSize = 10;
            this.panelBusqueda.Location = new System.Drawing.Point(321, 125);
            this.panelBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(1038, 100);
            this.panelBusqueda.TabIndex = 21;
            this.panelBusqueda.UseCustomBackColor = true;
            this.panelBusqueda.VerticalScrollbarBarColor = true;
            this.panelBusqueda.VerticalScrollbarHighlightOnWheel = false;
            this.panelBusqueda.VerticalScrollbarSize = 11;
            // 
            // txtBuscarConcepto
            // 
            this.txtBuscarConcepto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBuscarConcepto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBuscarConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtBuscarConcepto.CustomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBuscarConcepto.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtBuscarConcepto.CustomButton.Location = new System.Drawing.Point(888, 1);
            this.txtBuscarConcepto.CustomButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtBuscarConcepto.CustomButton.Name = "";
            this.txtBuscarConcepto.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.txtBuscarConcepto.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtBuscarConcepto.CustomButton.TabIndex = 1;
            this.txtBuscarConcepto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBuscarConcepto.CustomButton.UseSelectable = true;
            this.txtBuscarConcepto.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBuscarConcepto.Lines = new string[0];
            this.txtBuscarConcepto.Location = new System.Drawing.Point(54, 33);
            this.txtBuscarConcepto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarConcepto.MaxLength = 32767;
            this.txtBuscarConcepto.Name = "txtBuscarConcepto";
            this.txtBuscarConcepto.PasswordChar = '\0';
            this.txtBuscarConcepto.PromptText = "CONCEPTO-AÑO-ESTADO";
            this.txtBuscarConcepto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscarConcepto.SelectedText = "";
            this.txtBuscarConcepto.SelectionLength = 0;
            this.txtBuscarConcepto.SelectionStart = 0;
            this.txtBuscarConcepto.ShortcutsEnabled = true;
            this.txtBuscarConcepto.ShowButton = true;
            this.txtBuscarConcepto.ShowClearButton = true;
            this.txtBuscarConcepto.Size = new System.Drawing.Size(930, 43);
            this.txtBuscarConcepto.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBuscarConcepto.TabIndex = 53;
            this.txtBuscarConcepto.UseSelectable = true;
            this.txtBuscarConcepto.UseStyleColors = true;
            this.txtBuscarConcepto.WaterMark = "CONCEPTO-AÑO-ESTADO";
            this.txtBuscarConcepto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBuscarConcepto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarConcepto.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtBuscarConcepto_ButtonClick);
            // 
            // lblControlOtros
            // 
            this.lblControlOtros.AutoSize = true;
            this.lblControlOtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlOtros.ForeColor = System.Drawing.Color.Red;
            this.lblControlOtros.Location = new System.Drawing.Point(990, 38);
            this.lblControlOtros.Name = "lblControlOtros";
            this.lblControlOtros.Size = new System.Drawing.Size(30, 38);
            this.lblControlOtros.TabIndex = 73;
            this.lblControlOtros.Text = "*";
            this.lblControlOtros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo_Conceptos
            // 
            this.cbo_Conceptos.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cbo_Conceptos.FormattingEnabled = true;
            this.cbo_Conceptos.ItemHeight = 29;
            this.cbo_Conceptos.Items.AddRange(new object[] {
            "MATRICULA",
            "CUOTA SALA 1",
            "CUOTA SALA 2",
            "CUOTA SALA 3",
            "CUOTA SALA 4",
            "CUOTA SALA 5",
            "INTERES POR MORA",
            "MATERIAL DIDACTICO",
            "OTROS"});
            this.cbo_Conceptos.Location = new System.Drawing.Point(54, 33);
            this.cbo_Conceptos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_Conceptos.Name = "cbo_Conceptos";
            this.cbo_Conceptos.PromptText = "Seleccione CONCEPTO";
            this.cbo_Conceptos.Size = new System.Drawing.Size(351, 35);
            this.cbo_Conceptos.Style = MetroFramework.MetroColorStyle.Green;
            this.cbo_Conceptos.TabIndex = 54;
            this.cbo_Conceptos.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbo_Conceptos.UseSelectable = true;
            this.cbo_Conceptos.UseStyleColors = true;
            this.cbo_Conceptos.SelectedIndexChanged += new System.EventHandler(this.cbo_Conceptos_SelectedIndexChanged);
            // 
            // txt_Otros
            // 
            this.txt_Otros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txt_Otros.CustomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Otros.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.txt_Otros.CustomButton.Location = new System.Drawing.Point(449, 1);
            this.txt_Otros.CustomButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txt_Otros.CustomButton.Name = "";
            this.txt_Otros.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.txt_Otros.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txt_Otros.CustomButton.TabIndex = 1;
            this.txt_Otros.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Otros.CustomButton.UseSelectable = true;
            this.txt_Otros.CustomButton.Visible = false;
            this.txt_Otros.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_Otros.Lines = new string[0];
            this.txt_Otros.Location = new System.Drawing.Point(493, 33);
            this.txt_Otros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Otros.MaxLength = 32767;
            this.txt_Otros.Name = "txt_Otros";
            this.txt_Otros.PasswordChar = '\0';
            this.txt_Otros.PromptText = "CONCEPTO";
            this.txt_Otros.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Otros.SelectedText = "";
            this.txt_Otros.SelectionLength = 0;
            this.txt_Otros.SelectionStart = 0;
            this.txt_Otros.ShortcutsEnabled = true;
            this.txt_Otros.ShowClearButton = true;
            this.txt_Otros.Size = new System.Drawing.Size(491, 43);
            this.txt_Otros.Style = MetroFramework.MetroColorStyle.Green;
            this.txt_Otros.TabIndex = 55;
            this.txt_Otros.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Otros.UseSelectable = true;
            this.txt_Otros.UseStyleColors = true;
            this.txt_Otros.WaterMark = "CONCEPTO";
            this.txt_Otros.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Otros.WaterMarkFont = new System.Drawing.Font("Segoe UI", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Otros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Otros_KeyPress);
            this.txt_Otros.Validated += new System.EventHandler(this.txt_Otros_Validated);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnAgregar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregar.IconColor = System.Drawing.Color.SeaGreen;
            this.btnAgregar.IconSize = 81;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.Location = new System.Drawing.Point(184, 125);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Rotation = 0D;
            this.btnAgregar.Size = new System.Drawing.Size(100, 100);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnBuscar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscar.IconSize = 81;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.Location = new System.Drawing.Point(52, 125);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Rotation = 0D;
            this.btnBuscar.Size = new System.Drawing.Size(100, 100);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Verdana Pro Cond", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_Titulo.Location = new System.Drawing.Point(528, 286);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(247, 52);
            this.lbl_Titulo.TabIndex = 27;
            this.lbl_Titulo.Text = "CONCEPTOS";
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panelData.Controls.Add(this.dgv_ConVisualizar);
            this.panelData.Location = new System.Drawing.Point(89, 389);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1221, 339);
            this.panelData.TabIndex = 26;
            // 
            // dgv_ConVisualizar
            // 
            this.dgv_ConVisualizar.AllowUserToAddRows = false;
            this.dgv_ConVisualizar.AllowUserToDeleteRows = false;
            this.dgv_ConVisualizar.AllowUserToResizeRows = false;
            this.dgv_ConVisualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_ConVisualizar.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_ConVisualizar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ConVisualizar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgv_ConVisualizar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ConVisualizar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgv_ConVisualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ConVisualizar.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgv_ConVisualizar.EnableHeadersVisualStyles = false;
            this.dgv_ConVisualizar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_ConVisualizar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgv_ConVisualizar.Location = new System.Drawing.Point(8, 12);
            this.dgv_ConVisualizar.Name = "dgv_ConVisualizar";
            this.dgv_ConVisualizar.ReadOnly = true;
            this.dgv_ConVisualizar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ConVisualizar.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgv_ConVisualizar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_ConVisualizar.RowTemplate.Height = 24;
            this.dgv_ConVisualizar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ConVisualizar.Size = new System.Drawing.Size(1198, 308);
            this.dgv_ConVisualizar.TabIndex = 2;
            // 
            // panelAcciones
            // 
            this.panelAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panelAcciones.Controls.Add(this.btnEliminar);
            this.panelAcciones.Controls.Add(this.btnCancelarIngresar);
            this.panelAcciones.Controls.Add(this.btnGuardarEd);
            this.panelAcciones.Controls.Add(this.btnGuardarIngresar);
            this.panelAcciones.Controls.Add(this.lblDeshabilitar);
            this.panelAcciones.Controls.Add(this.btnBloqueoInactivar);
            this.panelAcciones.Controls.Add(this.lblControlFechaAlta);
            this.panelAcciones.Controls.Add(this.lblErAnio);
            this.panelAcciones.Controls.Add(this.lblErrorAnio);
            this.panelAcciones.Controls.Add(this.lblErrorSemestre);
            this.panelAcciones.Controls.Add(this.lblControlFecha);
            this.panelAcciones.Controls.Add(this.lblControlAnio);
            this.panelAcciones.Controls.Add(this.lblControlMonto);
            this.panelAcciones.Controls.Add(this.lblErrorFecha);
            this.panelAcciones.Controls.Add(this.lblEditar);
            this.panelAcciones.Controls.Add(this.btnBloqueoEditar);
            this.panelAcciones.Controls.Add(this.cbo_Estado);
            this.panelAcciones.Controls.Add(this.lblAnio);
            this.panelAcciones.Controls.Add(this.lblMonto);
            this.panelAcciones.Controls.Add(this.dt_FechaAlta);
            this.panelAcciones.Controls.Add(this.txtAnio);
            this.panelAcciones.Controls.Add(this.txtMonto);
            this.panelAcciones.Controls.Add(this.lblFechaAlta);
            this.panelAcciones.Location = new System.Drawing.Point(139, 303);
            this.panelAcciones.Name = "panelAcciones";
            this.panelAcciones.Size = new System.Drawing.Size(1202, 425);
            this.panelAcciones.TabIndex = 28;
            // 
            // lblDeshabilitar
            // 
            this.lblDeshabilitar.AutoSize = true;
            this.lblDeshabilitar.Font = new System.Drawing.Font("Verdana Pro", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeshabilitar.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblDeshabilitar.Location = new System.Drawing.Point(385, 388);
            this.lblDeshabilitar.Name = "lblDeshabilitar";
            this.lblDeshabilitar.Size = new System.Drawing.Size(136, 18);
            this.lblDeshabilitar.TabIndex = 78;
            this.lblDeshabilitar.Text = "DESHABILITAR";
            // 
            // btnBloqueoInactivar
            // 
            this.btnBloqueoInactivar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBloqueoInactivar.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnBloqueoInactivar.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnBloqueoInactivar.IconColor = System.Drawing.Color.OrangeRed;
            this.btnBloqueoInactivar.IconSize = 32;
            this.btnBloqueoInactivar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBloqueoInactivar.Location = new System.Drawing.Point(427, 329);
            this.btnBloqueoInactivar.Name = "btnBloqueoInactivar";
            this.btnBloqueoInactivar.Rotation = 0D;
            this.btnBloqueoInactivar.Size = new System.Drawing.Size(48, 49);
            this.btnBloqueoInactivar.TabIndex = 77;
            this.btnBloqueoInactivar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBloqueoInactivar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnBloqueoInactivar.UseVisualStyleBackColor = true;
            this.btnBloqueoInactivar.Click += new System.EventHandler(this.btnBloqueoInactivar_Click);
            // 
            // lblControlFechaAlta
            // 
            this.lblControlFechaAlta.AutoSize = true;
            this.lblControlFechaAlta.ForeColor = System.Drawing.Color.Red;
            this.lblControlFechaAlta.Location = new System.Drawing.Point(228, 292);
            this.lblControlFechaAlta.Name = "lblControlFechaAlta";
            this.lblControlFechaAlta.Size = new System.Drawing.Size(46, 17);
            this.lblControlFechaAlta.TabIndex = 76;
            this.lblControlFechaAlta.Text = "label1";
            // 
            // lblErAnio
            // 
            this.lblErAnio.AutoSize = true;
            this.lblErAnio.ForeColor = System.Drawing.Color.Red;
            this.lblErAnio.Location = new System.Drawing.Point(228, 215);
            this.lblErAnio.Name = "lblErAnio";
            this.lblErAnio.Size = new System.Drawing.Size(46, 17);
            this.lblErAnio.TabIndex = 75;
            this.lblErAnio.Text = "label1";
            // 
            // lblErrorAnio
            // 
            this.lblErrorAnio.AutoSize = true;
            this.lblErrorAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorAnio.ForeColor = System.Drawing.Color.Red;
            this.lblErrorAnio.Location = new System.Drawing.Point(752, 126);
            this.lblErrorAnio.Name = "lblErrorAnio";
            this.lblErrorAnio.Size = new System.Drawing.Size(0, 17);
            this.lblErrorAnio.TabIndex = 74;
            this.lblErrorAnio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrorSemestre
            // 
            this.lblErrorSemestre.AutoSize = true;
            this.lblErrorSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorSemestre.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSemestre.Location = new System.Drawing.Point(697, 216);
            this.lblErrorSemestre.Name = "lblErrorSemestre";
            this.lblErrorSemestre.Size = new System.Drawing.Size(0, 17);
            this.lblErrorSemestre.TabIndex = 73;
            this.lblErrorSemestre.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblControlFecha
            // 
            this.lblControlFecha.AutoSize = true;
            this.lblControlFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlFecha.ForeColor = System.Drawing.Color.Red;
            this.lblControlFecha.Location = new System.Drawing.Point(551, 249);
            this.lblControlFecha.Name = "lblControlFecha";
            this.lblControlFecha.Size = new System.Drawing.Size(30, 38);
            this.lblControlFecha.TabIndex = 71;
            this.lblControlFecha.Text = "*";
            this.lblControlFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblControlAnio
            // 
            this.lblControlAnio.AutoSize = true;
            this.lblControlAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlAnio.ForeColor = System.Drawing.Color.Red;
            this.lblControlAnio.Location = new System.Drawing.Point(501, 157);
            this.lblControlAnio.Name = "lblControlAnio";
            this.lblControlAnio.Size = new System.Drawing.Size(30, 38);
            this.lblControlAnio.TabIndex = 70;
            this.lblControlAnio.Text = "*";
            this.lblControlAnio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblControlMonto
            // 
            this.lblControlMonto.AutoSize = true;
            this.lblControlMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlMonto.ForeColor = System.Drawing.Color.Red;
            this.lblControlMonto.Location = new System.Drawing.Point(501, 74);
            this.lblControlMonto.Name = "lblControlMonto";
            this.lblControlMonto.Size = new System.Drawing.Size(30, 38);
            this.lblControlMonto.TabIndex = 69;
            this.lblControlMonto.Text = "*";
            this.lblControlMonto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrorFecha
            // 
            this.lblErrorFecha.AutoSize = true;
            this.lblErrorFecha.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFecha.Location = new System.Drawing.Point(83, 227);
            this.lblErrorFecha.Name = "lblErrorFecha";
            this.lblErrorFecha.Size = new System.Drawing.Size(0, 17);
            this.lblErrorFecha.TabIndex = 68;
            // 
            // lblEditar
            // 
            this.lblEditar.AutoSize = true;
            this.lblEditar.Font = new System.Drawing.Font("Verdana Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblEditar.Location = new System.Drawing.Point(604, 79);
            this.lblEditar.Name = "lblEditar";
            this.lblEditar.Size = new System.Drawing.Size(81, 20);
            this.lblEditar.TabIndex = 67;
            this.lblEditar.Text = "EDITAR";
            // 
            // btnBloqueoEditar
            // 
            this.btnBloqueoEditar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBloqueoEditar.ForeColor = System.Drawing.Color.Transparent;
            this.btnBloqueoEditar.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnBloqueoEditar.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnBloqueoEditar.IconSize = 32;
            this.btnBloqueoEditar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBloqueoEditar.Location = new System.Drawing.Point(548, 66);
            this.btnBloqueoEditar.Name = "btnBloqueoEditar";
            this.btnBloqueoEditar.Rotation = 0D;
            this.btnBloqueoEditar.Size = new System.Drawing.Size(50, 49);
            this.btnBloqueoEditar.TabIndex = 62;
            this.btnBloqueoEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBloqueoEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnBloqueoEditar.UseVisualStyleBackColor = true;
            this.btnBloqueoEditar.Click += new System.EventHandler(this.btnBloqueoEditar_Click);
            // 
            // cbo_Estado
            // 
            this.cbo_Estado.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cbo_Estado.FormattingEnabled = true;
            this.cbo_Estado.ItemHeight = 29;
            this.cbo_Estado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cbo_Estado.Location = new System.Drawing.Point(173, 329);
            this.cbo_Estado.Name = "cbo_Estado";
            this.cbo_Estado.PromptText = "ESTADO";
            this.cbo_Estado.Size = new System.Drawing.Size(227, 35);
            this.cbo_Estado.Style = MetroFramework.MetroColorStyle.Green;
            this.cbo_Estado.TabIndex = 64;
            this.cbo_Estado.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbo_Estado.UseSelectable = true;
            this.cbo_Estado.UseStyleColors = true;
            this.cbo_Estado.SelectedValueChanged += new System.EventHandler(this.cbo_Estado_SelectedValueChanged);
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Verdana Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAnio.Location = new System.Drawing.Point(168, 152);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(70, 25);
            this.lblAnio.TabIndex = 61;
            this.lblAnio.Text = "AÑO:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Verdana Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblMonto.Location = new System.Drawing.Point(101, 75);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(125, 25);
            this.lblMonto.TabIndex = 60;
            this.lblMonto.Text = "IMPORTE:";
            // 
            // dt_FechaAlta
            // 
            this.dt_FechaAlta.FontSize = MetroFramework.MetroDateTimeSize.Tall;
            this.dt_FechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_FechaAlta.Location = new System.Drawing.Point(318, 241);
            this.dt_FechaAlta.MinimumSize = new System.Drawing.Size(0, 35);
            this.dt_FechaAlta.Name = "dt_FechaAlta";
            this.dt_FechaAlta.Size = new System.Drawing.Size(227, 35);
            this.dt_FechaAlta.Style = MetroFramework.MetroColorStyle.Green;
            this.dt_FechaAlta.TabIndex = 57;
            this.dt_FechaAlta.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dt_FechaAlta.UseStyleColors = true;
            this.dt_FechaAlta.ValueChanged += new System.EventHandler(this.dt_FechaAlta_ValueChanged);
            // 
            // txtAnio
            // 
            // 
            // 
            // 
            this.txtAnio.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnio.CustomButton.Image = null;
            this.txtAnio.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtAnio.CustomButton.Name = "";
            this.txtAnio.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.txtAnio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAnio.CustomButton.TabIndex = 1;
            this.txtAnio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAnio.CustomButton.UseSelectable = true;
            this.txtAnio.CustomButton.Visible = false;
            this.txtAnio.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtAnio.Lines = new string[0];
            this.txtAnio.Location = new System.Drawing.Point(318, 152);
            this.txtAnio.MaxLength = 32767;
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.PasswordChar = '\0';
            this.txtAnio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAnio.SelectedText = "";
            this.txtAnio.SelectionLength = 0;
            this.txtAnio.SelectionStart = 0;
            this.txtAnio.ShortcutsEnabled = true;
            this.txtAnio.Size = new System.Drawing.Size(177, 43);
            this.txtAnio.Style = MetroFramework.MetroColorStyle.Green;
            this.txtAnio.TabIndex = 58;
            this.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAnio.UseSelectable = true;
            this.txtAnio.UseStyleColors = true;
            this.txtAnio.WaterMarkColor = System.Drawing.Color.DimGray;
            this.txtAnio.WaterMarkFont = new System.Drawing.Font("Verdana Pro", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnio_KeyPress);
            this.txtAnio.Validated += new System.EventHandler(this.txtAnio_Validated);
            // 
            // txtMonto
            // 
            // 
            // 
            // 
            this.txtMonto.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.CustomButton.Image = null;
            this.txtMonto.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtMonto.CustomButton.Name = "";
            this.txtMonto.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.txtMonto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMonto.CustomButton.TabIndex = 1;
            this.txtMonto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMonto.CustomButton.UseSelectable = true;
            this.txtMonto.CustomButton.Visible = false;
            this.txtMonto.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtMonto.Lines = new string[0];
            this.txtMonto.Location = new System.Drawing.Point(318, 66);
            this.txtMonto.MaxLength = 32767;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.PasswordChar = '\0';
            this.txtMonto.PromptText = "$";
            this.txtMonto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMonto.SelectedText = "";
            this.txtMonto.SelectionLength = 0;
            this.txtMonto.SelectionStart = 0;
            this.txtMonto.ShortcutsEnabled = true;
            this.txtMonto.Size = new System.Drawing.Size(177, 43);
            this.txtMonto.Style = MetroFramework.MetroColorStyle.Green;
            this.txtMonto.TabIndex = 56;
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonto.UseSelectable = true;
            this.txtMonto.UseStyleColors = true;
            this.txtMonto.WaterMark = "$";
            this.txtMonto.WaterMarkColor = System.Drawing.Color.DimGray;
            this.txtMonto.WaterMarkFont = new System.Drawing.Font("Verdana Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            this.txtMonto.Validated += new System.EventHandler(this.txtMonto_Validated);
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Font = new System.Drawing.Font("Verdana Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAlta.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblFechaAlta.Location = new System.Drawing.Point(81, 244);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(157, 25);
            this.lblFechaAlta.TabIndex = 53;
            this.lblFechaAlta.Text = "FECHA ALTA:";
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAyuda.Location = new System.Drawing.Point(36, 72);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(222, 20);
            this.lblAyuda.TabIndex = 29;
            this.lblAyuda.Text = "Buscar o Agregar un Concepto";
            this.lblAyuda.UseCustomBackColor = true;
            // 
            // btnGuardarIngresar
            // 
            this.btnGuardarIngresar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGuardarIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGuardarIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarIngresar.BorderRadius = 5;
            this.btnGuardarIngresar.ButtonText = "GUARDAR";
            this.btnGuardarIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarIngresar.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardarIngresar.Font = new System.Drawing.Font("Segoe MDL2 Assets", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarIngresar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardarIngresar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGuardarIngresar.Iconimage")));
            this.btnGuardarIngresar.Iconimage_right = null;
            this.btnGuardarIngresar.Iconimage_right_Selected = null;
            this.btnGuardarIngresar.Iconimage_Selected = null;
            this.btnGuardarIngresar.IconMarginLeft = 0;
            this.btnGuardarIngresar.IconMarginRight = 0;
            this.btnGuardarIngresar.IconRightVisible = true;
            this.btnGuardarIngresar.IconRightZoom = 0D;
            this.btnGuardarIngresar.IconVisible = false;
            this.btnGuardarIngresar.IconZoom = 90D;
            this.btnGuardarIngresar.IsTab = false;
            this.btnGuardarIngresar.Location = new System.Drawing.Point(864, 92);
            this.btnGuardarIngresar.Name = "btnGuardarIngresar";
            this.btnGuardarIngresar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGuardarIngresar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnGuardarIngresar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardarIngresar.selected = false;
            this.btnGuardarIngresar.Size = new System.Drawing.Size(165, 51);
            this.btnGuardarIngresar.TabIndex = 81;
            this.btnGuardarIngresar.Text = "GUARDAR";
            this.btnGuardarIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardarIngresar.Textcolor = System.Drawing.Color.White;
            this.btnGuardarIngresar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarIngresar.Click += new System.EventHandler(this.btnGuardarIngresar_Click_1);
            // 
            // btnGuardarEd
            // 
            this.btnGuardarEd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGuardarEd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGuardarEd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarEd.BorderRadius = 5;
            this.btnGuardarEd.ButtonText = "GUARDAR";
            this.btnGuardarEd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarEd.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardarEd.Font = new System.Drawing.Font("Segoe MDL2 Assets", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardarEd.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGuardarEd.Iconimage")));
            this.btnGuardarEd.Iconimage_right = null;
            this.btnGuardarEd.Iconimage_right_Selected = null;
            this.btnGuardarEd.Iconimage_Selected = null;
            this.btnGuardarEd.IconMarginLeft = 0;
            this.btnGuardarEd.IconMarginRight = 0;
            this.btnGuardarEd.IconRightVisible = true;
            this.btnGuardarEd.IconRightZoom = 0D;
            this.btnGuardarEd.IconVisible = false;
            this.btnGuardarEd.IconZoom = 90D;
            this.btnGuardarEd.IsTab = false;
            this.btnGuardarEd.Location = new System.Drawing.Point(864, 92);
            this.btnGuardarEd.Name = "btnGuardarEd";
            this.btnGuardarEd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGuardarEd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnGuardarEd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardarEd.selected = false;
            this.btnGuardarEd.Size = new System.Drawing.Size(165, 51);
            this.btnGuardarEd.TabIndex = 82;
            this.btnGuardarEd.Text = "GUARDAR";
            this.btnGuardarEd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardarEd.Textcolor = System.Drawing.Color.White;
            this.btnGuardarEd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEd.Click += new System.EventHandler(this.btnGuardarEd_Click_1);
            // 
            // btnCancelarIngresar
            // 
            this.btnCancelarIngresar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelarIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelarIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelarIngresar.BorderRadius = 5;
            this.btnCancelarIngresar.ButtonText = "CANCELAR";
            this.btnCancelarIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarIngresar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancelarIngresar.Font = new System.Drawing.Font("Segoe MDL2 Assets", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarIngresar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancelarIngresar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCancelarIngresar.Iconimage")));
            this.btnCancelarIngresar.Iconimage_right = null;
            this.btnCancelarIngresar.Iconimage_right_Selected = null;
            this.btnCancelarIngresar.Iconimage_Selected = null;
            this.btnCancelarIngresar.IconMarginLeft = 0;
            this.btnCancelarIngresar.IconMarginRight = 0;
            this.btnCancelarIngresar.IconRightVisible = true;
            this.btnCancelarIngresar.IconRightZoom = 0D;
            this.btnCancelarIngresar.IconVisible = false;
            this.btnCancelarIngresar.IconZoom = 90D;
            this.btnCancelarIngresar.IsTab = false;
            this.btnCancelarIngresar.Location = new System.Drawing.Point(864, 193);
            this.btnCancelarIngresar.Name = "btnCancelarIngresar";
            this.btnCancelarIngresar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelarIngresar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.btnCancelarIngresar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancelarIngresar.selected = false;
            this.btnCancelarIngresar.Size = new System.Drawing.Size(165, 51);
            this.btnCancelarIngresar.TabIndex = 83;
            this.btnCancelarIngresar.Text = "CANCELAR";
            this.btnCancelarIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelarIngresar.Textcolor = System.Drawing.Color.White;
            this.btnCancelarIngresar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnCancelarIngresar.Click += new System.EventHandler(this.btnCancelarIngresar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.BorderRadius = 5;
            this.btnEliminar.ButtonText = "DESHABILITAR";
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe MDL2 Assets", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Iconimage")));
            this.btnEliminar.Iconimage_right = null;
            this.btnEliminar.Iconimage_right_Selected = null;
            this.btnEliminar.Iconimage_Selected = null;
            this.btnEliminar.IconMarginLeft = 0;
            this.btnEliminar.IconMarginRight = 0;
            this.btnEliminar.IconRightVisible = true;
            this.btnEliminar.IconRightZoom = 0D;
            this.btnEliminar.IconVisible = false;
            this.btnEliminar.IconZoom = 90D;
            this.btnEliminar.IsTab = false;
            this.btnEliminar.Location = new System.Drawing.Point(864, 292);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btnEliminar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnEliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminar.selected = false;
            this.btnEliminar.Size = new System.Drawing.Size(233, 51);
            this.btnEliminar.TabIndex = 84;
            this.btnEliminar.Text = "DESHABILITAR";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminar.Textcolor = System.Drawing.Color.White;
            this.btnEliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // frmConceptos2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1394, 1055);
            this.Controls.Add(this.lblAyuda);
            this.Controls.Add(this.panelAcciones);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panelBusqueda);
            this.Name = "frmConceptos2";
            this.Text = "GESTION CONCEPTOS";
            this.Load += new System.EventHandler(this.frmConceptos2_Load);
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ConVisualizar)).EndInit();
            this.panelAcciones.ResumeLayout(false);
            this.panelAcciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnBuscar;
        private MetroFramework.Controls.MetroPanel panelBusqueda;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private MetroFramework.Controls.MetroTextBox txtBuscarConcepto;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Panel panelData;
        private MetroFramework.Controls.MetroGrid dgv_ConVisualizar;
        private System.Windows.Forms.Panel panelAcciones;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblMonto;
        private MetroFramework.Controls.MetroDateTime dt_FechaAlta;
        private MetroFramework.Controls.MetroTextBox txtAnio;
        private MetroFramework.Controls.MetroTextBox txtMonto;
        private System.Windows.Forms.Label lblFechaAlta;
        private MetroFramework.Controls.MetroComboBox cbo_Estado;
        private FontAwesome.Sharp.IconButton btnBloqueoEditar;
        private MetroFramework.Controls.MetroTextBox txt_Otros;
        private MetroFramework.Controls.MetroComboBox cbo_Conceptos;
        private System.Windows.Forms.Label lblEditar;
        private System.Windows.Forms.Label lblErrorFecha;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.Label lblControlMonto;
        private System.Windows.Forms.Label lblControlFecha;
        private System.Windows.Forms.Label lblControlAnio;
        private System.Windows.Forms.Label lblControlOtros;
        private System.Windows.Forms.Label lblErrorSemestre;
        private System.Windows.Forms.Label lblErrorAnio;
        private System.Windows.Forms.Label lblDeshabilitar;
        private FontAwesome.Sharp.IconButton btnBloqueoInactivar;
        private System.Windows.Forms.Label lblControlFechaAlta;
        private System.Windows.Forms.Label lblErAnio;
        private MetroFramework.Controls.MetroLabel lblAyuda;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardarEd;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardarIngresar;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelarIngresar;
    }
}