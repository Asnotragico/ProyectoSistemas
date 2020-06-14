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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionCuotas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAyuda = new MetroFramework.Controls.MetroLabel();
            this.panelBusqueda = new MetroFramework.Controls.MetroPanel();
            this.txtMatriculados = new MetroFramework.Controls.MetroTextBox();
            this.panelGeneracion = new MetroFramework.Controls.MetroPanel();
            this.cbPeriodo = new MetroFramework.Controls.MetroComboBox();
            this.cbAnoEjercicio = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.listConceptos = new System.Windows.Forms.ListView();
            this.dgvMatriculados = new MetroFramework.Controls.MetroGrid();
            this.cbSalas = new MetroFramework.Controls.MetroComboBox();
            this.btnGenerar = new MetroFramework.Controls.MetroButton();
            this.btnParticular = new MetroFramework.Controls.MetroTile();
            this.btnMasivo = new MetroFramework.Controls.MetroTile();
            this.panelBusqueda.SuspendLayout();
            this.panelGeneracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAyuda.Location = new System.Drawing.Point(61, 63);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(424, 20);
            this.lblAyuda.TabIndex = 19;
            this.lblAyuda.Text = "Elegir la modalidad de generar la cuota. (Masivo/Particular)";
            this.lblAyuda.UseCustomBackColor = true;
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panelBusqueda.Controls.Add(this.txtMatriculados);
            this.panelBusqueda.HorizontalScrollbarBarColor = true;
            this.panelBusqueda.HorizontalScrollbarHighlightOnWheel = false;
            this.panelBusqueda.HorizontalScrollbarSize = 10;
            this.panelBusqueda.Location = new System.Drawing.Point(328, 105);
            this.panelBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(488, 112);
            this.panelBusqueda.TabIndex = 18;
            this.panelBusqueda.UseCustomBackColor = true;
            this.panelBusqueda.VerticalScrollbarBarColor = true;
            this.panelBusqueda.VerticalScrollbarHighlightOnWheel = false;
            this.panelBusqueda.VerticalScrollbarSize = 11;
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
            // 
            // panelGeneracion
            // 
            this.panelGeneracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
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
            this.panelGeneracion.Location = new System.Drawing.Point(61, 233);
            this.panelGeneracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelGeneracion.Name = "panelGeneracion";
            this.panelGeneracion.Size = new System.Drawing.Size(755, 496);
            this.panelGeneracion.TabIndex = 17;
            this.panelGeneracion.UseCustomBackColor = true;
            this.panelGeneracion.VerticalScrollbarBarColor = true;
            this.panelGeneracion.VerticalScrollbarHighlightOnWheel = false;
            this.panelGeneracion.VerticalScrollbarSize = 11;
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
            "10",
            "11",
            "12"});
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
            this.listConceptos.HideSelection = false;
            this.listConceptos.Location = new System.Drawing.Point(383, 62);
            this.listConceptos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listConceptos.Name = "listConceptos";
            this.listConceptos.Size = new System.Drawing.Size(345, 191);
            this.listConceptos.TabIndex = 10;
            this.listConceptos.UseCompatibleStateImageBehavior = false;
            this.listConceptos.View = System.Windows.Forms.View.Details;
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatriculados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvMatriculados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatriculados.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvMatriculados.EnableHeadersVisualStyles = false;
            this.dgvMatriculados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvMatriculados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvMatriculados.Location = new System.Drawing.Point(33, 332);
            this.dgvMatriculados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMatriculados.Name = "dgvMatriculados";
            this.dgvMatriculados.ReadOnly = true;
            this.dgvMatriculados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatriculados.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvMatriculados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMatriculados.RowTemplate.Height = 24;
            this.dgvMatriculados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatriculados.Size = new System.Drawing.Size(696, 150);
            this.dgvMatriculados.Style = MetroFramework.MetroColorStyle.Yellow;
            this.dgvMatriculados.TabIndex = 9;
            this.dgvMatriculados.UseStyleColors = true;
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
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseCustomBackColor = true;
            this.btnGenerar.UseCustomForeColor = true;
            this.btnGenerar.UseSelectable = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnParticular
            // 
            this.btnParticular.ActiveControl = null;
            this.btnParticular.BackColor = System.Drawing.Color.SandyBrown;
            this.btnParticular.Location = new System.Drawing.Point(188, 105);
            this.btnParticular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnParticular.Name = "btnParticular";
            this.btnParticular.Size = new System.Drawing.Size(121, 112);
            this.btnParticular.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnParticular.TabIndex = 16;
            this.btnParticular.Text = "Particular";
            this.btnParticular.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnParticular.UseSelectable = true;
            this.btnParticular.UseStyleColors = true;
            this.btnParticular.Click += new System.EventHandler(this.btnParticular_Click_1);
            // 
            // btnMasivo
            // 
            this.btnMasivo.ActiveControl = null;
            this.btnMasivo.BackColor = System.Drawing.Color.SandyBrown;
            this.btnMasivo.Location = new System.Drawing.Point(61, 105);
            this.btnMasivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMasivo.Name = "btnMasivo";
            this.btnMasivo.Size = new System.Drawing.Size(121, 112);
            this.btnMasivo.TabIndex = 15;
            this.btnMasivo.Text = "Masivo";
            this.btnMasivo.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnMasivo.UseSelectable = true;
            this.btnMasivo.UseStyleColors = true;
            this.btnMasivo.Click += new System.EventHandler(this.btnMasivo_Click_1);
            // 
            // frmGestionCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.panelBusqueda.ResumeLayout(false);
            this.panelGeneracion.ResumeLayout(false);
            this.panelGeneracion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblAyuda;
        private MetroFramework.Controls.MetroPanel panelBusqueda;
        private MetroFramework.Controls.MetroTextBox txtMatriculados;
        private MetroFramework.Controls.MetroPanel panelGeneracion;
        private MetroFramework.Controls.MetroComboBox cbPeriodo;
        private MetroFramework.Controls.MetroComboBox cbAnoEjercicio;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ListView listConceptos;
        private MetroFramework.Controls.MetroGrid dgvMatriculados;
        private MetroFramework.Controls.MetroComboBox cbSalas;
        private MetroFramework.Controls.MetroButton btnGenerar;
        private MetroFramework.Controls.MetroTile btnParticular;
        private MetroFramework.Controls.MetroTile btnMasivo;
    }
}