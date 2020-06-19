using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionJardin
{
    public partial class frmPopUpFlia : Form
    {
        public frmPopUpFlia()
        {
            InitializeComponent();
        }

        string LegajoMatriculado;

        private void frmPopUpFlia_Load(object sender, EventArgs e)
        {
            //Autocompletar

            AutoCompleteStringCollection alumnos = new AutoCompleteStringCollection();
            metPersonas metPersonas = new metPersonas();
            alumnos = metPersonas.traerPersonasAutocompetar("2");

            txtFamiliar.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtFamiliar.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtFamiliar.AutoCompleteCustomSource = alumnos;
        }

        public string Legajo
        {
            get { return LegajoMatriculado; }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFamiliar.Text) == false)
            {
                string nombreB = "";
                string apellidoB = "";
                string documentoB = "";
                int contador = 0;

                string busqueda = txtFamiliar.Text;

                char[] separadores = { ',', '(', ')' };
                string[] palabras = busqueda.Split(separadores);

                foreach (var palabra in palabras)
                {
                    contador += 1;
                    if (contador == 1)
                    {
                        nombreB = palabra.Trim();
                    }
                    else if (contador == 2)
                    {
                        apellidoB = palabra.Trim();
                    }
                    else if (contador == 3)
                    {
                        documentoB = palabra.Trim();
                    }
                }

                metPersonas objMetPersonas = new metPersonas();
                entPersona personaBuscar = new entPersona();
                personaBuscar = objMetPersonas.BuscaPersona(nombreB, apellidoB, documentoB);

                if (personaBuscar.PER_LEGAJO.ToString() != "")
                {
                    LegajoMatriculado = personaBuscar.PER_LEGAJO.ToString();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Debe seleccionar una persona.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {

                MessageBox.Show("Por favor ingrese un Nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
