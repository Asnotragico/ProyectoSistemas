namespace GestionJardin
{
    partial class frmPrincipal
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
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.icBtnCobros = new FontAwesome.Sharp.IconButton();
            this.icBtnCuotas = new FontAwesome.Sharp.IconButton();
            this.icBtn_Conceptos = new FontAwesome.Sharp.IconButton();
            this.icBtn_Personas = new FontAwesome.Sharp.IconButton();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.btn_Home = new System.Windows.Forms.PictureBox();
            this.panel_Titulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximizar = new FontAwesome.Sharp.IconPictureBox();
            this.btn_Cerrar = new FontAwesome.Sharp.IconPictureBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.iconChildFormCurrent = new FontAwesome.Sharp.IconPictureBox();
            this.panel_Shadow = new System.Windows.Forms.Panel();
            this.panel_Contenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.panel_Menu.SuspendLayout();
            this.panel_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Home)).BeginInit();
            this.panel_Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconChildFormCurrent)).BeginInit();
            this.panel_Contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel_Menu.Controls.Add(this.icBtnCobros);
            this.panel_Menu.Controls.Add(this.icBtnCuotas);
            this.panel_Menu.Controls.Add(this.icBtn_Conceptos);
            this.panel_Menu.Controls.Add(this.icBtn_Personas);
            this.panel_Menu.Controls.Add(this.panel_Logo);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(214, 1055);
            this.panel_Menu.TabIndex = 3;
            // 
            // icBtnCobros
            // 
            this.icBtnCobros.Dock = System.Windows.Forms.DockStyle.Top;
            this.icBtnCobros.FlatAppearance.BorderSize = 0;
            this.icBtnCobros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icBtnCobros.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icBtnCobros.ForeColor = System.Drawing.Color.Gainsboro;
            this.icBtnCobros.IconChar = FontAwesome.Sharp.IconChar.Donate;
            this.icBtnCobros.IconColor = System.Drawing.Color.Gainsboro;
            this.icBtnCobros.IconSize = 32;
            this.icBtnCobros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icBtnCobros.Location = new System.Drawing.Point(0, 314);
            this.icBtnCobros.Name = "icBtnCobros";
            this.icBtnCobros.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.icBtnCobros.Rotation = 0D;
            this.icBtnCobros.Size = new System.Drawing.Size(214, 60);
            this.icBtnCobros.TabIndex = 4;
            this.icBtnCobros.Text = "COBROS";
            this.icBtnCobros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icBtnCobros.UseVisualStyleBackColor = true;
            this.icBtnCobros.Click += new System.EventHandler(this.icBtnCobros_Click);
            // 
            // icBtnCuotas
            // 
            this.icBtnCuotas.Dock = System.Windows.Forms.DockStyle.Top;
            this.icBtnCuotas.FlatAppearance.BorderSize = 0;
            this.icBtnCuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icBtnCuotas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icBtnCuotas.ForeColor = System.Drawing.Color.Gainsboro;
            this.icBtnCuotas.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.icBtnCuotas.IconColor = System.Drawing.Color.Gainsboro;
            this.icBtnCuotas.IconSize = 32;
            this.icBtnCuotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icBtnCuotas.Location = new System.Drawing.Point(0, 254);
            this.icBtnCuotas.Name = "icBtnCuotas";
            this.icBtnCuotas.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.icBtnCuotas.Rotation = 0D;
            this.icBtnCuotas.Size = new System.Drawing.Size(214, 60);
            this.icBtnCuotas.TabIndex = 3;
            this.icBtnCuotas.Text = "CUOTAS";
            this.icBtnCuotas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icBtnCuotas.UseVisualStyleBackColor = true;
            this.icBtnCuotas.Click += new System.EventHandler(this.icBtnCuotas_Click);
            // 
            // icBtn_Conceptos
            // 
            this.icBtn_Conceptos.Dock = System.Windows.Forms.DockStyle.Top;
            this.icBtn_Conceptos.FlatAppearance.BorderSize = 0;
            this.icBtn_Conceptos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icBtn_Conceptos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icBtn_Conceptos.ForeColor = System.Drawing.Color.Gainsboro;
            this.icBtn_Conceptos.IconChar = FontAwesome.Sharp.IconChar.ThList;
            this.icBtn_Conceptos.IconColor = System.Drawing.Color.Gainsboro;
            this.icBtn_Conceptos.IconSize = 32;
            this.icBtn_Conceptos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icBtn_Conceptos.Location = new System.Drawing.Point(0, 194);
            this.icBtn_Conceptos.Name = "icBtn_Conceptos";
            this.icBtn_Conceptos.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.icBtn_Conceptos.Rotation = 0D;
            this.icBtn_Conceptos.Size = new System.Drawing.Size(214, 60);
            this.icBtn_Conceptos.TabIndex = 2;
            this.icBtn_Conceptos.Text = "CONCEPTOS";
            this.icBtn_Conceptos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icBtn_Conceptos.UseVisualStyleBackColor = true;
            this.icBtn_Conceptos.Click += new System.EventHandler(this.icBtn_Conceptos_Click);
            // 
            // icBtn_Personas
            // 
            this.icBtn_Personas.Dock = System.Windows.Forms.DockStyle.Top;
            this.icBtn_Personas.FlatAppearance.BorderSize = 0;
            this.icBtn_Personas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icBtn_Personas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icBtn_Personas.ForeColor = System.Drawing.Color.Gainsboro;
            this.icBtn_Personas.IconChar = FontAwesome.Sharp.IconChar.User;
            this.icBtn_Personas.IconColor = System.Drawing.Color.Gainsboro;
            this.icBtn_Personas.IconSize = 32;
            this.icBtn_Personas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icBtn_Personas.Location = new System.Drawing.Point(0, 134);
            this.icBtn_Personas.Name = "icBtn_Personas";
            this.icBtn_Personas.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.icBtn_Personas.Rotation = 0D;
            this.icBtn_Personas.Size = new System.Drawing.Size(214, 60);
            this.icBtn_Personas.TabIndex = 1;
            this.icBtn_Personas.Text = "PERSONAS";
            this.icBtn_Personas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icBtn_Personas.UseVisualStyleBackColor = true;
            this.icBtn_Personas.Click += new System.EventHandler(this.icBtn_Personas_Click);
            // 
            // panel_Logo
            // 
            this.panel_Logo.Controls.Add(this.btn_Home);
            this.panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(214, 134);
            this.panel_Logo.TabIndex = 0;
            // 
            // btn_Home
            // 
            this.btn_Home.Image = global::GestionJardin.Properties.Resources.Group_3;
            this.btn_Home.Location = new System.Drawing.Point(45, 26);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(115, 89);
            this.btn_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Home.TabIndex = 1;
            this.btn_Home.TabStop = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // panel_Titulo
            // 
            this.panel_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel_Titulo.Controls.Add(this.btnMinimizar);
            this.panel_Titulo.Controls.Add(this.btnMaximizar);
            this.panel_Titulo.Controls.Add(this.btn_Cerrar);
            this.panel_Titulo.Controls.Add(this.lbl_Titulo);
            this.panel_Titulo.Controls.Add(this.iconChildFormCurrent);
            this.panel_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Titulo.Location = new System.Drawing.Point(214, 0);
            this.panel_Titulo.Name = "panel_Titulo";
            this.panel_Titulo.Size = new System.Drawing.Size(1026, 121);
            this.panel_Titulo.TabIndex = 4;
            this.panel_Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Titulo_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnMinimizar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimizar.IconSize = 23;
            this.btnMinimizar.Location = new System.Drawing.Point(945, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(23, 27);
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnMaximizar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximizar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaximizar.IconSize = 23;
            this.btnMaximizar.Location = new System.Drawing.Point(974, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(23, 27);
            this.btnMaximizar.TabIndex = 6;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btn_Cerrar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Cerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btn_Cerrar.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Cerrar.IconSize = 23;
            this.btn_Cerrar.Location = new System.Drawing.Point(1003, 3);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(23, 27);
            this.btn_Cerrar.TabIndex = 5;
            this.btn_Cerrar.TabStop = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_Titulo.Location = new System.Drawing.Point(103, 45);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(86, 29);
            this.lbl_Titulo.TabIndex = 1;
            this.lbl_Titulo.Text = "INICIO";
            // 
            // iconChildFormCurrent
            // 
            this.iconChildFormCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconChildFormCurrent.ForeColor = System.Drawing.Color.Purple;
            this.iconChildFormCurrent.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconChildFormCurrent.IconColor = System.Drawing.Color.Purple;
            this.iconChildFormCurrent.IconSize = 74;
            this.iconChildFormCurrent.Location = new System.Drawing.Point(17, 26);
            this.iconChildFormCurrent.Name = "iconChildFormCurrent";
            this.iconChildFormCurrent.Size = new System.Drawing.Size(80, 74);
            this.iconChildFormCurrent.TabIndex = 0;
            this.iconChildFormCurrent.TabStop = false;
            // 
            // panel_Shadow
            // 
            this.panel_Shadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panel_Shadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Shadow.Location = new System.Drawing.Point(214, 121);
            this.panel_Shadow.Name = "panel_Shadow";
            this.panel_Shadow.Size = new System.Drawing.Size(1026, 9);
            this.panel_Shadow.TabIndex = 5;
            // 
            // panel_Contenedor
            // 
            this.panel_Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel_Contenedor.Controls.Add(this.pictureBox1);
            this.panel_Contenedor.Controls.Add(this.lbl_Fecha);
            this.panel_Contenedor.Controls.Add(this.lbl_Hora);
            this.panel_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Contenedor.Location = new System.Drawing.Point(214, 130);
            this.panel_Contenedor.Name = "panel_Contenedor";
            this.panel_Contenedor.Size = new System.Drawing.Size(1026, 925);
            this.panel_Contenedor.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::GestionJardin.Properties.Resources.El_Patito_Coletón;
            this.pictureBox1.Location = new System.Drawing.Point(173, 261);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(663, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Font = new System.Drawing.Font("Verdana", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_Fecha.Location = new System.Drawing.Point(331, 619);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(178, 60);
            this.lbl_Fecha.TabIndex = 4;
            this.lbl_Fecha.Text = "label1";
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.Font = new System.Drawing.Font("Verdana", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hora.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lbl_Hora.Location = new System.Drawing.Point(241, 465);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(352, 121);
            this.lbl_Hora.TabIndex = 3;
            this.lbl_Hora.Text = "label1";
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1240, 1055);
            this.Controls.Add(this.panel_Contenedor);
            this.Controls.Add(this.panel_Shadow);
            this.Controls.Add(this.panel_Titulo);
            this.Controls.Add(this.panel_Menu);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "PATITO COLETÓN";
            this.panel_Menu.ResumeLayout(false);
            this.panel_Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Home)).EndInit();
            this.panel_Titulo.ResumeLayout(false);
            this.panel_Titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconChildFormCurrent)).EndInit();
            this.panel_Contenedor.ResumeLayout(false);
            this.panel_Contenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        //private MetroFramework.Drawing.Html.HtmlToolTip htmlToolTip1;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Panel panel_Logo;
        private FontAwesome.Sharp.IconButton icBtnCobros;
        private FontAwesome.Sharp.IconButton icBtnCuotas;
        private FontAwesome.Sharp.IconButton icBtn_Conceptos;
        private FontAwesome.Sharp.IconButton icBtn_Personas;
        private System.Windows.Forms.PictureBox btn_Home;
        private System.Windows.Forms.Panel panel_Titulo;
        private FontAwesome.Sharp.IconPictureBox iconChildFormCurrent;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Panel panel_Shadow;
        private System.Windows.Forms.Panel panel_Contenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label lbl_Hora;
        private System.Windows.Forms.Timer HoraFecha;
        private FontAwesome.Sharp.IconPictureBox btnMinimizar;
        private FontAwesome.Sharp.IconPictureBox btnMaximizar;
        private FontAwesome.Sharp.IconPictureBox btn_Cerrar;
    }
}