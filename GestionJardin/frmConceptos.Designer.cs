namespace GestionJardin
{
    partial class frmConceptos
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
            this.panel_Per_Menu = new System.Windows.Forms.Panel();
            this.icBtn_VisualizarConc = new FontAwesome.Sharp.IconPictureBox();
            this.icBtn_AgregarConc = new FontAwesome.Sharp.IconPictureBox();
            this.icBtn_EliminarConc = new FontAwesome.Sharp.IconPictureBox();
            this.icBtn_EditarConc = new FontAwesome.Sharp.IconPictureBox();
            this.panel_ConAbm = new System.Windows.Forms.Panel();
            this.dgv_ConVisAbm = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_ConVisualizar = new System.Windows.Forms.Panel();
            this.dgv_ConVisualizar = new System.Windows.Forms.DataGridView();
            this.panel_ConIngresar = new System.Windows.Forms.Panel();
            this.Ibtn_ConGuardar = new FontAwesome.Sharp.IconButton();
            this.Ibtn_ConCancelar = new FontAwesome.Sharp.IconButton();
            this.dtp_ConFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MontoConp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ConNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.icBtn_BuscarPer = new FontAwesome.Sharp.IconPictureBox();
            this.panel_Per_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icBtn_VisualizarConc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icBtn_AgregarConc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icBtn_EliminarConc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icBtn_EditarConc)).BeginInit();
            this.panel_ConAbm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ConVisAbm)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel_ConVisualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ConVisualizar)).BeginInit();
            this.panel_ConIngresar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icBtn_BuscarPer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Per_Menu
            // 
            this.panel_Per_Menu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_Per_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel_Per_Menu.Controls.Add(this.icBtn_VisualizarConc);
            this.panel_Per_Menu.Controls.Add(this.icBtn_AgregarConc);
            this.panel_Per_Menu.Controls.Add(this.icBtn_EliminarConc);
            this.panel_Per_Menu.Controls.Add(this.icBtn_EditarConc);
            this.panel_Per_Menu.Location = new System.Drawing.Point(846, 64);
            this.panel_Per_Menu.Name = "panel_Per_Menu";
            this.panel_Per_Menu.Size = new System.Drawing.Size(120, 374);
            this.panel_Per_Menu.TabIndex = 1;
            // 
            // icBtn_VisualizarConc
            // 
            this.icBtn_VisualizarConc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.icBtn_VisualizarConc.ForeColor = System.Drawing.Color.Black;
            this.icBtn_VisualizarConc.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.icBtn_VisualizarConc.IconColor = System.Drawing.Color.Black;
            this.icBtn_VisualizarConc.IconSize = 80;
            this.icBtn_VisualizarConc.Location = new System.Drawing.Point(21, 283);
            this.icBtn_VisualizarConc.Name = "icBtn_VisualizarConc";
            this.icBtn_VisualizarConc.Size = new System.Drawing.Size(76, 71);
            this.icBtn_VisualizarConc.TabIndex = 3;
            this.icBtn_VisualizarConc.TabStop = false;
            this.icBtn_VisualizarConc.Click += new System.EventHandler(this.icBtn_VisualizarConc_Click);
            // 
            // icBtn_AgregarConc
            // 
            this.icBtn_AgregarConc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.icBtn_AgregarConc.ForeColor = System.Drawing.Color.SeaGreen;
            this.icBtn_AgregarConc.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.icBtn_AgregarConc.IconColor = System.Drawing.Color.SeaGreen;
            this.icBtn_AgregarConc.IconSize = 70;
            this.icBtn_AgregarConc.Location = new System.Drawing.Point(21, 23);
            this.icBtn_AgregarConc.Name = "icBtn_AgregarConc";
            this.icBtn_AgregarConc.Size = new System.Drawing.Size(78, 71);
            this.icBtn_AgregarConc.TabIndex = 0;
            this.icBtn_AgregarConc.TabStop = false;
            this.icBtn_AgregarConc.Click += new System.EventHandler(this.icBtn_AgregarConc_Click);
            // 
            // icBtn_EliminarConc
            // 
            this.icBtn_EliminarConc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.icBtn_EliminarConc.ForeColor = System.Drawing.Color.OrangeRed;
            this.icBtn_EliminarConc.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.icBtn_EliminarConc.IconColor = System.Drawing.Color.OrangeRed;
            this.icBtn_EliminarConc.IconSize = 65;
            this.icBtn_EliminarConc.Location = new System.Drawing.Point(21, 197);
            this.icBtn_EliminarConc.Name = "icBtn_EliminarConc";
            this.icBtn_EliminarConc.Size = new System.Drawing.Size(76, 71);
            this.icBtn_EliminarConc.TabIndex = 2;
            this.icBtn_EliminarConc.TabStop = false;
            // 
            // icBtn_EditarConc
            // 
            this.icBtn_EditarConc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.icBtn_EditarConc.ForeColor = System.Drawing.Color.RoyalBlue;
            this.icBtn_EditarConc.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.icBtn_EditarConc.IconColor = System.Drawing.Color.RoyalBlue;
            this.icBtn_EditarConc.IconSize = 71;
            this.icBtn_EditarConc.Location = new System.Drawing.Point(21, 109);
            this.icBtn_EditarConc.Name = "icBtn_EditarConc";
            this.icBtn_EditarConc.Size = new System.Drawing.Size(76, 71);
            this.icBtn_EditarConc.TabIndex = 1;
            this.icBtn_EditarConc.TabStop = false;
            // 
            // panel_ConAbm
            // 
            this.panel_ConAbm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_ConAbm.Controls.Add(this.dgv_ConVisAbm);
            this.panel_ConAbm.Location = new System.Drawing.Point(48, 474);
            this.panel_ConAbm.Name = "panel_ConAbm";
            this.panel_ConAbm.Size = new System.Drawing.Size(918, 123);
            this.panel_ConAbm.TabIndex = 3;
            // 
            // dgv_ConVisAbm
            // 
            this.dgv_ConVisAbm.AllowUserToAddRows = false;
            this.dgv_ConVisAbm.AllowUserToDeleteRows = false;
            this.dgv_ConVisAbm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ConVisAbm.Location = new System.Drawing.Point(37, 20);
            this.dgv_ConVisAbm.Name = "dgv_ConVisAbm";
            this.dgv_ConVisAbm.ReadOnly = true;
            this.dgv_ConVisAbm.RowTemplate.Height = 24;
            this.dgv_ConVisAbm.Size = new System.Drawing.Size(858, 90);
            this.dgv_ConVisAbm.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel3.Controls.Add(this.panel_ConVisualizar);
            this.panel3.Controls.Add(this.panel_ConIngresar);
            this.panel3.Location = new System.Drawing.Point(72, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(747, 412);
            this.panel3.TabIndex = 4;
            // 
            // panel_ConVisualizar
            // 
            this.panel_ConVisualizar.Controls.Add(this.label19);
            this.panel_ConVisualizar.Controls.Add(this.textBox1);
            this.panel_ConVisualizar.Controls.Add(this.icBtn_BuscarPer);
            this.panel_ConVisualizar.Controls.Add(this.dgv_ConVisualizar);
            this.panel_ConVisualizar.ForeColor = System.Drawing.Color.Black;
            this.panel_ConVisualizar.Location = new System.Drawing.Point(31, 43);
            this.panel_ConVisualizar.Name = "panel_ConVisualizar";
            this.panel_ConVisualizar.Size = new System.Drawing.Size(686, 331);
            this.panel_ConVisualizar.TabIndex = 23;
            // 
            // dgv_ConVisualizar
            // 
            this.dgv_ConVisualizar.AllowUserToAddRows = false;
            this.dgv_ConVisualizar.AllowUserToDeleteRows = false;
            this.dgv_ConVisualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_ConVisualizar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.dgv_ConVisualizar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ConVisualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ConVisualizar.GridColor = System.Drawing.Color.Black;
            this.dgv_ConVisualizar.Location = new System.Drawing.Point(15, 129);
            this.dgv_ConVisualizar.Name = "dgv_ConVisualizar";
            this.dgv_ConVisualizar.ReadOnly = true;
            this.dgv_ConVisualizar.RowTemplate.Height = 24;
            this.dgv_ConVisualizar.Size = new System.Drawing.Size(651, 168);
            this.dgv_ConVisualizar.TabIndex = 0;
            // 
            // panel_ConIngresar
            // 
            this.panel_ConIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_ConIngresar.Controls.Add(this.Ibtn_ConGuardar);
            this.panel_ConIngresar.Controls.Add(this.Ibtn_ConCancelar);
            this.panel_ConIngresar.Controls.Add(this.dtp_ConFechaAlta);
            this.panel_ConIngresar.Controls.Add(this.label3);
            this.panel_ConIngresar.Controls.Add(this.txt_MontoConp);
            this.panel_ConIngresar.Controls.Add(this.label2);
            this.panel_ConIngresar.Controls.Add(this.txt_ConNombre);
            this.panel_ConIngresar.Controls.Add(this.label1);
            this.panel_ConIngresar.Location = new System.Drawing.Point(162, 84);
            this.panel_ConIngresar.Name = "panel_ConIngresar";
            this.panel_ConIngresar.Size = new System.Drawing.Size(404, 253);
            this.panel_ConIngresar.TabIndex = 23;
            // 
            // Ibtn_ConGuardar
            // 
            this.Ibtn_ConGuardar.BackColor = System.Drawing.Color.LimeGreen;
            this.Ibtn_ConGuardar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Ibtn_ConGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.Ibtn_ConGuardar.IconColor = System.Drawing.Color.Black;
            this.Ibtn_ConGuardar.IconSize = 40;
            this.Ibtn_ConGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ibtn_ConGuardar.Location = new System.Drawing.Point(49, 171);
            this.Ibtn_ConGuardar.Name = "Ibtn_ConGuardar";
            this.Ibtn_ConGuardar.Rotation = 0D;
            this.Ibtn_ConGuardar.Size = new System.Drawing.Size(133, 53);
            this.Ibtn_ConGuardar.TabIndex = 19;
            this.Ibtn_ConGuardar.Text = "GUARDAR";
            this.Ibtn_ConGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ibtn_ConGuardar.UseVisualStyleBackColor = false;
            this.Ibtn_ConGuardar.Click += new System.EventHandler(this.Ibtn_ConGuardar_Click_1);
            // 
            // Ibtn_ConCancelar
            // 
            this.Ibtn_ConCancelar.BackColor = System.Drawing.Color.DarkGray;
            this.Ibtn_ConCancelar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Ibtn_ConCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Ibtn_ConCancelar.IconColor = System.Drawing.Color.Black;
            this.Ibtn_ConCancelar.IconSize = 16;
            this.Ibtn_ConCancelar.Location = new System.Drawing.Point(219, 171);
            this.Ibtn_ConCancelar.Name = "Ibtn_ConCancelar";
            this.Ibtn_ConCancelar.Rotation = 0D;
            this.Ibtn_ConCancelar.Size = new System.Drawing.Size(133, 53);
            this.Ibtn_ConCancelar.TabIndex = 20;
            this.Ibtn_ConCancelar.Text = "CANCELAR";
            this.Ibtn_ConCancelar.UseVisualStyleBackColor = false;
            // 
            // dtp_ConFechaAlta
            // 
            this.dtp_ConFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ConFechaAlta.Location = new System.Drawing.Point(164, 110);
            this.dtp_ConFechaAlta.Name = "dtp_ConFechaAlta";
            this.dtp_ConFechaAlta.Size = new System.Drawing.Size(118, 22);
            this.dtp_ConFechaAlta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(46, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "FECHA ALTA:";
            // 
            // txt_MontoConp
            // 
            this.txt_MontoConp.Location = new System.Drawing.Point(139, 68);
            this.txt_MontoConp.Name = "txt_MontoConp";
            this.txt_MontoConp.Size = new System.Drawing.Size(117, 22);
            this.txt_MontoConp.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(46, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "MONTO:";
            // 
            // txt_ConNombre
            // 
            this.txt_ConNombre.Location = new System.Drawing.Point(139, 24);
            this.txt_ConNombre.Name = "txt_ConNombre";
            this.txt_ConNombre.Size = new System.Drawing.Size(231, 22);
            this.txt_ConNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(47, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE:";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(55, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(165, 17);
            this.label19.TabIndex = 24;
            this.label19.Text = "BUSCAR CONCEPTO:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(235, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 22);
            this.textBox1.TabIndex = 22;
            // 
            // icBtn_BuscarPer
            // 
            this.icBtn_BuscarPer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icBtn_BuscarPer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.icBtn_BuscarPer.ForeColor = System.Drawing.Color.Black;
            this.icBtn_BuscarPer.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.icBtn_BuscarPer.IconColor = System.Drawing.Color.Black;
            this.icBtn_BuscarPer.IconSize = 24;
            this.icBtn_BuscarPer.Location = new System.Drawing.Point(565, 52);
            this.icBtn_BuscarPer.Name = "icBtn_BuscarPer";
            this.icBtn_BuscarPer.Size = new System.Drawing.Size(32, 24);
            this.icBtn_BuscarPer.TabIndex = 23;
            this.icBtn_BuscarPer.TabStop = false;
            // 
            // frmConceptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1041, 609);
            this.Controls.Add(this.panel_ConAbm);
            this.Controls.Add(this.panel_Per_Menu);
            this.Controls.Add(this.panel3);
            this.Name = "frmConceptos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "GESTIÓN CONCEPTOS";
            this.panel_Per_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icBtn_VisualizarConc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icBtn_AgregarConc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icBtn_EliminarConc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icBtn_EditarConc)).EndInit();
            this.panel_ConAbm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ConVisAbm)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel_ConVisualizar.ResumeLayout(false);
            this.panel_ConVisualizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ConVisualizar)).EndInit();
            this.panel_ConIngresar.ResumeLayout(false);
            this.panel_ConIngresar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icBtn_BuscarPer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Per_Menu;
        private FontAwesome.Sharp.IconPictureBox icBtn_AgregarConc;
        private FontAwesome.Sharp.IconPictureBox icBtn_EliminarConc;
        private FontAwesome.Sharp.IconPictureBox icBtn_EditarConc;
        private System.Windows.Forms.Panel panel_ConAbm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_ConVisAbm;
        private System.Windows.Forms.Panel panel_ConVisualizar;
        private System.Windows.Forms.DataGridView dgv_ConVisualizar;
        private System.Windows.Forms.Panel panel_ConIngresar;
        private FontAwesome.Sharp.IconButton Ibtn_ConGuardar;
        private FontAwesome.Sharp.IconButton Ibtn_ConCancelar;
        private System.Windows.Forms.DateTimePicker dtp_ConFechaAlta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MontoConp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ConNombre;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox icBtn_VisualizarConc;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconPictureBox icBtn_BuscarPer;
    }
}