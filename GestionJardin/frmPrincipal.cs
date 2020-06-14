using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MetroFramework.Forms;

namespace GestionJardin
{
    public partial class frmPrincipal : Form
    {
        private IconButton currentBtn; // para almacenar el boton actual
        private Panel leftBorderBtn;  //para aplicar un borde izquierdo al boton
        private Form currentFormChild; //para almacenar el form hijo actual

        public frmPrincipal()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();// Inicializamos el leftBorderBtn
            leftBorderBtn.Size = new Size(7, 60);

            panel_Menu.Controls.Add(leftBorderBtn); //se agrega borde al panel
            this.Text = string.Empty; // como texto del form va una cadena vacia
            this.ControlBox = false; // se desactiva la caja de control
            this.DoubleBuffered = true; //reduce el parpadeo del form
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; //con este control genera un borde al maximizar para
                                                                               // poder trabajar con otras apps

        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }


        //Resalta el boton activo
        private void ActivatedButton(object senderbtn, Color color)
        {
            if (senderbtn != null)
            {
                DisableButton();
                //button
                currentBtn = (IconButton)senderbtn; // se asigna el boton que presionamos
                currentBtn.BackColor = Color.FromArgb(37, 36, 81); //se cambia el color del boton
                currentBtn.ForeColor = color; // se cambia el color de fuente
                currentBtn.TextAlign = ContentAlignment.MiddleCenter; // se alinea el texto al centro
                currentBtn.IconColor = color; //cambia el color del icono
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage; // da vuelta el texto antes que la imagen
                currentBtn.ImageAlign = ContentAlignment.MiddleRight; //alinea la imagen a la derecha

                //border
                leftBorderBtn.BackColor = color; //cambia el color del borde del boton
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y); //cambia la locacion del borde del boton
                leftBorderBtn.Visible = true; //para mostrar
                leftBorderBtn.BringToFront(); //trae al frente

                //Icono Form actual
                iconChildFormCurrent.IconChar = currentBtn.IconChar; // el icono del titulo sea igual al icono que esta activo
                iconChildFormCurrent.IconColor = color;

            }

        }

        //Desactivar el resaltado del boton 
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                //button a valores por defecto 
                currentBtn.BackColor = Color.FromArgb(31, 30, 68); //se cambia el color del boton
                currentBtn.ForeColor = Color.Gainsboro; // se cambia el color de fuente
                currentBtn.TextAlign = ContentAlignment.MiddleLeft; // se alinea el texto al centro
                currentBtn.IconColor = Color.Gainsboro; //cambia el color del icono
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText; // da vuelta el texto antes que la imagen
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft; //alinea la imagen a la derecha
            }
        }


        //Para llamar abrir los form hijos
        private void OpenChildForm(Form ChildForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close(); // se cierra el form actual -- permite solo un form actual
            }

            currentFormChild = ChildForm;
            ChildForm.TopLevel = false; // para indicar que no es de nivel superior --VER CON GASTON
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel_Contenedor.Controls.Add(ChildForm); //para que controle los demas forms
            panel_Contenedor.Tag = ChildForm; // Asociar los datos de los forms al panel
            ChildForm.BringToFront(); // se trae al frente cada form para mostrar
            ChildForm.Show();
            lbl_Titulo.Text = ChildForm.Text;
            
        }



        private void icBtn_Personas_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender, RGBColors.color1);
            OpenChildForm(new GestionJardin.frmPersonas2());
        }

        private void icBtn_Conceptos_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender, RGBColors.color2);
            OpenChildForm(new GestionJardin.frmConceptos2());
        }

        private void icBtnCuotas_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender, RGBColors.color3);
            OpenChildForm(new GestionJardin.frmGestionCuotas()); // ver como cambiar con GASTON!!!
        }

        private void icBtnCobros_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender, RGBColors.color6);
            OpenChildForm(new GestionJardin.frmCobros());
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            currentFormChild.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconChildFormCurrent.IconChar = IconChar.Home;
            iconChildFormCurrent.IconColor = Color.MediumPurple;
            lbl_Titulo.Text = "INICIO";
        }


        //Para arrastar el form desde el panel de titulo

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void panel_Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lbl_Hora.Text = DateTime.Now.ToString("HH:mm:ss");
            lbl_Fecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea salir?", "Aviso", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)  //si el estado de la ventana es normal se maximiza de lo contrario se restaura al tamaño del form
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
