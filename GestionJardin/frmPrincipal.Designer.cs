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
            this.htmlToolTip1 = new MetroFramework.Drawing.Html.HtmlToolTip();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.panel_Titulo = new System.Windows.Forms.Panel();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.panel_Shadow = new System.Windows.Forms.Panel();
            this.panel_Contenedor = new System.Windows.Forms.Panel();
            this.iconChildFormCurrent = new FontAwesome.Sharp.IconPictureBox();
            this.icBtnCobros = new FontAwesome.Sharp.IconButton();
            this.icBtnCuotas = new FontAwesome.Sharp.IconButton();
            this.icBtn_Conceptos = new FontAwesome.Sharp.IconButton();
            this.icBtn_Personas = new FontAwesome.Sharp.IconButton();
            this.btn_Home = new System.Windows.Forms.PictureBox();
            this.panel_Menu.SuspendLayout();
            this.panel_Logo.SuspendLayout();
            this.panel_Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconChildFormCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Home)).BeginInit();
            this.SuspendLayout();
            // 
            // htmlToolTip1
            // 
            this.htmlToolTip1.OwnerDraw = true;
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
            this.panel_Menu.Size = new System.Drawing.Size(214, 450);
            this.panel_Menu.TabIndex = 3;
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
            // panel_Titulo
            // 
            this.panel_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel_Titulo.Controls.Add(this.lbl_Titulo);
            this.panel_Titulo.Controls.Add(this.iconChildFormCurrent);
            this.panel_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Titulo.Location = new System.Drawing.Point(214, 0);
            this.panel_Titulo.Name = "panel_Titulo";
            this.panel_Titulo.Size = new System.Drawing.Size(586, 121);
            this.panel_Titulo.TabIndex = 4;
            this.panel_Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Titulo_MouseDown);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_Titulo.Location = new System.Drawing.Point(103, 45);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(88, 29);
            this.lbl_Titulo.TabIndex = 1;
            this.lbl_Titulo.Text = "HOME";
            // 
            // panel_Shadow
            // 
            this.panel_Shadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panel_Shadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Shadow.Location = new System.Drawing.Point(214, 121);
            this.panel_Shadow.Name = "panel_Shadow";
            this.panel_Shadow.Size = new System.Drawing.Size(586, 9);
            this.panel_Shadow.TabIndex = 5;
            // 
            // panel_Contenedor
            // 
            this.panel_Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Contenedor.Location = new System.Drawing.Point(214, 130);
            this.panel_Contenedor.Name = "panel_Contenedor";
            this.panel_Contenedor.Size = new System.Drawing.Size(586, 320);
            this.panel_Contenedor.TabIndex = 6;
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
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_Contenedor);
            this.Controls.Add(this.panel_Shadow);
            this.Controls.Add(this.panel_Titulo);
            this.Controls.Add(this.panel_Menu);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmPrincipal";
            this.Text = "PATITO COLETÓN";
            this.panel_Menu.ResumeLayout(false);
            this.panel_Logo.ResumeLayout(false);
            this.panel_Titulo.ResumeLayout(false);
            this.panel_Titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconChildFormCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Home)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Drawing.Html.HtmlToolTip htmlToolTip1;
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
    }
}