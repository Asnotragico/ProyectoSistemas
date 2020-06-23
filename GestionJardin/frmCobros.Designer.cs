namespace GestionJardin
{
    partial class frmCobros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCobros));
            this.lblAyuda = new MetroFramework.Controls.MetroLabel();
            this.panelBusqueda = new MetroFramework.Controls.MetroPanel();
            this.btnBuscaDatosForm = new System.Windows.Forms.Button();
            this.btnIngresaDatosForm = new System.Windows.Forms.Button();
            this.txtBuscarCobro = new MetroFramework.Controls.MetroTextBox();
            this.panlBtnAnular = new MetroFramework.Controls.MetroPanel();
            this.btnEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelBotones = new MetroFramework.Controls.MetroPanel();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLimpiar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelCobro = new MetroFramework.Controls.MetroPanel();
            this.cboMediodepago = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dtCobro = new MetroFramework.Controls.MetroDateTime();
            this.txtImporte = new MetroFramework.Controls.MetroTextBox();
            this.lblDatosContacto = new MetroFramework.Controls.MetroLabel();
            this.panelDatos = new MetroFramework.Controls.MetroPanel();
            this.cboCuotas = new MetroFramework.Controls.MetroComboBox();
            this.txtLegajo = new MetroFramework.Controls.MetroTextBox();
            this.txtDocumento = new MetroFramework.Controls.MetroTextBox();
            this.txtNombreyApellido = new MetroFramework.Controls.MetroTextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.panelBusqueda.SuspendLayout();
            this.panlBtnAnular.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.panelCobro.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.panelDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAyuda.Location = new System.Drawing.Point(13, 22);
            this.lblAyuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(210, 20);
            this.lblAyuda.TabIndex = 35;
            this.lblAyuda.Text = "Buscar o Agregar un COBRO.";
            this.lblAyuda.UseCustomBackColor = true;
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panelBusqueda.Controls.Add(this.btnBuscaDatosForm);
            this.panelBusqueda.Controls.Add(this.btnIngresaDatosForm);
            this.panelBusqueda.Controls.Add(this.txtBuscarCobro);
            this.panelBusqueda.HorizontalScrollbarBarColor = true;
            this.panelBusqueda.HorizontalScrollbarHighlightOnWheel = false;
            this.panelBusqueda.HorizontalScrollbarSize = 12;
            this.panelBusqueda.Location = new System.Drawing.Point(549, 78);
            this.panelBusqueda.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(831, 123);
            this.panelBusqueda.TabIndex = 34;
            this.panelBusqueda.UseCustomBackColor = true;
            this.panelBusqueda.VerticalScrollbarBarColor = true;
            this.panelBusqueda.VerticalScrollbarHighlightOnWheel = false;
            this.panelBusqueda.VerticalScrollbarSize = 15;
            // 
            // btnBuscaDatosForm
            // 
            this.btnBuscaDatosForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaDatosForm.Location = new System.Drawing.Point(684, 73);
            this.btnBuscaDatosForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscaDatosForm.Name = "btnBuscaDatosForm";
            this.btnBuscaDatosForm.Size = new System.Drawing.Size(100, 28);
            this.btnBuscaDatosForm.TabIndex = 44;
            this.btnBuscaDatosForm.Text = "Buscar";
            this.btnBuscaDatosForm.UseVisualStyleBackColor = true;
            this.btnBuscaDatosForm.Click += new System.EventHandler(this.btnBuscaDatosForm_Click_1);
            // 
            // btnIngresaDatosForm
            // 
            this.btnIngresaDatosForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresaDatosForm.Location = new System.Drawing.Point(684, 32);
            this.btnIngresaDatosForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresaDatosForm.Name = "btnIngresaDatosForm";
            this.btnIngresaDatosForm.Size = new System.Drawing.Size(100, 28);
            this.btnIngresaDatosForm.TabIndex = 43;
            this.btnIngresaDatosForm.Text = "Ingresar";
            this.btnIngresaDatosForm.UseVisualStyleBackColor = true;
            this.btnIngresaDatosForm.Click += new System.EventHandler(this.btnIngresaDatosForm_Click_1);
            // 
            // txtBuscarCobro
            // 
            this.txtBuscarCobro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBuscarCobro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBuscarCobro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtBuscarCobro.CustomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBuscarCobro.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtBuscarCobro.CustomButton.Location = new System.Drawing.Point(549, 1);
            this.txtBuscarCobro.CustomButton.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtBuscarCobro.CustomButton.Name = "";
            this.txtBuscarCobro.CustomButton.Size = new System.Drawing.Size(51, 51);
            this.txtBuscarCobro.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtBuscarCobro.CustomButton.TabIndex = 1;
            this.txtBuscarCobro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBuscarCobro.CustomButton.UseSelectable = true;
            this.txtBuscarCobro.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBuscarCobro.Lines = new string[0];
            this.txtBuscarCobro.Location = new System.Drawing.Point(64, 32);
            this.txtBuscarCobro.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtBuscarCobro.MaxLength = 32767;
            this.txtBuscarCobro.Name = "txtBuscarCobro";
            this.txtBuscarCobro.PasswordChar = '\0';
            this.txtBuscarCobro.PromptText = "Nombre";
            this.txtBuscarCobro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscarCobro.SelectedText = "";
            this.txtBuscarCobro.SelectionLength = 0;
            this.txtBuscarCobro.SelectionStart = 0;
            this.txtBuscarCobro.ShortcutsEnabled = true;
            this.txtBuscarCobro.ShowButton = true;
            this.txtBuscarCobro.ShowClearButton = true;
            this.txtBuscarCobro.Size = new System.Drawing.Size(601, 53);
            this.txtBuscarCobro.TabIndex = 10;
            this.txtBuscarCobro.UseSelectable = true;
            this.txtBuscarCobro.UseStyleColors = true;
            this.txtBuscarCobro.WaterMark = "Nombre";
            this.txtBuscarCobro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBuscarCobro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCobro.Click += new System.EventHandler(this.txtBuscarCobro_Click_1);
            // 
            // panlBtnAnular
            // 
            this.panlBtnAnular.Controls.Add(this.btnEditar);
            this.panlBtnAnular.HorizontalScrollbarBarColor = true;
            this.panlBtnAnular.HorizontalScrollbarHighlightOnWheel = false;
            this.panlBtnAnular.HorizontalScrollbarSize = 12;
            this.panlBtnAnular.Location = new System.Drawing.Point(13, 647);
            this.panlBtnAnular.Margin = new System.Windows.Forms.Padding(4);
            this.panlBtnAnular.Name = "panlBtnAnular";
            this.panlBtnAnular.Size = new System.Drawing.Size(508, 142);
            this.panlBtnAnular.TabIndex = 39;
            this.panlBtnAnular.UseCustomBackColor = true;
            this.panlBtnAnular.VerticalScrollbarBarColor = true;
            this.panlBtnAnular.VerticalScrollbarHighlightOnWheel = false;
            this.panlBtnAnular.VerticalScrollbarSize = 13;
            // 
            // btnEditar
            // 
            this.btnEditar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.BorderRadius = 5;
            this.btnEditar.ButtonText = "ANULAR";
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditar.Font = new System.Drawing.Font("Segoe MDL2 Assets", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditar.Iconimage")));
            this.btnEditar.Iconimage_right = null;
            this.btnEditar.Iconimage_right_Selected = null;
            this.btnEditar.Iconimage_Selected = null;
            this.btnEditar.IconMarginLeft = 0;
            this.btnEditar.IconMarginRight = 0;
            this.btnEditar.IconRightVisible = true;
            this.btnEditar.IconRightZoom = 0D;
            this.btnEditar.IconVisible = false;
            this.btnEditar.IconZoom = 90D;
            this.btnEditar.IsTab = false;
            this.btnEditar.Location = new System.Drawing.Point(68, 36);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnEditar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnEditar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditar.selected = false;
            this.btnEditar.Size = new System.Drawing.Size(165, 51);
            this.btnEditar.TabIndex = 26;
            this.btnEditar.Text = "ANULAR";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditar.Textcolor = System.Drawing.Color.White;
            this.btnEditar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.btnGuardar);
            this.panelBotones.Controls.Add(this.btnLimpiar);
            this.panelBotones.HorizontalScrollbarBarColor = true;
            this.panelBotones.HorizontalScrollbarHighlightOnWheel = false;
            this.panelBotones.HorizontalScrollbarSize = 12;
            this.panelBotones.Location = new System.Drawing.Point(549, 647);
            this.panelBotones.Margin = new System.Windows.Forms.Padding(4);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(831, 142);
            this.panelBotones.TabIndex = 38;
            this.panelBotones.UseCustomBackColor = true;
            this.panelBotones.VerticalScrollbarBarColor = true;
            this.panelBotones.VerticalScrollbarHighlightOnWheel = false;
            this.panelBotones.VerticalScrollbarSize = 13;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.BorderRadius = 5;
            this.btnGuardar.ButtonText = "GUARDAR";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe MDL2 Assets", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Iconimage")));
            this.btnGuardar.Iconimage_right = null;
            this.btnGuardar.Iconimage_right_Selected = null;
            this.btnGuardar.Iconimage_Selected = null;
            this.btnGuardar.IconMarginLeft = 0;
            this.btnGuardar.IconMarginRight = 0;
            this.btnGuardar.IconRightVisible = true;
            this.btnGuardar.IconRightZoom = 0D;
            this.btnGuardar.IconVisible = false;
            this.btnGuardar.IconZoom = 90D;
            this.btnGuardar.IsTab = false;
            this.btnGuardar.Location = new System.Drawing.Point(477, 36);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(165, 51);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Textcolor = System.Drawing.Color.White;
            this.btnGuardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.BorderRadius = 5;
            this.btnLimpiar.ButtonText = "CANCELAR";
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.DisabledColor = System.Drawing.Color.Gray;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe MDL2 Assets", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLimpiar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Iconimage")));
            this.btnLimpiar.Iconimage_right = null;
            this.btnLimpiar.Iconimage_right_Selected = null;
            this.btnLimpiar.Iconimage_Selected = null;
            this.btnLimpiar.IconMarginLeft = 0;
            this.btnLimpiar.IconMarginRight = 0;
            this.btnLimpiar.IconRightVisible = true;
            this.btnLimpiar.IconRightZoom = 0D;
            this.btnLimpiar.IconVisible = false;
            this.btnLimpiar.IconZoom = 90D;
            this.btnLimpiar.IsTab = false;
            this.btnLimpiar.Location = new System.Drawing.Point(159, 36);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimpiar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.btnLimpiar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLimpiar.selected = false;
            this.btnLimpiar.Size = new System.Drawing.Size(165, 51);
            this.btnLimpiar.TabIndex = 25;
            this.btnLimpiar.Text = "CANCELAR";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimpiar.Textcolor = System.Drawing.Color.White;
            this.btnLimpiar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // panelCobro
            // 
            this.panelCobro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panelCobro.Controls.Add(this.cboMediodepago);
            this.panelCobro.Controls.Add(this.metroPanel2);
            this.panelCobro.Controls.Add(this.txtImporte);
            this.panelCobro.Controls.Add(this.lblDatosContacto);
            this.panelCobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCobro.HorizontalScrollbarBarColor = true;
            this.panelCobro.HorizontalScrollbarHighlightOnWheel = false;
            this.panelCobro.HorizontalScrollbarSize = 12;
            this.panelCobro.Location = new System.Drawing.Point(549, 209);
            this.panelCobro.Margin = new System.Windows.Forms.Padding(4);
            this.panelCobro.Name = "panelCobro";
            this.panelCobro.Size = new System.Drawing.Size(831, 414);
            this.panelCobro.TabIndex = 37;
            this.panelCobro.UseCustomBackColor = true;
            this.panelCobro.VerticalScrollbarBarColor = true;
            this.panelCobro.VerticalScrollbarHighlightOnWheel = false;
            this.panelCobro.VerticalScrollbarSize = 13;
            // 
            // cboMediodepago
            // 
            this.cboMediodepago.FormattingEnabled = true;
            this.cboMediodepago.ItemHeight = 24;
            this.cboMediodepago.Items.AddRange(new object[] {
            "EFECTIVO"});
            this.cboMediodepago.Location = new System.Drawing.Point(59, 246);
            this.cboMediodepago.Margin = new System.Windows.Forms.Padding(4);
            this.cboMediodepago.Name = "cboMediodepago";
            this.cboMediodepago.PromptText = "Medio de pago";
            this.cboMediodepago.Size = new System.Drawing.Size(353, 30);
            this.cboMediodepago.TabIndex = 29;
            this.cboMediodepago.UseSelectable = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.dtCobro);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 12;
            this.metroPanel2.Location = new System.Drawing.Point(59, 85);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(383, 62);
            this.metroPanel2.TabIndex = 22;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 13;
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel3.Location = new System.Drawing.Point(13, 12);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(172, 37);
            this.metroLabel3.TabIndex = 21;
            this.metroLabel3.Text = "Fecha de cobro";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // dtCobro
            // 
            this.dtCobro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCobro.Location = new System.Drawing.Point(180, 12);
            this.dtCobro.Margin = new System.Windows.Forms.Padding(4);
            this.dtCobro.MaxDate = new System.DateTime(2100, 6, 22, 0, 0, 0, 0);
            this.dtCobro.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.dtCobro.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtCobro.Name = "dtCobro";
            this.dtCobro.Size = new System.Drawing.Size(173, 30);
            this.dtCobro.TabIndex = 20;
            this.dtCobro.Value = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            // 
            // txtImporte
            // 
            this.txtImporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtImporte.CustomButton.Image = null;
            this.txtImporte.CustomButton.Location = new System.Drawing.Point(317, 1);
            this.txtImporte.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtImporte.CustomButton.Name = "";
            this.txtImporte.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.txtImporte.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtImporte.CustomButton.TabIndex = 1;
            this.txtImporte.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtImporte.CustomButton.UseSelectable = true;
            this.txtImporte.CustomButton.Visible = false;
            this.txtImporte.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtImporte.Lines = new string[0];
            this.txtImporte.Location = new System.Drawing.Point(59, 176);
            this.txtImporte.Margin = new System.Windows.Forms.Padding(4);
            this.txtImporte.MaxLength = 32767;
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.PasswordChar = '\0';
            this.txtImporte.PromptText = "Importe";
            this.txtImporte.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtImporte.SelectedText = "";
            this.txtImporte.SelectionLength = 0;
            this.txtImporte.SelectionStart = 0;
            this.txtImporte.ShortcutsEnabled = true;
            this.txtImporte.Size = new System.Drawing.Size(355, 39);
            this.txtImporte.TabIndex = 28;
            this.txtImporte.UseSelectable = true;
            this.txtImporte.WaterMark = "Importe";
            this.txtImporte.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtImporte.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblDatosContacto
            // 
            this.lblDatosContacto.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDatosContacto.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDatosContacto.Location = new System.Drawing.Point(59, 31);
            this.lblDatosContacto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatosContacto.Name = "lblDatosContacto";
            this.lblDatosContacto.Size = new System.Drawing.Size(339, 34);
            this.lblDatosContacto.TabIndex = 21;
            this.lblDatosContacto.Text = "Registro del cobro";
            this.lblDatosContacto.UseCustomBackColor = true;
            // 
            // panelDatos
            // 
            this.panelDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panelDatos.Controls.Add(this.cboCuotas);
            this.panelDatos.Controls.Add(this.txtLegajo);
            this.panelDatos.Controls.Add(this.txtDocumento);
            this.panelDatos.Controls.Add(this.txtNombreyApellido);
            this.panelDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDatos.HorizontalScrollbarBarColor = true;
            this.panelDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.panelDatos.HorizontalScrollbarSize = 12;
            this.panelDatos.Location = new System.Drawing.Point(13, 209);
            this.panelDatos.Margin = new System.Windows.Forms.Padding(4);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(508, 414);
            this.panelDatos.TabIndex = 36;
            this.panelDatos.UseCustomBackColor = true;
            this.panelDatos.VerticalScrollbarBarColor = true;
            this.panelDatos.VerticalScrollbarHighlightOnWheel = false;
            this.panelDatos.VerticalScrollbarSize = 13;
            // 
            // cboCuotas
            // 
            this.cboCuotas.FormattingEnabled = true;
            this.cboCuotas.ItemHeight = 24;
            this.cboCuotas.Location = new System.Drawing.Point(68, 288);
            this.cboCuotas.Margin = new System.Windows.Forms.Padding(4);
            this.cboCuotas.Name = "cboCuotas";
            this.cboCuotas.PromptText = "Cuotas - Vencimiento";
            this.cboCuotas.Size = new System.Drawing.Size(353, 30);
            this.cboCuotas.TabIndex = 30;
            this.cboCuotas.UseSelectable = true;
            this.cboCuotas.SelectionChangeCommitted += new System.EventHandler(this.cboCuotas_SelectionChangeCommitted_1);
            // 
            // txtLegajo
            // 
            this.txtLegajo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtLegajo.CustomButton.Image = null;
            this.txtLegajo.CustomButton.Location = new System.Drawing.Point(317, 1);
            this.txtLegajo.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtLegajo.CustomButton.Name = "";
            this.txtLegajo.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.txtLegajo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLegajo.CustomButton.TabIndex = 1;
            this.txtLegajo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLegajo.CustomButton.UseSelectable = true;
            this.txtLegajo.CustomButton.Visible = false;
            this.txtLegajo.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtLegajo.Lines = new string[0];
            this.txtLegajo.Location = new System.Drawing.Point(68, 198);
            this.txtLegajo.Margin = new System.Windows.Forms.Padding(4);
            this.txtLegajo.MaxLength = 32767;
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.PasswordChar = '\0';
            this.txtLegajo.PromptText = "Legajo";
            this.txtLegajo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLegajo.SelectedText = "";
            this.txtLegajo.SelectionLength = 0;
            this.txtLegajo.SelectionStart = 0;
            this.txtLegajo.ShortcutsEnabled = true;
            this.txtLegajo.Size = new System.Drawing.Size(355, 39);
            this.txtLegajo.TabIndex = 5;
            this.txtLegajo.UseSelectable = true;
            this.txtLegajo.WaterMark = "Legajo";
            this.txtLegajo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLegajo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtDocumento
            // 
            this.txtDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtDocumento.CustomButton.Image = null;
            this.txtDocumento.CustomButton.Location = new System.Drawing.Point(317, 1);
            this.txtDocumento.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocumento.CustomButton.Name = "";
            this.txtDocumento.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.txtDocumento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDocumento.CustomButton.TabIndex = 1;
            this.txtDocumento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDocumento.CustomButton.UseSelectable = true;
            this.txtDocumento.CustomButton.Visible = false;
            this.txtDocumento.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtDocumento.Lines = new string[0];
            this.txtDocumento.Location = new System.Drawing.Point(68, 107);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocumento.MaxLength = 32767;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.PasswordChar = '\0';
            this.txtDocumento.PromptText = "Documento Ej: 30123456";
            this.txtDocumento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDocumento.SelectedText = "";
            this.txtDocumento.SelectionLength = 0;
            this.txtDocumento.SelectionStart = 0;
            this.txtDocumento.ShortcutsEnabled = true;
            this.txtDocumento.Size = new System.Drawing.Size(355, 39);
            this.txtDocumento.TabIndex = 4;
            this.txtDocumento.UseSelectable = true;
            this.txtDocumento.WaterMark = "Documento Ej: 30123456";
            this.txtDocumento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDocumento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtNombreyApellido
            // 
            this.txtNombreyApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtNombreyApellido.CustomButton.Image = null;
            this.txtNombreyApellido.CustomButton.Location = new System.Drawing.Point(317, 1);
            this.txtNombreyApellido.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreyApellido.CustomButton.Name = "";
            this.txtNombreyApellido.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.txtNombreyApellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreyApellido.CustomButton.TabIndex = 1;
            this.txtNombreyApellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreyApellido.CustomButton.UseSelectable = true;
            this.txtNombreyApellido.CustomButton.Visible = false;
            this.txtNombreyApellido.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNombreyApellido.Lines = new string[0];
            this.txtNombreyApellido.Location = new System.Drawing.Point(68, 31);
            this.txtNombreyApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreyApellido.MaxLength = 32767;
            this.txtNombreyApellido.Name = "txtNombreyApellido";
            this.txtNombreyApellido.PasswordChar = '\0';
            this.txtNombreyApellido.PromptText = "Alumno";
            this.txtNombreyApellido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreyApellido.SelectedText = "";
            this.txtNombreyApellido.SelectionLength = 0;
            this.txtNombreyApellido.SelectionStart = 0;
            this.txtNombreyApellido.ShortcutsEnabled = true;
            this.txtNombreyApellido.Size = new System.Drawing.Size(355, 39);
            this.txtNombreyApellido.TabIndex = 3;
            this.txtNombreyApellido.UseSelectable = true;
            this.txtNombreyApellido.WaterMark = "Alumno";
            this.txtNombreyApellido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreyApellido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // iconButton1
            // 
            this.iconButton1.AutoSize = true;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.RoyalBlue;
            this.iconButton1.IconSize = 81;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.Location = new System.Drawing.Point(33, 78);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(100, 100);
            this.iconButton1.TabIndex = 41;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregar.IconColor = System.Drawing.Color.SeaGreen;
            this.btnAgregar.IconSize = 81;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.Location = new System.Drawing.Point(156, 79);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Rotation = 0D;
            this.btnAgregar.Size = new System.Drawing.Size(100, 100);
            this.btnAgregar.TabIndex = 42;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // frmCobros
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1411, 826);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.lblAyuda);
            this.Controls.Add(this.panelBusqueda);
            this.Controls.Add(this.panlBtnAnular);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panelCobro);
            this.Controls.Add(this.panelDatos);
            this.Name = "frmCobros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "GESTIÓN COBROS";
            this.Load += new System.EventHandler(this.frmCobros_Load_1);
            this.panelBusqueda.ResumeLayout(false);
            this.panlBtnAnular.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            this.panelCobro.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.panelDatos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblAyuda;
        private MetroFramework.Controls.MetroPanel panelBusqueda;
        private MetroFramework.Controls.MetroTextBox txtBuscarCobro;
        private MetroFramework.Controls.MetroPanel panlBtnAnular;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditar;
        private MetroFramework.Controls.MetroPanel panelBotones;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
        private Bunifu.Framework.UI.BunifuFlatButton btnLimpiar;
        private MetroFramework.Controls.MetroPanel panelCobro;
        private MetroFramework.Controls.MetroComboBox cboMediodepago;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime dtCobro;
        private MetroFramework.Controls.MetroTextBox txtImporte;
        private MetroFramework.Controls.MetroLabel lblDatosContacto;
        private MetroFramework.Controls.MetroPanel panelDatos;
        private MetroFramework.Controls.MetroComboBox cboCuotas;
        private MetroFramework.Controls.MetroTextBox txtLegajo;
        private MetroFramework.Controls.MetroTextBox txtDocumento;
        private MetroFramework.Controls.MetroTextBox txtNombreyApellido;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.Button btnBuscaDatosForm;
        private System.Windows.Forms.Button btnIngresaDatosForm;
    }
}