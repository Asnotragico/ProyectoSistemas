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
    public partial class frmPersonas2 : Form
    {
        metTipoPersona objMetTipoPersona = new metTipoPersona();
        entPersona objPersona = new entPersona();
        entTipoPersona.enTipoPersonaColeccion tipoPersonaCol = new entTipoPersona.enTipoPersonaColeccion();
        metSalas objMetSalas = new metSalas();

        public frmPersonas2()
        {
            InitializeComponent();

            //Llena comboBox TipoPersona
            tipoPersonaCol = objMetTipoPersona.buscarTipoPersonas();//buscarTipoPersonas
            cbTipoPersona.DataSource = new BindingSource(tipoPersonaCol, null);
            cbTipoPersona.DisplayMember = "TPE_NOMBRE";
            cbTipoPersona.ValueMember = "TPE_ID";
            cbTipoPersona.SelectedItem = null;

            cbTipoPersona2.DataSource = new BindingSource(tipoPersonaCol, null);
            cbTipoPersona2.DisplayMember = "TPE_NOMBRE";
            cbTipoPersona2.ValueMember = "TPE_ID";
            cbTipoPersona2.SelectedItem = null;
        }

        private void frmPersonas2_Load(object sender, EventArgs e)
        {       

            //Desabilita txtPersona
            txtBuscarPersona.Enabled = false;
            txtBuscarPersona.Style = MetroFramework.MetroColorStyle.Black;

            //Oculta paneles
            panelBusqueda.Visible = false;
            panelAgregar.Visible = false;
            panelDatos.Visible = false;
            panelContacto.Visible = false;
            panelSala.Visible = false;
            panelBotones.Visible = false;

            //Focus en el Label
            this.ActiveControl = null;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            panelBusqueda.Visible = false;
            cbTipoPersona2.SelectedItem = null;
            lblAyuda.Text = "Elija el tipo de Persona.";
            panelAgregar.Visible = true;

            //txtNombre.ShowButton = true;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            panelAgregar.Visible = false;
            cbTipoPersona.SelectedItem = null;
            txtBuscarPersona.Enabled = false;
            txtBuscarPersona.Text = null;
            lblAyuda.Text = "Ingrese el tipo de Persona y el Nombre.";
            panelBusqueda.Visible = true;
        }

        private void cbTipoPersona_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbTipoPersona.SelectedValue != null) { //para evitar que ingrese en el Load

            string id_tipoPersona = cbTipoPersona.SelectedValue.ToString();

                if ((id_tipoPersona != "GestionJardin.entTipoPersona")) //para evitar que ingrese en el Load
                {

                    //Autocompletar

                    AutoCompleteStringCollection alumnos = new AutoCompleteStringCollection();
                    metPersonas metPersonas = new metPersonas();
                    alumnos = metPersonas.traerPersonasAutocompetar(id_tipoPersona);

                    txtBuscarPersona.AutoCompleteMode = AutoCompleteMode.Suggest;
                    txtBuscarPersona.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txtBuscarPersona.AutoCompleteCustomSource = alumnos;

                    //Habilita txtPersona

                    txtBuscarPersona.Style = MetroFramework.MetroColorStyle.Blue;
                    txtBuscarPersona.Enabled = true;
                    txtBuscarPersona.Text = null;

                }
            }
        }

        private void cbTipoPersona2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbTipoPersona2.SelectedValue != null)
            { //para evitar que ingrese en el Load

                string id_tipoPersona = cbTipoPersona2.SelectedValue.ToString();

                //Funcion para limpiar campos

                //--->

                //Muestra campos para agregar

                panelDatos.Visible = true;
                panelContacto.Visible = true;
                panelSala.Visible = true;
                panelBotones.Visible = true;


            }
        }
    }
}
