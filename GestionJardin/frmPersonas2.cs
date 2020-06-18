using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GestionJardin
{
    public partial class frmPersonas2 : Form
    {
        metTipoPersona objMetTipoPersona = new metTipoPersona();
        entPersona objPersona = new entPersona();
        entTipoPersona.enTipoPersonaColeccion tipoPersonaCol = new entTipoPersona.enTipoPersonaColeccion();
        metSalas objMetSalas = new metSalas();
        metPersonas objMetPersonas = new metPersonas();
        metDomicilio objmetDomicilio = new metDomicilio();

        int EdadAnos;
        int EdadMeses;
        string resultadoValidacion;
        int idPersonaBuscar;

        string salas = ""; //cupo
        int contadorSala = 10; //cupo

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

            lblSalasCupo.Visible = false;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            limpiarCampos();

            panelDatos.Visible = false;
            panelContacto.Visible = false;
            panelSala.Visible = false;
            panelBotones.Visible = false;
            panlBtnEditar.Visible = false;


            panelBusqueda.Visible = false;
            cbTipoPersona2.SelectedItem = null;
            lblAyuda.Text = "Elija el tipo de Persona.";
            panelAgregar.Visible = true;

            //txtNombre.ShowButton = true;
            onOffCampos(true);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            limpiarCampos();

            panelDatos.Visible = false;
            panelContacto.Visible = false;
            panelSala.Visible = false;
            panelBotones.Visible = false;
            panlBtnEditar.Visible = false;

            panelAgregar.Visible = false;
            cbTipoPersona.SelectedItem = null;
            txtBuscarPersona.Enabled = false;
            txtBuscarPersona.Text = null;
            lblAyuda.Text = "Ingrese el tipo de Persona y el Nombre.";
            panelBusqueda.Visible = true;

            onOffCampos(false);

            lblSalasCupo.Visible = false; //cupo
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

            if (cbTipoPersona2.SelectedValue != null)
            { //para evitar que ingrese en el Load
                if ((cbTipoPersona2.SelectedValue.ToString() == "2"))
                {

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

        }

        private void cbTurno_SelectedValueChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(cbTurno.SelectedIndex);

            //Rellena el combo de salas
            string indexTurno = cbTurno.SelectedIndex.ToString();
            cbSala.DataSource = objMetSalas.ListarSalas(indexTurno);
            cbSala.DisplayMember = "SAL_NOMBRE";
            cbSala.ValueMember = "SAL_ID";

            cbSala.SelectedItem = null;

            if (cbTipoPersona2.SelectedValue != null)
            { //para evitar que ingrese en el Load
              //Derivo a cada alumno a su sala correspondiente  ----> REVISAR CON ROMI Y PARAMETRIZAR EN LA BASE
                if ((cbTipoPersona2.SelectedValue.ToString() == "2"))
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
                    else if (EdadAnos == 4 || (EdadAnos == 5 && EdadMeses > 6))
                    {
                        cbSala.SelectedIndex = cbSala.FindStringExact("VERDE");
                        cbSala.Enabled = false;
                        // cbo_SalTurnoA
                        cbTurno.SelectedIndex = cbTurno.FindStringExact("MAÑANA");
                        cbTurno.Enabled = false;

                    }
                }
            }

         //   salas = "El cupo de la sala " + cbSala.SelectedItem.ToString() + " es de " + Convert.ToString(contadorSala) + " vacantes."; // cupo
         //   lblSalasCupo.Text = salas; //cupo
         //   lblSalasCupo.Visible = true; // cupo

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
               
                string id_sala;
                if (cbSala.SelectedItem == null)
                {
                    id_sala = "";
                }
                else
                {
                    id_sala = cbSala.SelectedValue.ToString();
                }

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
                personaInsert.PER_TPE_ID = cbTipoPersona2.SelectedValue.ToString();
                personaInsert.PER_LEGAJO = legajo;
                personaInsert.PER_ESTADO = "1";


                metPersonas metPersona = new metPersonas();
                string resultado = metPersona.Insertar(personaInsert); // INSERTA PERSONA
                //nombre = "RAMON";
                //apellidos = "LOPEZ";
                //documento = "25654987";

                if (resultado == "OK") { // entra a insertar el domicilio de la persona solo si inserto la persona correctamente
                    //string id_persona = metPersona.BuscaPersona(nombre, apellidos, documento); // TRAE EL ID RECIEN INSERTADO
                    personaInsert = metPersona.BuscaPersona(nombre, apellidos, documento); // TRAE EL ID RECIEN INSERTADO
                    Int32 id_persona = personaInsert.PER_ID;

                    //INSERTA DOMICILIO
                    entDomicilio domicilioInsertar = new entDomicilio();

                    domicilioInsertar.DOM_PER_ID = id_persona;
                    domicilioInsertar.DOM_CALLE = calle;
                    domicilioInsertar.DOM_NUMERO = Convert.ToInt32(numero);
                    if (string.IsNullOrWhiteSpace(piso.Trim()) == true)
                    {
                        
                    } else
                    {
                        domicilioInsertar.DOM_PISO = Convert.ToInt32(piso);
                    }
                    
                    
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

                        contadorSala -= 1; // cupo
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
            txtNombre.Style = MetroFramework.MetroColorStyle.Default;
            txtApellidos.Text = "";
            txtApellidos.Style = MetroFramework.MetroColorStyle.Default;
            txtDocumento.Text = "";
            txtDocumento.Style = MetroFramework.MetroColorStyle.Default;

            dtNacimiento.Value = dtNacimiento.MaxDate;
            cbGenero.SelectedItem = null;


            txtCalle.Text = "";
            txtCalle.Style = MetroFramework.MetroColorStyle.Default;
            txtNumero.Text = "";
            txtNumero.Style = MetroFramework.MetroColorStyle.Default;
            txtCPostal.Text = "";
            txtCPostal.Style = MetroFramework.MetroColorStyle.Default;
            txtPiso.Text = "";
            txtPiso.Style = MetroFramework.MetroColorStyle.Default;
            txtDepto.Text = "";
            txtDepto.Style = MetroFramework.MetroColorStyle.Default;
            txtBarrio.Text = "";
            txtBarrio.Style = MetroFramework.MetroColorStyle.Default;
            txtTelefono.Text = "";
            txtTelefono.Style = MetroFramework.MetroColorStyle.Default;
            txtCelular.Text = "";
            txtCelular.Style = MetroFramework.MetroColorStyle.Default;
            txtEmail.Text = "";
            txtEmail.Style = MetroFramework.MetroColorStyle.Default;


            cbSala.SelectedItem = null; ;
            cbTurno.SelectedItem = null; ;
            txtLegajo.Text = "--";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            //validaCampos(); //---> solo testing
            metParametricas parametrica = new metParametricas();
            string lolo = parametrica.secuenciadorLegajoAlumnos();
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

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }       

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void txtCPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void txtPiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void txtBuscarPersona_ButtonClick(object sender, EventArgs e)
        {
            string nombreB = "";
            string apellidoB = "";
            string documentoB = "";
            int contador = 0;

            string busqueda = txtBuscarPersona.Text;

            char[] separadores = { ',', '(', ')'};
            string[] palabras = busqueda.Split(separadores);

            foreach (var palabra in palabras)
            {
                contador += 1;
                if (contador == 1)
                {
                    nombreB = palabra.Trim();
                } else if (contador == 2)
                {
                    apellidoB = palabra.Trim();
                } else if (contador == 3)
                {
                    documentoB = palabra.Trim();
                }
            }

            entPersona personaBuscar = new entPersona();
            personaBuscar = objMetPersonas.BuscaPersona(nombreB, apellidoB, documentoB);
            entDomicilio domicilioBuscar = new entDomicilio();
            domicilioBuscar = objmetDomicilio.buscarDomicilioXPersona(personaBuscar.PER_ID);

            if (personaBuscar.PER_NOMBRE != null)
            {
                idPersonaBuscar = personaBuscar.PER_ID; // se usara en el editar

                txtNombre.Text = personaBuscar.PER_NOMBRE;
                //txtNombre.Style = MetroFramework.MetroColorStyle.Default;
                txtApellidos.Text = personaBuscar.PER_APELLIDO;
                //txtApellidos.Style = MetroFramework.MetroColorStyle.Default;
                txtDocumento.Text = Convert.ToString(personaBuscar.PER_DOCUMENTO);
                //txtDocumento.Style = MetroFramework.MetroColorStyle.Default;


                dtNacimiento.Value = personaBuscar.PER_FECHA_NAC;


                if (personaBuscar.PER_GENERO.StartsWith("M"))
                {
                    cbGenero.SelectedIndex = cbSala.FindStringExact("MASCULINO");
                }
                else
                {
                    cbGenero.SelectedIndex = cbSala.FindStringExact("FEMENINO");
                }


                txtCalle.Text = domicilioBuscar.DOM_CALLE;
                //txtCalle.Style = MetroFramework.MetroColorStyle.Default;
                txtNumero.Text = Convert.ToString(domicilioBuscar.DOM_NUMERO);
                //txtNumero.Style = MetroFramework.MetroColorStyle.Default;
                txtCPostal.Text = Convert.ToString(domicilioBuscar.DOM_CP);
                //txtCPostal.Style = MetroFramework.MetroColorStyle.Default;
                txtPiso.Text = Convert.ToString(domicilioBuscar.DOM_PISO);
                //txtPiso.Style = MetroFramework.MetroColorStyle.Default;
                txtDepto.Text = domicilioBuscar.DOM_DPTO;
                //txtDepto.Style = MetroFramework.MetroColorStyle.Default;
                txtBarrio.Text = domicilioBuscar.DOM_BARRIO;
                //txtBarrio.Style = MetroFramework.MetroColorStyle.Default;
                txtTelefono.Text = personaBuscar.PER_TELEFONO;
                //txtTelefono.Style = MetroFramework.MetroColorStyle.Default;
                txtCelular.Text = personaBuscar.PER_TELEFONO_2;
                //txtCelular.Style = MetroFramework.MetroColorStyle.Default;
                txtEmail.Text = personaBuscar.PER_EMAIL;
                //txtEmail.Style = MetroFramework.MetroColorStyle.Default;

                panelDatos.Visible = true;
                panelContacto.Visible = true;
                panelSala.Visible = false;
                panelBotones.Visible = false;
                panlBtnEditar.Visible = true;

                if ((cbTipoPersona.SelectedValue.ToString() == "2"))
                {
                    entSala salaBuscar = new entSala();
                    salaBuscar = objMetSalas.buscarSalaXPersona(personaBuscar.PER_ID);


                    if (salaBuscar.SALA_TURNO.Trim() == "TARDE")
                    {
                        cbTurno.SelectedIndex = cbTurno.FindStringExact("TARDE");
                    } else
                    {
                        cbTurno.SelectedIndex = cbTurno.FindStringExact("MAÑANA");
                    }

                    string indexTurno = cbTurno.SelectedIndex.ToString();
                    cbSala.DataSource = objMetSalas.ListarSalas(indexTurno);
                    cbSala.DisplayMember = "SAL_NOMBRE";
                    cbSala.ValueMember = "SAL_ID";

                    cbSala.SelectedIndex = cbSala.FindStringExact(salaBuscar.SAL_NOMBRE);
                    txtLegajo.Text = personaBuscar.PER_LEGAJO;

                    panelSala.Visible = true;
                }

                onOffCampos(false);
            }
        }

        private void onOffCampos(bool onOff)
        {

            txtNombre.Enabled = onOff;
            //txtNombre.Style = MetroFramework.MetroColorStyle.Default;
            txtApellidos.Enabled = onOff;
            //txtApellidos.Style = MetroFramework.MetroColorStyle.Default;
            txtDocumento.Enabled = onOff;
            //txtDocumento.Style = MetroFramework.MetroColorStyle.Default;

            dtNacimiento.Enabled = onOff;
            cbGenero.Enabled = onOff;


            txtCalle.Enabled = onOff;
            //txtCalle.Style = MetroFramework.MetroColorStyle.Default;
            txtNumero.Enabled = onOff;
            //txtNumero.Style = MetroFramework.MetroColorStyle.Default;
            txtCPostal.Enabled = onOff;
            //txtCPostal.Style = MetroFramework.MetroColorStyle.Default;
            txtPiso.Enabled = onOff;
            //txtPiso.Style = MetroFramework.MetroColorStyle.Default;
            txtDepto.Enabled = onOff;
            //txtDepto.Style = MetroFramework.MetroColorStyle.Default;
            txtBarrio.Enabled = onOff;
            //txtBarrio.Style = MetroFramework.MetroColorStyle.Default;
            txtTelefono.Enabled = onOff;
            //txtTelefono.Style = MetroFramework.MetroColorStyle.Default;
            txtCelular.Enabled = onOff;
            //txtCelular.Style = MetroFramework.MetroColorStyle.Default;
            txtEmail.Enabled = onOff;
            //txtEmail.Style = MetroFramework.MetroColorStyle.Default;


            cbSala.Enabled = onOff;
            cbTurno.Enabled = onOff;
            txtLegajo.Enabled = onOff;
        }

        private void btnBloqueo_Click(object sender, EventArgs e)
        {
            if (this.btnBloqueo.IconChar == FontAwesome.Sharp.IconChar.Lock) { 
                this.btnBloqueo.IconChar = FontAwesome.Sharp.IconChar.Unlock;
                onOffCampos(true);
            } else
            {
                this.btnBloqueo.IconChar = FontAwesome.Sharp.IconChar.Lock;
                onOffCampos(false);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Función que valide todos los campos

            string validacionE = validaCampos();

            if (validacionE == "OK")
            {

                //-------- EDITA PERSONA

                string nombreE = txtNombre.Text.Trim();
                string apellidosE = txtApellidos.Text.Trim();
                string documentoE = txtDocumento.Text.Trim();
                DateTime nacimientoE = dtNacimiento.Value.Date;
                string generoE;
                if (cbGenero.SelectedItem == null)
                {
                    generoE = "";
                }
                else
                {
                    generoE = cbGenero.SelectedItem.ToString();
                }

                string calleE = txtCalle.Text.Trim();
                string numeroE = txtNumero.Text.Trim();
                string cpostalE = txtCPostal.Text.Trim();
                string pisoE = txtPiso.Text.Trim();
                string dptoE = txtDepto.Text.Trim();
                string barrioE = txtBarrio.Text.Trim();
                string telefonoE = txtTelefono.Text.Trim();
                string celularE = txtCelular.Text.Trim();
                string emailE = txtEmail.Text.Trim();

                //cbTurno.SelectedItem; no se agrega en ninguna tabla
                string id_salaE = cbSala.SelectedValue.ToString(); // debe tomar el id de la sala              

                entPersona personaEditar = new entPersona();

                personaEditar.PER_ID = idPersonaBuscar;
                personaEditar.PER_NOMBRE = nombreE;
                personaEditar.PER_APELLIDO = apellidosE;
                personaEditar.PER_DOCUMENTO = Convert.ToInt32(documentoE);
                personaEditar.PER_GENERO = generoE; //revisar
                personaEditar.PER_FECHA_NAC = nacimientoE;
                personaEditar.PER_TELEFONO = telefonoE;
                personaEditar.PER_TELEFONO_2 = celularE;
                personaEditar.PER_EMAIL = emailE;
                //personaInsert.PER_TPE_ID = cbTipoPersona2.SelectedValue.ToString();
                //personaInsert.PER_LEGAJO = legajo;
                //personaInsert.PER_ESTADO = "1";

                string resultadoE = objMetPersonas.editarPersona(personaEditar);

                //-------- EDITA DOMICILIO
                entDomicilio domicilioEditar = new entDomicilio();

                domicilioEditar.DOM_PER_ID = idPersonaBuscar;
                domicilioEditar.DOM_CALLE = calleE;
                domicilioEditar.DOM_NUMERO = Convert.ToInt32(numeroE);
                if (string.IsNullOrWhiteSpace(pisoE.Trim()) == true)
                {

                }
                else
                {
                    domicilioEditar.DOM_PISO = Convert.ToInt32(pisoE);
                }


                domicilioEditar.DOM_DPTO = dptoE;
                domicilioEditar.DOM_BARRIO = barrioE;
                domicilioEditar.DOM_CP = Convert.ToInt32(cpostalE);

                resultadoE = objmetDomicilio.editarDomicilio(domicilioEditar);

                //-------- EDITA SALA
                if ((cbTipoPersona.SelectedValue.ToString() == "2"))
                {
                    entGrupoSala grupoSalaEditar = new entGrupoSala();

                    grupoSalaEditar.GRS_PER_ID = Convert.ToInt32(idPersonaBuscar);
                    grupoSalaEditar.GRS_SAL_ID = Convert.ToInt32(id_salaE);

                    //metSalas metSalas = new metSalas();
                    resultadoE = objMetSalas.editarGrupoSala(grupoSalaEditar);

                }

                //al terminar de insertar Borra todos los campos
                if (resultadoE == "OK")
                {
                    MessageBox.Show("Se han editado los datos con éxito.", "Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("No olvide ingresar " + validacionE + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void soloLetras(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
        }

        private void txtCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
        }

        private void dtNacimiento_Leave(object sender, EventArgs e)
        {
            if (cbTipoPersona2.SelectedValue.ToString() == "1")

            {
                metPersonas ObjMetOersonas = new metPersonas();
                objMetPersonas.EdadDocente(dtNacimiento.Value);
            }


            if (cbTipoPersona2.SelectedValue.ToString() == "2")//el alumno no puede ingresar por ser menor de edad

                if (EdadAnos == 0 || (EdadAnos == 1 && EdadMeses > 6))
                {
                    MessageBox.Show("No está permitido el Ingreso de este alumno. Su edad es menor al año. ");


                }

            if (cbTipoPersona2.SelectedValue.ToString() == "2")//elalumno no puede ingresar por ser mayor de edad
                if (EdadAnos >= 6 || (EdadAnos == 5 && EdadMeses < 6))

                {
                    MessageBox.Show("No está permitido el Ingreso de este alumno. Supera la edad permitida por el establecimiento. ");

                }
        }

        private void txtDocumento_Leave(object sender, EventArgs e)
        {
            metPersonas ObjMetPersonas = new metPersonas();
            ObjMetPersonas.ValidarDni(txtDocumento.Text);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            metPersonas ObjMetPersonas = new metPersonas();
            ObjMetPersonas.ValidarEmail(txtEmail.Text);



            if (objMetPersonas.ValidarEmail(txtEmail.Text) == false)
            {
                MessageBox.Show("Ingrese un Email Válido");
                txtEmail.Clear();
                txtEmail.Focus();

            }
            
        }
    }
}
