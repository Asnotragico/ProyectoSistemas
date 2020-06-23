namespace GestionJardin
{
    partial class frmGestionCuotas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionCuotas));
            this.btnMasivo = new MetroFramework.Controls.MetroTile();
            this.btnParticular = new MetroFramework.Controls.MetroTile();
            this.btnGenerar = new MetroFramework.Controls.MetroButton();
            this.cbSalas = new MetroFramework.Controls.MetroComboBox();
            this.dgvMatriculados = new MetroFramework.Controls.MetroGrid();
            this.panelGeneracion = new MetroFramework.Controls.MetroPanel();
            this.btnBajaCuota = new MetroFramework.Controls.MetroButton();
            this.cbPeriodo = new MetroFramework.Controls.MetroComboBox();
            this.cbAnoEjercicio = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.listConceptos = new System.Windows.Forms.ListView();
            this.txtMatriculados = new MetroFramework.Controls.MetroTextBox();
            this.panelBusqueda = new MetroFramework.Controls.MetroPanel();
            this.lblAyuda = new MetroFramework.Controls.MetroLabel();
            this.lblBajaCuota = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculados)).BeginInit();
            this.panelGeneracion.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMasivo
            // 
            this.btnMasivo.ActiveControl = null;
            this.btnMasivo.BackColor = System.Drawing.Color.SandyBrown;
            this.btnMasivo.Location = new System.Drawing.Point(61, 126);
            this.btnMasivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMasivo.Name = "btnMasivo";
            this.btnMasivo.Size = new System.Drawing.Size(121, 112);
            this.btnMasivo.TabIndex = 0;
            this.btnMasivo.Text = "Masivo";
            this.btnMasivo.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnMasivo.UseSelectable = true;
            this.btnMasivo.UseStyleColors = true;
            this.btnMasivo.Click += new System.EventHandler(this.btnMasivo_Click);
            // 
            // btnParticular
            // 
            this.btnParticular.ActiveControl = null;
            this.btnParticular.BackColor = System.Drawing.Color.SandyBrown;
            this.btnParticular.Location = new System.Drawing.Point(188, 126);
            this.btnParticular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnParticular.Name = "btnParticular";
            this.btnParticular.Size = new System.Drawing.Size(121, 112);
            this.btnParticular.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnParticular.TabIndex = 1;
            this.btnParticular.Text = "Particular";
            this.btnParticular.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnParticular.UseSelectable = true;
            this.btnParticular.UseStyleColors = true;
            this.btnParticular.Click += new System.EventHandler(this.btnParticular_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(217)))));
            this.btnGenerar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnGenerar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnGenerar.Location = new System.Drawing.Point(528, 270);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(201, 44);
            this.btnGenerar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnGenerar.TabIndex = 7;
            this.btnGenerar.Text = "GENERAR";
            this.btnGenerar.UseCustomBackColor = true;
            this.btnGenerar.UseCustomForeColor = true;
            this.btnGenerar.UseSelectable = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // cbSalas
            // 
            this.cbSalas.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cbSalas.FormattingEnabled = true;
            this.cbSalas.ItemHeight = 29;
            this.cbSalas.Location = new System.Drawing.Point(33, 209);
            this.cbSalas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSalas.Name = "cbSalas";
            this.cbSalas.PromptText = "Sala";
            this.cbSalas.Size = new System.Drawing.Size(253, 35);
            this.cbSalas.TabIndex = 8;
            this.cbSalas.UseSelectable = true;
            this.cbSalas.SelectedValueChanged += new System.EventHandler(this.cbSalas_SelectedValueChanged);
            // 
            // dgvMatriculados
            // 
            this.dgvMatriculados.AllowUserToAddRows = false;
            this.dgvMatriculados.AllowUserToDeleteRows = false;
            this.dgvMatriculados.AllowUserToOrderColumns = true;
            this.dgvMatriculados.AllowUserToResizeRows = false;
            this.dgvMatriculados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvMatriculados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMatriculados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMatriculados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatriculados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMatriculados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatriculados.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMatriculados.EnableHeadersVisualStyles = false;
            this.dgvMatriculados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvMatriculados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvMatriculados.Location = new System.Drawing.Point(33, 332);
            this.dgvMatriculados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMatriculados.Name = "dgvMatriculados";
            this.dgvMatriculados.ReadOnly = true;
            this.dgvMatriculados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatriculados.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMatriculados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMatriculados.RowTemplate.Height = 24;
            this.dgvMatriculados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatriculados.Size = new System.Drawing.Size(696, 150);
            this.dgvMatriculados.Style = MetroFramework.MetroColorStyle.Yellow;
            this.dgvMatriculados.TabIndex = 9;
            this.dgvMatriculados.UseStyleColors = true;
            this.dgvMatriculados.SelectionChanged += new System.EventHandler(this.dgvMatriculados_SelectionChanged);
            // 
            // panelGeneracion
            // 
            this.panelGeneracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panelGeneracion.Controls.Add(this.lblBajaCuota);
            this.panelGeneracion.Controls.Add(this.btnBajaCuota);
            this.panelGeneracion.Controls.Add(this.cbPeriodo);
            this.panelGeneracion.Controls.Add(this.cbAnoEjercicio);
            this.panelGeneracion.Controls.Add(this.metroLabel1);
            this.panelGeneracion.Controls.Add(this.listConceptos);
            this.panelGeneracion.Controls.Add(this.dgvMatriculados);
            this.panelGeneracion.Controls.Add(this.cbSalas);
            this.panelGeneracion.Controls.Add(this.btnGenerar);
            this.panelGeneracion.HorizontalScrollbar = true;
            this.panelGeneracion.HorizontalScrollbarBarColor = true;
            this.panelGeneracion.HorizontalScrollbarHighlightOnWheel = false;
            this.panelGeneracion.HorizontalScrollbarSize = 10;
            this.panelGeneracion.Location = new System.Drawing.Point(61, 254);
            this.panelGeneracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelGeneracion.Name = "panelGeneracion";
            this.panelGeneracion.Size = new System.Drawing.Size(755, 555);
            this.panelGeneracion.Style = MetroFramework.MetroColorStyle.Blue;
            this.panelGeneracion.TabIndex = 12;
            this.panelGeneracion.UseCustomBackColor = true;
            this.panelGeneracion.VerticalScrollbarBarColor = true;
            this.panelGeneracion.VerticalScrollbarHighlightOnWheel = false;
            this.panelGeneracion.VerticalScrollbarSize = 11;
            // 
            // btnBajaCuota
            // 
            this.btnBajaCuota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnBajaCuota.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnBajaCuota.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBajaCuota.Location = new System.Drawing.Point(527, 498);
            this.btnBajaCuota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBajaCuota.Name = "btnBajaCuota";
            this.btnBajaCuota.Size = new System.Drawing.Size(201, 44);
            this.btnBajaCuota.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnBajaCuota.TabIndex = 18;
            this.btnBajaCuota.Text = "BAJA DE CUOTA";
            this.btnBajaCuota.UseCustomBackColor = true;
            this.btnBajaCuota.UseCustomForeColor = true;
            this.btnBajaCuota.UseSelectable = true;
            this.btnBajaCuota.Click += new System.EventHandler(this.btnBajaCuota_Click);
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cbPeriodo.FormattingEnabled = true;
            this.cbPeriodo.ItemHeight = 29;
            this.cbPeriodo.Items.AddRange(new object[] {
            "MATRICULA",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10"});
            this.cbPeriodo.Location = new System.Drawing.Point(33, 62);
            this.cbPeriodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.PromptText = "Periodo";
            this.cbPeriodo.Size = new System.Drawing.Size(253, 35);
            this.cbPeriodo.TabIndex = 17;
            this.cbPeriodo.UseSelectable = true;
            // 
            // cbAnoEjercicio
            // 
            this.cbAnoEjercicio.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cbAnoEjercicio.FormattingEnabled = true;
            this.cbAnoEjercicio.ItemHeight = 29;
            this.cbAnoEjercicio.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021"});
            this.cbAnoEjercicio.Location = new System.Drawing.Point(33, 135);
            this.cbAnoEjercicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAnoEjercicio.Name = "cbAnoEjercicio";
            this.cbAnoEjercicio.PromptText = "Año";
            this.cbAnoEjercicio.Size = new System.Drawing.Size(253, 35);
            this.cbAnoEjercicio.TabIndex = 16;
            this.cbAnoEjercicio.UseSelectable = true;
            this.cbAnoEjercicio.SelectedValueChanged += new System.EventHandler(this.cbAnoEjercicio_SelectedValueChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(4, 1);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(161, 25);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Datos de la Cuota";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // listConceptos
            // 
            this.listConceptos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listConceptos.HideSelection = false;
            this.listConceptos.Location = new System.Drawing.Point(383, 62);
            this.listConceptos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listConceptos.Name = "listConceptos";
            this.listConceptos.Size = new System.Drawing.Size(345, 191);
            this.listConceptos.TabIndex = 10;
            this.listConceptos.UseCompatibleStateImageBehavior = false;
            this.listConceptos.View = System.Windows.Forms.View.Details;
            // 
            // txtMatriculados
            // 
            // 
            // 
            // 
            this.txtMatriculados.CustomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMatriculados.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtMatriculados.CustomButton.Location = new System.Drawing.Point(415, 1);
            this.txtMatriculados.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatriculados.CustomButton.Name = "";
            this.txtMatriculados.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtMatriculados.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtMatriculados.CustomButton.TabIndex = 1;
            this.txtMatriculados.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMatriculados.CustomButton.UseSelectable = true;
            this.txtMatriculados.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtMatriculados.Lines = new string[0];
            this.txtMatriculados.Location = new System.Drawing.Point(19, 37);
            this.txtMatriculados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatriculados.MaxLength = 32767;
            this.txtMatriculados.Name = "txtMatriculados";
            this.txtMatriculados.PasswordChar = '\0';
            this.txtMatriculados.PromptText = "Matriculado";
            this.txtMatriculados.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMatriculados.SelectedText = "";
            this.txtMatriculados.SelectionLength = 0;
            this.txtMatriculados.SelectionStart = 0;
            this.txtMatriculados.ShortcutsEnabled = true;
            this.txtMatriculados.ShowButton = true;
            this.txtMatriculados.ShowClearButton = true;
            this.txtMatriculados.Size = new System.Drawing.Size(451, 37);
            this.txtMatriculados.TabIndex = 10;
            this.txtMatriculados.UseSelectable = true;
            this.txtMatriculados.UseStyleColors = true;
            this.txtMatriculados.WaterMark = "Matriculado";
            this.txtMatriculados.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMatriculados.WaterMarkFont = new System.Drawing.Font("Segoe UI", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatriculados.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtMatriculados_ButtonClick);
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panelBusqueda.Controls.Add(this.txtMatriculados);
            this.panelBusqueda.HorizontalScrollbarBarColor = true;
            this.panelBusqueda.HorizontalScrollbarHighlightOnWheel = false;
            this.panelBusqueda.HorizontalScrollbarSize = 10;
            this.panelBusqueda.Location = new System.Drawing.Point(328, 126);
            this.panelBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(488, 112);
            this.panelBusqueda.TabIndex = 13;
            this.panelBusqueda.UseCustomBackColor = true;
            this.panelBusqueda.VerticalScrollbarBarColor = true;
            this.panelBusqueda.VerticalScrollbarHighlightOnWheel = false;
            this.panelBusqueda.VerticalScrollbarSize = 11;
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAyuda.Location = new System.Drawing.Point(61, 84);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(424, 20);
            this.lblAyuda.TabIndex = 14;
            this.lblAyuda.Text = "Elegir la modalidad de generar la cuota. (Masivo/Particular)";
            this.lblAyuda.UseCustomBackColor = true;
            // 
            // lblBajaCuota
            // 
            this.lblBajaCuota.AutoSize = true;
            this.lblBajaCuota.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblBajaCuota.ForeColor = System.Drawing.Color.Maroon;
            this.lblBajaCuota.Location = new System.Drawing.Point(33, 498);
            this.lblBajaCuota.Name = "lblBajaCuota";
            this.lblBajaCuota.Size = new System.Drawing.Size(284, 20);
            this.lblBajaCuota.TabIndex = 15;
            this.lblBajaCuota.Text = "* Elija la cuota para poder darla de baja.";
            this.lblBajaCuota.UseCustomBackColor = true;
            this.lblBajaCuota.UseCustomForeColor = true;
            // 
            // frmGestionCuotas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(877, 793);
            this.Controls.Add(this.lblAyuda);
            this.Controls.Add(this.panelBusqueda);
            this.Controls.Add(this.panelGeneracion);
            this.Controls.Add(this.btnParticular);
            this.Controls.Add(this.btnMasivo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGestionCuotas";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "GESTIÓN CUOTAS";
            this.Load += new System.EventHandler(this.frmGestionCuotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculados)).EndInit();
            this.panelGeneracion.ResumeLayout(false);
            this.panelGeneracion.PerformLayout();
            this.panelBusqueda.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnMasivo;
        private MetroFramework.Controls.MetroTile btnParticular;
        private MetroFramework.Controls.MetroButton btnGenerar;
        private MetroFramework.Controls.MetroComboBox cbSalas;
        private MetroFramework.Controls.MetroGrid dgvMatriculados;
        private MetroFramework.Controls.MetroPanel panelGeneracion;
        private MetroFramework.Controls.MetroTextBox txtMatriculados;
        private System.Windows.Forms.ListView listConceptos;
        private MetroFramework.Controls.MetroPanel panelBusqueda;
        private MetroFramework.Controls.MetroLabel lblAyuda;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbPeriodo;
        private MetroFramework.Controls.MetroComboBox cbAnoEjercicio;
        private MetroFramework.Controls.MetroButton btnBajaCuota;
        private MetroFramework.Controls.MetroLabel lblBajaCuota;
    }
}