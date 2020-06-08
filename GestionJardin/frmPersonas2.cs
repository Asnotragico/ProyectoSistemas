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

        int EdadAnos;
        int EdadMeses;
        string resultadoValidacion;

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
            panlBtnEditar.Visible = false;

            //Focus en el Label
            this.ActiveControl = null;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            limpiarCampos();

            panelDatos.Visible = false;
            panelContacto.Visible = false;
            panelBotones.Visible = false;
            panlBtnEditar.Visible = false;

            panelBusqueda.Visible = false;
            panlBtnEditar.Visible = false;
            cbTipoPersona2.SelectedItem = null;
            lblAyuda.Text = "Elija el tipo de Persona.";
            panelAgregar.Visible = true;

            //txtNombre.ShowButton = true;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            limpiarCampos();

            panelDatos.Visible = false;
            panelContacto.Visible = false;
            panelBotones.Visible = false;
            panlBtnEditar.Visible = false;

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

                limpiarCampos();

                //Muestra campos para agregar

                panelDatos.Visible = true;
                panelContacto.Visible = true;              
                panelBotones.Visible = true;

                if ((cbTipoPersona2.SelectedValue.ToString() == "2") || (cbTipoPersona2.SelectedValue.ToString() == "1")) //si se elije DOCENTE o ALUMNO entra
                {
                    Console.WriteLine("entra");
                    panelSala.Visible = true;

                    if ((cbTipoPersona2.SelectedValue.ToString() == "2")) // si es ALUMNO ENTRA
                    {
                        cbTurno.Enabled = true;
                        cbTurno.SelectedItem = null;
                        cbSala.Enabled = false;
                        cbSala.SelectedItem = null;
                        txtLegajo.Enabled = false; 
                    } 
                    else
                    {
                        cbTurno.Enabled = true;
                        cbTurno.SelectedItem = null;
                        cbSala.Enabled = true;
                        cbSala.SelectedItem = null;
                        txtLegajo.Enabled = false;
                    }

                }
                else
                {
                    panelSala.Visible = false;
                }


            }
        }

        private void dtNacimiento_ValueChanged(object sender, EventArgs e)
        {
            DateTime FechaReferencia = new DateTime(2020, 06, 30);

            if (cbTipoPersona2.SelectedValue.ToString() == "2") { 

                EdadAnos = (Convert.ToInt32(FechaReferencia.Year - dtNacimiento.Value.Year));
                EdadMeses = (Convert.ToInt32(FechaReferencia.Month - dtNacimiento.Value.Month));

                if
                    (FechaReferencia.Month < dtNacimiento.Value.Month)
                {
                    EdadMeses = (12 - (Convert.ToInt32(dtNacimiento.Value.Month)) + Convert.ToInt32((FechaReferencia.Month)));
                }


                if (EdadAnos == 3 && (EdadAnos == 4 && EdadMeses > 6))
                {
                    cbSala.SelectedIndex = cbSala.FindStringExact("NARANJA");
                    cbSala.Enabled = false;

                    cbTurno.SelectedIndex = cbTurno.FindStringExact("MAÑANA");
                    cbTurno.Enabled = false;

                }
                else if (EdadAnos == 4 || (EdadAnos == 5 && EdadMeses < 6))
                {
                    cbSala.SelectedIndex = cbSala.FindStringExact("VERDE");
                    cbSala.Enabled = false;
                    // cbo_SalTurnoA
                    cbTurno.SelectedIndex = cbTurno.FindStringExact("MAÑANA");
                    cbTurno.Enabled = false;

                }

            }

        }

        private void cbTurno_SelectedValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine(cbTurno.SelectedIndex);

            //Rellena el combo de salas
            string indexTurno = cbTurno.SelectedIndex.ToString();
            cbSala.DataSource = objMetSalas.ListarSalas(indexTurno);
            cbSala.DisplayMember = "SAL_NOMBRE";
            cbSala.ValueMember = "SAL_ID";

            cbSala.SelectedItem = null;

            //Derivo a cada alumno a su sala correspondiente  ----> REVISAR CON ROMI Y PARAMETRIZAR EN LA BASE
            if (cbTipoPersona2.SelectedValue.ToString() == "2")
            {

                if ((EdadAnos == 1) || (EdadAnos == 2 && EdadMeses <= 6))
                {
                    cbSala.SelectedIndex = cbSala.FindStringExact("ROSA");
                    cbSala.Enabled = false;
                    cbTurno.Enabled = true;
                    //string elegido = cbSala.SelectedValue.ToString(); forma de extraer el id de la sala
                }

                else if ((EdadAnos == 2 && EdadMeses > 6) || (EdadAnos == 3 && EdadMeses <= 6))
                {
                    cbSala.SelectedIndex = cbSala.FindStringExact("NARANJA");
                    cbSala.Enabled = false;
                    cbTurno.Enabled = true;

                }

                else if (EdadAnos == 3 && (EdadAnos == 4 && EdadMeses > 6))
                {
                    cbSala.SelectedIndex = cbSala.FindStringExact("NARANJA");
                    cbSala.Enabled = false;

                    cbTurno.SelectedIndex = cbTurno.FindStringExact("MAÑANA");
                    cbTurno.Enabled = false;

                }
                else if (EdadAnos == 4 || (EdadAnos == 5 && EdadMeses < 6))
                {
                    cbSala.SelectedIndex = cbSala.FindStringExact("VERDE");
                    cbSala.Enabled = false;
                    // cbo_SalTurnoA
                    cbTurno.SelectedIndex = cbTurno.FindStringExact("MAÑANA");
                    cbTurno.Enabled = false;

                }
            }


        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // Función que valide todos los campos

            string validacion = validaCampos();

            if (validacion == "OK") { 

                // Preparo la info de todos los campos

                string nombre = txtNombre.Text.Trim();
                string apellidos = txtApellidos.Text.Trim();
                string documento = txtDocumento.Text.Trim();
                DateTime nacimiento = dtNacimiento.Value.Date;
                string genero;
                if (cbGenero.SelectedItem == null)
                {
                    genero = "";
                } else
                {
                    genero = cbGenero.SelectedItem.ToString();
                }

            


                string calle = txtCalle.Text.Trim();
                string numero = txtNumero.Text.Trim();
                string cpostal = txtCPostal.Text.Trim();
                string piso = txtPiso.Text.Trim();
                string dpto = txtDepto.Text.Trim();
                string barrio = txtBarrio.Text.Trim();
                string telefono = txtTelefono.Text.Trim();
                string celular = txtCelular.Text.Trim();
                string email = txtEmail.Text.Trim();

                //cbTurno.SelectedItem; no se agrega en ninguna tabla
                string id_sala = cbSala.SelectedValue.ToString(); // debe tomar el id de la sala
                metParametricas metParametricas = new metParametricas();
                string legajo = metParametricas.secuenciadorLegajoAlumnos(); // lo genera solo
                //--------

                entPersona personaInsert = new entPersona();

                personaInsert.PER_NOMBRE = nombre;
                personaInsert.PER_APELLIDO = apellidos;
                personaInsert.PER_DOCUMENTO = Convert.ToInt32(documento);
                personaInsert.PER_GENERO = genero; //revisar
                personaInsert.PER_FECHA_NAC = nacimiento;
                personaInsert.PER_TELEFONO = telefono;
                personaInsert.PER_TELEFONO_2 = celular;
                personaInsert.PER_EMAIL = email;
                personaInsert.PER_TPE_ID = cbTipoPersona2.SelectedIndex.ToString();
                personaInsert.PER_LEGAJO = legajo;
                personaInsert.PER_ESTADO = "1";


                metPersonas metPersona = new metPersonas();
                string resultado = metPersona.Insertar(personaInsert); // INSERTA PERSONA
                //nombre = "RAMON";
                //apellidos = "LOPEZ";
                //documento = "25654987";

                if (resultado == "OK") { // entra a insertar el domicilio de la persona solo si inserto la persona correctamente
                    string id_persona = metPersona.BuscaPersona(nombre, apellidos, documento); // TRAE EL ID RECIEN INSERTADO

                    //INSERTA DOMICILIO
                    entDomicilio domicilioInsertar = new entDomicilio();

                    domicilioInsertar.DOM_PER_ID = Convert.ToInt32(id_persona);
                    domicilioInsertar.DOM_CALLE = calle;
                    domicilioInsertar.DOM_NUMERO = Convert.ToInt32(numero);
                    domicilioInsertar.DOM_PISO = Convert.ToInt32(piso);
                    domicilioInsertar.DOM_DPTO = dpto;
                    domicilioInsertar.DOM_BARRIO = barrio;
                    domicilioInsertar.DOM_CP = Convert.ToInt32(cpostal);


                    metDomicilio metDomicilio = new metDomicilio();
                    resultado = metDomicilio.Insertar(domicilioInsertar);

                    //INSERTA GRUPO SALA SOLO SI ES DOCENTE O ALUMNO
                    if ((cbTipoPersona2.SelectedValue.ToString() == "2") || (cbTipoPersona2.SelectedValue.ToString() == "1"))
                    {
                        entGrupoSala grupoSalaInsertar = new entGrupoSala();

                        grupoSalaInsertar.GRS_PER_ID = Convert.ToInt32(id_persona);
                        grupoSalaInsertar.GRS_SAL_ID = Convert.ToInt32(id_sala);

                        metSalas metSalas = new metSalas();
                        resultado = metSalas.insertarGrupoSala(grupoSalaInsertar);

                    }

                    //al terminar de insertar Borra todos los campos
                    if (resultado == "OK")
                    {
                        MessageBox.Show("Se ha ingresado el registro con éxito.", "Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarCampos();
                    }

                }
                

            }
            else
            {
                MessageBox.Show("No olvide ingresar " + validacion + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        } // termina el insertar

        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtDocumento.Text = "";
            dtNacimiento.Value = dtNacimiento.MaxDate;
            cbGenero.SelectedItem = null;


            txtCalle.Text = "";
            txtNumero.Text = "";
            txtCPostal.Text = "";
            txtPiso.Text = "";
            txtDepto.Text = "";
            txtBarrio.Text = "";
            txtTelefono.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";

            cbSala.SelectedItem = null; ;
            cbTurno.SelectedItem = null; ;
            txtLegajo.Text = "--";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            //validaCampos(); //---> solo testing
        }

        private string validaCampos()
        {
            resultadoValidacion = "";


            if (string.IsNullOrWhiteSpace(txtNombre.Text.Trim()) == true)
            {
                txtNombre.Style = MetroFramework.MetroColorStyle.Red;
                txtNombre.Focus();
                resultadoValidacion = "el Nombre";

            } else if (string.IsNullOrWhiteSpace(txtApellidos.Text.Trim()) == true)
            {
                txtApellidos.Style = MetroFramework.MetroColorStyle.Red;
                txtApellidos.Focus();
                resultadoValidacion = "el Apellido";

            } else if (string.IsNullOrWhiteSpace(txtDocumento.Text.Trim()) == true)
            {
                txtDocumento.Style = MetroFramework.MetroColorStyle.Red;
                txtDocumento.Focus();
                resultadoValidacion = "el Documento";

            } else if (string.IsNullOrWhiteSpace(txtCalle.Text.Trim()) == true)
            {
                txtCalle.Style = MetroFramework.MetroColorStyle.Red;
                txtCalle.Focus();
                resultadoValidacion = "la Calle del domicilio";

            } else if (string.IsNullOrWhiteSpace(txtNumero.Text.Trim()) == true)
            {
                txtNumero.Style = MetroFramework.MetroColorStyle.Red;
                txtNumero.Focus();
                resultadoValidacion = "el Numero del domicilio";

            } else if (string.IsNullOrWhiteSpace(txtCPostal.Text.Trim()) == true)
            {
                txtCPostal.Style = MetroFramework.MetroColorStyle.Red;
                txtCPostal.Focus();
                resultadoValidacion = "el Código Postal";

            } else if (string.IsNullOrWhiteSpace(txtBarrio.Text.Trim()) == true)
            {
                txtBarrio.Style = MetroFramework.MetroColorStyle.Red;
                txtBarrio.Focus();
                resultadoValidacion = "el Barrio";

            } else if (string.IsNullOrWhiteSpace(txtCelular.Text.Trim()) == true)
            {
                txtCelular.Style = MetroFramework.MetroColorStyle.Red;
                txtCelular.Focus();
                resultadoValidacion = "un Celular de contacto";

            } else if (string.IsNullOrWhiteSpace(txtEmail.Text.Trim()) == true)
            {
                txtEmail.Style = MetroFramework.MetroColorStyle.Red;
                txtEmail.Focus();
                resultadoValidacion = "el E-mail";

            } else
            {
                resultadoValidacion = "OK";
            }

            return resultadoValidacion;

        }
    }
}
