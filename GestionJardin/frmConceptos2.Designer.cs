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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBusqueda = new MetroFramework.Controls.MetroPanel();
            this.lblControlOtros = new System.Windows.Forms.Label();
            this.txtBuscarConcepto = new MetroFramework.Controls.MetroTextBox();
            this.cbo_Conceptos = new MetroFramework.Controls.MetroComboBox();
            this.txt_Otros = new MetroFramework.Controls.MetroTextBox();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.panelData = new System.Windows.Forms.Panel();
            this.dgv_ConVisualizar = new MetroFramework.Controls.MetroGrid();
            this.panelAcciones = new System.Windows.Forms.Panel();
            this.lblErrorAnio = new System.Windows.Forms.Label();
            this.lblErrorSemestre = new System.Windows.Forms.Label();
            this.lblControlSemestre = new System.Windows.Forms.Label();
            this.lblControlFecha = new System.Windows.Forms.Label();
            this.lblControlAnio = new System.Windows.Forms.Label();
            this.lblControlMonto = new System.Windows.Forms.Label();
            this.lblErrorFecha = new System.Windows.Forms.Label();
            this.lblEditar = new System.Windows.Forms.Label();
            this.btnBloqueo = new FontAwesome.Sharp.IconButton();
            this.cbo_Estado = new MetroFramework.Controls.MetroComboBox();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.dt_FechaAlta = new MetroFramework.Controls.MetroDateTime();
            this.cboSemestre = new MetroFramework.Controls.MetroComboBox();
            this.txtAnio = new MetroFramework.Controls.MetroTextBox();
            this.txtMonto = new MetroFramework.Controls.MetroTextBox();
            this.btnCancelarIngresar = new FontAwesome.Sharp.IconButton();
            this.btnGuardarIngresar = new FontAwesome.Sharp.IconButton();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.panelBusqueda.Controls.Add(this.txtBuscarConcepto);
            this.panelBusqueda.Controls.Add(this.cbo_Conceptos);
            this.panelBusqueda.Controls.Add(this.txt_Otros);
            this.panelBusqueda.HorizontalScrollbarBarColor = true;
            this.panelBusqueda.HorizontalScrollbarHighlightOnWheel = false;
            this.panelBusqueda.HorizontalScrollbarSize = 10;
            this.panelBusqueda.Location = new System.Drawing.Point(322, 94);
            this.panelBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(1038, 100);
            this.panelBusqueda.TabIndex = 21;
            this.panelBusqueda.UseCustomBackColor = true;
            this.panelBusqueda.VerticalScrollbarBarColor = true;
            this.panelBusqueda.VerticalScrollbarHighlightOnWheel = false;
            this.panelBusqueda.VerticalScrollbarSize = 11;
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
            this.txtBuscarConcepto.PromptText = "CONCEPTO, AÑO, SEMESTRE";
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
            this.txtBuscarConcepto.WaterMark = "CONCEPTO, AÑO, SEMESTRE";
            this.txtBuscarConcepto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBuscarConcepto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnAgregar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregar.IconColor = System.Drawing.Color.SeaGreen;
            this.btnAgregar.IconSize = 81;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.Location = new System.Drawing.Point(162, 94);
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
            this.btnBuscar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscar.IconSize = 81;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.Location = new System.Drawing.Point(24, 94);
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
            this.lbl_Titulo.Location = new System.Drawing.Point(610, 250);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(247, 52);
            this.lbl_Titulo.TabIndex = 27;
            this.lbl_Titulo.Text = "CONCEPTOS";
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.dgv_ConVisualizar);
            this.panelData.Location = new System.Drawing.Point(98, 353);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ConVisualizar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_ConVisualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ConVisualizar.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_ConVisualizar.EnableHeadersVisualStyles = false;
            this.dgv_ConVisualizar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_ConVisualizar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgv_ConVisualizar.Location = new System.Drawing.Point(8, 12);
            this.dgv_ConVisualizar.Name = "dgv_ConVisualizar";
            this.dgv_ConVisualizar.ReadOnly = true;
            this.dgv_ConVisualizar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ConVisualizar.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_ConVisualizar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_ConVisualizar.RowTemplate.Height = 24;
            this.dgv_ConVisualizar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ConVisualizar.Size = new System.Drawing.Size(1198, 308);
            this.dgv_ConVisualizar.TabIndex = 2;
            // 
            // panelAcciones
            // 
            this.panelAcciones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelAcciones.Controls.Add(this.lblErrorAnio);
            this.panelAcciones.Controls.Add(this.lblErrorSemestre);
            this.panelAcciones.Controls.Add(this.lblControlSemestre);
            this.panelAcciones.Controls.Add(this.lblControlFecha);
            this.panelAcciones.Controls.Add(this.lblControlAnio);
            this.panelAcciones.Controls.Add(this.lblControlMonto);
            this.panelAcciones.Controls.Add(this.lblErrorFecha);
            this.panelAcciones.Controls.Add(this.lblEditar);
            this.panelAcciones.Controls.Add(this.btnBloqueo);
            this.panelAcciones.Controls.Add(this.cbo_Estado);
            this.panelAcciones.Controls.Add(this.lblSemestre);
            this.panelAcciones.Controls.Add(this.lblAnio);
            this.panelAcciones.Controls.Add(this.lblMonto);
            this.panelAcciones.Controls.Add(this.dt_FechaAlta);
            this.panelAcciones.Controls.Add(this.cboSemestre);
            this.panelAcciones.Controls.Add(this.txtAnio);
            this.panelAcciones.Controls.Add(this.txtMonto);
            this.panelAcciones.Controls.Add(this.btnCancelarIngresar);
            this.panelAcciones.Controls.Add(this.btnGuardarIngresar);
            this.panelAcciones.Controls.Add(this.lblFechaAlta);
            this.panelAcciones.Location = new System.Drawing.Point(148, 267);
            this.panelAcciones.Name = "panelAcciones";
            this.panelAcciones.Size = new System.Drawing.Size(1202, 425);
            this.panelAcciones.TabIndex = 28;
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
            // lblControlSemestre
            // 
            this.lblControlSemestre.AutoSize = true;
            this.lblControlSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlSemestre.ForeColor = System.Drawing.Color.Red;
            this.lblControlSemestre.Location = new System.Drawing.Point(1120, 181);
            this.lblControlSemestre.Name = "lblControlSemestre";
            this.lblControlSemestre.Size = new System.Drawing.Size(30, 38);
            this.lblControlSemestre.TabIndex = 72;
            this.lblControlSemestre.Text = "*";
            this.lblControlSemestre.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblControlFecha
            // 
            this.lblControlFecha.AutoSize = true;
            this.lblControlFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlFecha.ForeColor = System.Drawing.Color.Red;
            this.lblControlFecha.Location = new System.Drawing.Point(536, 182);
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
            this.lblControlAnio.Location = new System.Drawing.Point(1070, 74);
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
            this.lblEditar.Font = new System.Drawing.Font("Verdana Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditar.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblEditar.Location = new System.Drawing.Point(134, 375);
            this.lblEditar.Name = "lblEditar";
            this.lblEditar.Size = new System.Drawing.Size(99, 25);
            this.lblEditar.TabIndex = 67;
            this.lblEditar.Text = "EDITAR";
            // 
            // btnBloqueo
            // 
            this.btnBloqueo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBloqueo.ForeColor = System.Drawing.Color.Transparent;
            this.btnBloqueo.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnBloqueo.IconColor = System.Drawing.Color.Goldenrod;
            this.btnBloqueo.IconSize = 60;
            this.btnBloqueo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBloqueo.Location = new System.Drawing.Point(139, 287);
            this.btnBloqueo.Name = "btnBloqueo";
            this.btnBloqueo.Rotation = 0D;
            this.btnBloqueo.Size = new System.Drawing.Size(87, 85);
            this.btnBloqueo.TabIndex = 62;
            this.btnBloqueo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBloqueo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnBloqueo.UseVisualStyleBackColor = true;
            // 
            // cbo_Estado
            // 
            this.cbo_Estado.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cbo_Estado.FormattingEnabled = true;
            this.cbo_Estado.ItemHeight = 29;
            this.cbo_Estado.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cbo_Estado.Location = new System.Drawing.Point(887, 246);
            this.cbo_Estado.Name = "cbo_Estado";
            this.cbo_Estado.PromptText = "ESTADO";
            this.cbo_Estado.Size = new System.Drawing.Size(227, 35);
            this.cbo_Estado.Style = MetroFramework.MetroColorStyle.Green;
            this.cbo_Estado.TabIndex = 64;
            this.cbo_Estado.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbo_Estado.UseSelectable = true;
            this.cbo_Estado.UseStyleColors = true;
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Font = new System.Drawing.Font("Verdana Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemestre.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSemestre.Location = new System.Drawing.Point(643, 181);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(139, 25);
            this.lblSemestre.TabIndex = 62;
            this.lblSemestre.Text = "SEMESTRE:";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Verdana Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAnio.Location = new System.Drawing.Point(712, 74);
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
            this.lblMonto.Location = new System.Drawing.Point(134, 74);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(104, 25);
            this.lblMonto.TabIndex = 60;
            this.lblMonto.Text = "MONTO:";
            // 
            // dt_FechaAlta
            // 
            this.dt_FechaAlta.FontSize = MetroFramework.MetroDateTimeSize.Tall;
            this.dt_FechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_FechaAlta.Location = new System.Drawing.Point(303, 173);
            this.dt_FechaAlta.MinimumSize = new System.Drawing.Size(0, 35);
            this.dt_FechaAlta.Name = "dt_FechaAlta";
            this.dt_FechaAlta.Size = new System.Drawing.Size(227, 35);
            this.dt_FechaAlta.Style = MetroFramework.MetroColorStyle.Green;
            this.dt_FechaAlta.TabIndex = 57;
            this.dt_FechaAlta.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dt_FechaAlta.UseStyleColors = true;
            this.dt_FechaAlta.ValueChanged += new System.EventHandler(this.dt_FechaAlta_ValueChanged);
            // 
            // cboSemestre
            // 
            this.cboSemestre.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cboSemestre.FormattingEnabled = true;
            this.cboSemestre.ItemHeight = 29;
            this.cboSemestre.Location = new System.Drawing.Point(887, 173);
            this.cboSemestre.Name = "cboSemestre";
            this.cboSemestre.PromptText = "SELECCIONE";
            this.cboSemestre.Size = new System.Drawing.Size(227, 35);
            this.cboSemestre.Style = MetroFramework.MetroColorStyle.Green;
            this.cboSemestre.TabIndex = 59;
            this.cboSemestre.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cboSemestre.UseSelectable = true;
            this.cboSemestre.UseStyleColors = true;
            this.cboSemestre.SelectedValueChanged += new System.EventHandler(this.cboSemestre_SelectedValueChanged);
            this.cboSemestre.Validated += new System.EventHandler(this.cboSemestre_Validated);
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
            this.txtAnio.Location = new System.Drawing.Point(887, 66);
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
            // btnCancelarIngresar
            // 
            this.btnCancelarIngresar.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelarIngresar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCancelarIngresar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCancelarIngresar.IconColor = System.Drawing.Color.Black;
            this.btnCancelarIngresar.IconSize = 16;
            this.btnCancelarIngresar.Location = new System.Drawing.Point(682, 315);
            this.btnCancelarIngresar.Name = "btnCancelarIngresar";
            this.btnCancelarIngresar.Rotation = 0D;
            this.btnCancelarIngresar.Size = new System.Drawing.Size(146, 67);
            this.btnCancelarIngresar.TabIndex = 61;
            this.btnCancelarIngresar.Text = "CANCELAR";
            this.btnCancelarIngresar.UseVisualStyleBackColor = false;
            this.btnCancelarIngresar.Click += new System.EventHandler(this.btnCancelarIngresar_Click);
            // 
            // btnGuardarIngresar
            // 
            this.btnGuardarIngresar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuardarIngresar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGuardarIngresar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarIngresar.IconColor = System.Drawing.Color.Black;
            this.btnGuardarIngresar.IconSize = 40;
            this.btnGuardarIngresar.Location = new System.Drawing.Point(435, 315);
            this.btnGuardarIngresar.Name = "btnGuardarIngresar";
            this.btnGuardarIngresar.Padding = new System.Windows.Forms.Padding(5);
            this.btnGuardarIngresar.Rotation = 0D;
            this.btnGuardarIngresar.Size = new System.Drawing.Size(179, 67);
            this.btnGuardarIngresar.TabIndex = 60;
            this.btnGuardarIngresar.Text = "GUARDAR";
            this.btnGuardarIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarIngresar.UseVisualStyleBackColor = false;
            this.btnGuardarIngresar.Click += new System.EventHandler(this.btnGuardarIngresar_Click);
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Font = new System.Drawing.Font("Verdana Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAlta.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblFechaAlta.Location = new System.Drawing.Point(81, 183);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(157, 25);
            this.lblFechaAlta.TabIndex = 53;
            this.lblFechaAlta.Text = "FECHA ALTA:";
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // frmConceptos2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 943);
            this.Controls.Add(this.panelAcciones);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panelBusqueda);
            this.Controls.Add(this.btnBuscar);
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
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblMonto;
        private MetroFramework.Controls.MetroDateTime dt_FechaAlta;
        private MetroFramework.Controls.MetroComboBox cboSemestre;
        private MetroFramework.Controls.MetroTextBox txtAnio;
        private MetroFramework.Controls.MetroTextBox txtMonto;
        private FontAwesome.Sharp.IconButton btnCancelarIngresar;
        private FontAwesome.Sharp.IconButton btnGuardarIngresar;
        private System.Windows.Forms.Label lblFechaAlta;
        private MetroFramework.Controls.MetroComboBox cbo_Estado;
        private FontAwesome.Sharp.IconButton btnBloqueo;
        private MetroFramework.Controls.MetroTextBox txt_Otros;
        private MetroFramework.Controls.MetroComboBox cbo_Conceptos;
        private System.Windows.Forms.Label lblEditar;
        private System.Windows.Forms.Label lblErrorFecha;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.Label lblControlMonto;
        private System.Windows.Forms.Label lblControlSemestre;
        private System.Windows.Forms.Label lblControlFecha;
        private System.Windows.Forms.Label lblControlAnio;
        private System.Windows.Forms.Label lblControlOtros;
        private System.Windows.Forms.Label lblErrorSemestre;
        private System.Windows.Forms.Label lblErrorAnio;
    }
}