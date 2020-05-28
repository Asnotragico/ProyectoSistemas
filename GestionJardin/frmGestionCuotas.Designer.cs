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
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "BASICO"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "INTERESES"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "MATERIALES"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "PASEO"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionCuotas));
            this.btnMasivo = new MetroFramework.Controls.MetroTile();
            this.btnParticular = new MetroFramework.Controls.MetroTile();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.cbSalas = new MetroFramework.Controls.MetroComboBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.panelGeneracion = new MetroFramework.Controls.MetroPanel();
            this.listConceptos = new System.Windows.Forms.ListView();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.panelBusqueda = new MetroFramework.Controls.MetroPanel();
            this.lblAyuda = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox3 = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.panelGeneracion.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMasivo
            // 
            this.btnMasivo.ActiveControl = null;
            this.btnMasivo.BackColor = System.Drawing.Color.SandyBrown;
            this.btnMasivo.Location = new System.Drawing.Point(46, 102);
            this.btnMasivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMasivo.Name = "btnMasivo";
            this.btnMasivo.Size = new System.Drawing.Size(91, 91);
            this.btnMasivo.TabIndex = 0;
            this.btnMasivo.Text = "Masivo";
            this.btnMasivo.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnMasivo.UseCustomBackColor = true;
            this.btnMasivo.UseSelectable = true;
            this.btnMasivo.Click += new System.EventHandler(this.btnMasivo_Click);
            // 
            // btnParticular
            // 
            this.btnParticular.ActiveControl = null;
            this.btnParticular.BackColor = System.Drawing.Color.SandyBrown;
            this.btnParticular.Location = new System.Drawing.Point(141, 102);
            this.btnParticular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnParticular.Name = "btnParticular";
            this.btnParticular.Size = new System.Drawing.Size(91, 91);
            this.btnParticular.TabIndex = 1;
            this.btnParticular.Text = "Particular";
            this.btnParticular.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnParticular.UseCustomBackColor = true;
            this.btnParticular.UseSelectable = true;
            this.btnParticular.Click += new System.EventHandler(this.btnParticular_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(217)))));
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.metroButton1.Location = new System.Drawing.Point(396, 219);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(151, 36);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Generar";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            // 
            // cbSalas
            // 
            this.cbSalas.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cbSalas.FormattingEnabled = true;
            this.cbSalas.ItemHeight = 29;
            this.cbSalas.Location = new System.Drawing.Point(25, 170);
            this.cbSalas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSalas.Name = "cbSalas";
            this.cbSalas.PromptText = "Sala";
            this.cbSalas.Size = new System.Drawing.Size(191, 35);
            this.cbSalas.TabIndex = 8;
            this.cbSalas.UseSelectable = true;
            this.cbSalas.SelectedValueChanged += new System.EventHandler(this.cbSalas_SelectedValueChanged);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(25, 270);
            this.metroGrid1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 24;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(522, 122);
            this.metroGrid1.TabIndex = 9;
            // 
            // panelGeneracion
            // 
            this.panelGeneracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelGeneracion.Controls.Add(this.metroComboBox3);
            this.panelGeneracion.Controls.Add(this.metroComboBox2);
            this.panelGeneracion.Controls.Add(this.metroLabel1);
            this.panelGeneracion.Controls.Add(this.listConceptos);
            this.panelGeneracion.Controls.Add(this.metroGrid1);
            this.panelGeneracion.Controls.Add(this.cbSalas);
            this.panelGeneracion.Controls.Add(this.metroButton1);
            this.panelGeneracion.HorizontalScrollbar = true;
            this.panelGeneracion.HorizontalScrollbarBarColor = true;
            this.panelGeneracion.HorizontalScrollbarHighlightOnWheel = false;
            this.panelGeneracion.HorizontalScrollbarSize = 8;
            this.panelGeneracion.Location = new System.Drawing.Point(46, 206);
            this.panelGeneracion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelGeneracion.Name = "panelGeneracion";
            this.panelGeneracion.Size = new System.Drawing.Size(566, 403);
            this.panelGeneracion.TabIndex = 12;
            this.panelGeneracion.UseCustomBackColor = true;
            this.panelGeneracion.VerticalScrollbarBarColor = true;
            this.panelGeneracion.VerticalScrollbarHighlightOnWheel = false;
            this.panelGeneracion.VerticalScrollbarSize = 8;
            // 
            // listConceptos
            // 
            this.listConceptos.HideSelection = false;
            this.listConceptos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.listConceptos.Location = new System.Drawing.Point(287, 50);
            this.listConceptos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listConceptos.Name = "listConceptos";
            this.listConceptos.Size = new System.Drawing.Size(260, 156);
            this.listConceptos.TabIndex = 10;
            this.listConceptos.UseCompatibleStateImageBehavior = false;
            this.listConceptos.View = System.Windows.Forms.View.Tile;
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(310, 2);
            this.metroTextBox3.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(14, 30);
            this.metroTextBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.PromptText = "Matriculado";
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.ShowButton = true;
            this.metroTextBox3.ShowClearButton = true;
            this.metroTextBox3.Size = new System.Drawing.Size(338, 30);
            this.metroTextBox3.TabIndex = 10;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMark = "Matriculado";
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelBusqueda.Controls.Add(this.metroTextBox3);
            this.panelBusqueda.HorizontalScrollbarBarColor = true;
            this.panelBusqueda.HorizontalScrollbarHighlightOnWheel = false;
            this.panelBusqueda.HorizontalScrollbarSize = 8;
            this.panelBusqueda.Location = new System.Drawing.Point(246, 102);
            this.panelBusqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(366, 91);
            this.panelBusqueda.TabIndex = 13;
            this.panelBusqueda.UseCustomBackColor = true;
            this.panelBusqueda.VerticalScrollbarBarColor = true;
            this.panelBusqueda.VerticalScrollbarHighlightOnWheel = false;
            this.panelBusqueda.VerticalScrollbarSize = 8;
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAyuda.Location = new System.Drawing.Point(46, 68);
            this.lblAyuda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(412, 19);
            this.lblAyuda.TabIndex = 14;
            this.lblAyuda.Text = "Elegir la modalidad de generar la cuota. (Masivo/Particular)";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(3, 1);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(154, 25);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Datos de la Cuota";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 29;
            this.metroComboBox2.Location = new System.Drawing.Point(25, 110);
            this.metroComboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.PromptText = "Año";
            this.metroComboBox2.Size = new System.Drawing.Size(191, 35);
            this.metroComboBox2.TabIndex = 16;
            this.metroComboBox2.UseSelectable = true;
            // 
            // metroComboBox3
            // 
            this.metroComboBox3.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.metroComboBox3.FormattingEnabled = true;
            this.metroComboBox3.ItemHeight = 29;
            this.metroComboBox3.Location = new System.Drawing.Point(25, 50);
            this.metroComboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.metroComboBox3.Name = "metroComboBox3";
            this.metroComboBox3.PromptText = "Periodo";
            this.metroComboBox3.Size = new System.Drawing.Size(191, 35);
            this.metroComboBox3.TabIndex = 17;
            this.metroComboBox3.UseSelectable = true;
            // 
            // frmGestionCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 644);
            this.Controls.Add(this.lblAyuda);
            this.Controls.Add(this.panelBusqueda);
            this.Controls.Add(this.panelGeneracion);
            this.Controls.Add(this.btnParticular);
            this.Controls.Add(this.btnMasivo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmGestionCuotas";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Gestión de Cuotas";
            this.Load += new System.EventHandler(this.frmGestionCuotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.panelGeneracion.ResumeLayout(false);
            this.panelGeneracion.PerformLayout();
            this.panelBusqueda.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnMasivo;
        private MetroFramework.Controls.MetroTile btnParticular;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox cbSalas;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroPanel panelGeneracion;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private System.Windows.Forms.ListView listConceptos;
        private MetroFramework.Controls.MetroPanel panelBusqueda;
        private MetroFramework.Controls.MetroLabel lblAyuda;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox3;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
    }
}