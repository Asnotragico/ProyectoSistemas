using MetroFramework.Controls;
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
    public partial class frmConceptos2 : Form
    {

        metConcepto objMet_Conceptos = new metConcepto();
        entConcepto objConceptos = new entConcepto();
        DateTime fechaActual = DateTime.Today;
        DateTime fechaAlta;
        //  int anio;

        public frmConceptos2()
        {
            InitializeComponent();
        }

        private void frmConceptos2_Load(object sender, EventArgs e)
        {
            btnBuscar.Visible = true;
            btnAgregar.Visible = true;
            panelData.Visible = true;
            panelBusqueda.Visible = false;
            panelAcciones.Visible = false;

            dgv_ConVisualizar.DataSource = objMet_Conceptos.Visualizar();
            dgv_ConVisualizar.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Panel busqueda --> solo muestra los que sirve para buscar un concepto en particular
            panelBusqueda.Visible = true;
         //   cboEstadoB.Visible = true; //hasta aqui muestra
            txtBuscarConcepto.Visible = true; //hasta aqui muestra
            lblControlOtros.Visible = true;
            //string estado = cboEstadoB.SelectedItem.ToString();
            objMet_Conceptos.autocompletarBuscar(txtBuscarConcepto);

         //   txtBuscarConcepto.Visible = true;

            cbo_Conceptos.Visible = false; //Oculta
            txt_Otros.Visible = false; //oculta
            lblControlOtros.Visible = false;


            //Panel abm
            panelAcciones.Visible = false;

            //Panel data
            panelData.Visible = true;

            //grilla
            dgv_ConVisualizar.DataSource = objMet_Conceptos.Visualizar();
            dgv_ConVisualizar.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            limpiarCampos();
            //Panel busqueda --> solo muestra los que sirve para buscar un concepto en particular
            panelBusqueda.Visible = true;
            cbo_Conceptos.Visible = true; //hasta aqui muestra
            txt_Otros.Visible = false; //Oculta
            txtBuscarConcepto.Visible = false;
          //  cboEstadoB.Visible = false;
            lblControlOtros.Visible = false;



        }

        private void cbo_Conceptos_SelectedIndexChanged(object sender, EventArgs e)
        {

            int v_otros = cbo_Conceptos.SelectedIndex;
            // lblControlOtros.Visible = false;


            if (v_otros == 8) //solo se puede cargar un item fuera de los comprendidos si selecciona "OTRO"
            {
                txt_Otros.Visible = true;
                lblControlOtros.Visible = true;


                cboSemestre.Items.Remove(0);
                cboSemestre.Items.Remove(1);
                cboSemestre.Items.Remove(2);
                cboSemestre.Items.Add(1);
                cboSemestre.Items.Add(2);
            }
            else if (v_otros == 0)
            {
                txt_Otros.Visible = false;
                lblControlOtros.Visible = false;


                cboSemestre.Items.Remove(0);
                cboSemestre.Items.Remove(1);
                cboSemestre.Items.Remove(2);
                cboSemestre.Items.Add(0);

            }
            else
            {
                txt_Otros.Visible = false;
                lblControlOtros.Visible = false;


                cboSemestre.Items.Remove(0);
                cboSemestre.Items.Remove(1);
                cboSemestre.Items.Remove(2);
                cboSemestre.Items.Add(1);
                cboSemestre.Items.Add(2);
            }

            //info global se oculta
            lbl_Titulo.Visible = false;
            panelData.Visible = false;


            //Panel abm
            panelAcciones.Visible = true;
            btnGuardarIngresar.Visible = true;
            btnCancelarIngresar.Visible = true;

            cbo_Estado.Visible = false;
            btnBloqueo.Visible = false;
            lblEditar.Visible = false;
        }

        private void btnGuardarIngresar_Click(object sender, EventArgs e)
        {
            //Se cargan los contenidos siempre y cuando esten completos

            if (ValidarCampos())
            {

                string concepto = cbo_Conceptos.SelectedItem.ToString();
                decimal monto = Convert.ToDecimal(txtMonto.Text);
                DateTime fechaAlta = dt_FechaAlta.Value.Date;
                int anio = Convert.ToInt32(txtAnio.Text);
                int semestre = Convert.ToInt32(cboSemestre.SelectedItem.ToString());

                DateTime fechaFin = DateTime.MaxValue;
                int anioActual = fechaActual.Year;

                int control = 0;

                if (anio < anioActual)
                {
                    lblErrorAnio.Text = "Ingrese un añor mayor o igual al actual";
                    control = 1;
                }
                else
                {
                    objConceptos.CON_PERIODO = anio;
                    control = 0;
                }

                // Carga datos de la clase concepto
                objConceptos.CON_CONCEPTO = concepto;
                objConceptos.CON_VALOR_ACTUAL = monto;
                objConceptos.CON_FECHA_INI = fechaAlta;
                objConceptos.CON_FECHA_FIN = fechaFin;
                objConceptos.CON_FECHA_ACT = fechaAlta;
                objConceptos.CON_SEMESTRE = semestre;
                objConceptos.CON_ACTIVO = "S";





                if (control == 0)
                {
                    if (objConceptos.CON_CONCEPTO != "OTROS")
                    {
                        if (objMet_Conceptos.ValidarConcepto(objConceptos.CON_CONCEPTO, objConceptos.CON_PERIODO, objConceptos.CON_SEMESTRE) == 0)
                        {
                            MessageBox.Show(objMet_Conceptos.InsertarConcepto(objConceptos));
                            limpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("YA EXISTE el concepto: " + objConceptos.CON_CONCEPTO + " para el año: " + objConceptos.CON_PERIODO.ToString() + " y semestre: " + objConceptos.CON_SEMESTRE.ToString()
                                            + "\n Por favor verifique el AÑO y SEMESTRE ingresado o verifique el mismo en la opcion BUSCAR(lupa) y modifique lo que crea necesario");
                        }
                    }
                    else if (objConceptos.CON_CONCEPTO == "OTROS")
                    {
                        objConceptos.CON_CONCEPTO = txt_Otros.Text;

                        if (objMet_Conceptos.ValidarConcepto(objConceptos.CON_CONCEPTO, objConceptos.CON_PERIODO, objConceptos.CON_SEMESTRE) == 0)
                        {
                            MessageBox.Show(objMet_Conceptos.InsertarConcepto(objConceptos));
                            limpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("YA EXISTE el concepto: " + objConceptos.CON_CONCEPTO + " para el año: " + objConceptos.CON_PERIODO.ToString() + " y semestre: " + objConceptos.CON_SEMESTRE.ToString()
                                            + "\n Por favor verifique el AÑO y SEMESTRE ingresado o verifique el mismo en la opcion BUSCAR(lupa) y modifique lo que crea necesario");
                        }

                    }

                }
            }

        }

        /*************************************************

            VALIDACION TIPOS DE DATOS

        **************************************************/

        // VALIDA SOLO EL INGRESO DE LETRAS O CARACTERES
        private void soloLetras(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);

        }

        // VALIDA SOLO EL INGRESO DE NUMEROS
        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }


        // En el campo MONTO se ingresan solo NUMEROS--- consultar con GASTON COMO HACER CON DECIMALES
        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
            lblControlMonto.Visible = true;
            txtMonto.Style = MetroFramework.MetroColorStyle.Green;
            epError.Clear();
        }

        // En el campo AÑO se ingresan solo NUMEROS
        private void txtAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
            lblErrorAnio.Visible = false;
            lblControlAnio.Visible = true;
            txtAnio.Style = MetroFramework.MetroColorStyle.Green;
            epError.Clear();

        }

        // En el campo OTROS se ingresan solo LETRAS
        private void txt_Otros_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
            lblControlOtros.Visible = true;
            txt_Otros.Style = MetroFramework.MetroColorStyle.Green;
            epError.Clear();

        }


        /*******************************************

            VALIDACION INGRESO DE DATOS INDIVIDUAL POR CAMPO

        *******************************************/

        //Se valida que la FECHA DE ALTA sea >= a la actual

        private void dt_FechaAlta_ValueChanged(object sender, EventArgs e)
        {

            epError.Clear();
            dt_FechaAlta.Style = MetroFramework.MetroColorStyle.Green;

            fechaAlta = dt_FechaAlta.Value.Date;


            if (fechaAlta < fechaActual)
            {
                lblErrorFecha.Text = "Ingrese una fecha mayor o igual a la actual";
            }
            else
            {
                lblErrorFecha.Text = "";
            }

        }

        //Se valida que se hayan ingresado valores en el MONTO

        private void txtMonto_Validated(object sender, EventArgs e)
        {
            if (txtMonto.Text.Trim() == "")
            {
                lblControlMonto.Visible = false;
                epError.SetError(txtMonto, "Introduce el MONTO del concepto, SOLO NUMEROS por ejemplo 2300");
                txtMonto.Style = MetroFramework.MetroColorStyle.Red;
                txtMonto.Focus();
            }

        }

        //Se valida que se hayan ingresado valores en el campo OTROS

        private void txt_Otros_Validated(object sender, EventArgs e)
        {
            if (txt_Otros.Text.Trim() == "")
            {
                lblControlOtros.Visible = false;
                epError.SetError(txt_Otros, "Introduce el NOMBRE del concepto, SOLO LETRAS por ejemplo: 'PASEO'");
                txt_Otros.Style = MetroFramework.MetroColorStyle.Red;
                txt_Otros.Focus();
            }
        }

        //Se valida que se hayan ingresado valores en el campo AÑO

        private void txtAnio_Validated(object sender, EventArgs e)
        {
            if (txtAnio.Text.Trim() == "")
            {
                lblControlAnio.Visible = false;
                epError.SetError(txtAnio, "Introduce un AÑO igual o mayor al actual para el periodo del concepto, SOLO NUMEROS.");
                txtAnio.Style = MetroFramework.MetroColorStyle.Red;
                txtAnio.Focus();
            }
        }

        //Se valida que se seleccione al menos un valor para el SEMESTRE 

        private void cboSemestre_Validated(object sender, EventArgs e)
        {
            if (cboSemestre.SelectedIndex == -1)
            {
                lblControlSemestre.Visible = false;
                epError.SetError(cboSemestre, "Seleccione un SEMESTRE. (0 = no corresponde - 1 = PRIMER SEMESTRE - 2 = SEGUNDO SEMESTRE)");
                cboSemestre.Style = MetroFramework.MetroColorStyle.Red;
                cboSemestre.Theme = MetroFramework.MetroThemeStyle.Light;
                cboSemestre.Focus();
            }
        }

        // VER CON GASTON O EL PROFE COMO COMPROBAR CON LA FECHA !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


        //Si se ingresa un valor para el SEMESTRE se retornan los campos a su formato a inicial

        private void cboSemestre_SelectedValueChanged(object sender, EventArgs e)
        {
            lblControlSemestre.Visible = true;
            lblErrorSemestre.Visible = false;
            cboSemestre.Style = MetroFramework.MetroColorStyle.Green;
            cboSemestre.Theme = MetroFramework.MetroThemeStyle.Light;
            epError.Clear();
        }



        /*******************************************

            VALIDACION INGRESO DE DATOS GRUPAL

        *******************************************/


        private bool ValidarCampos()
        {
            bool ok = true;

            if (txtMonto.Text.Trim() == "")
            {
                ok = false;
                lblControlMonto.Visible = false;
                epError.SetError(txtMonto, "Introduce el MONTO del concepto, SOLO NUMEROS por ejemplo 2300");
                txtMonto.Style = MetroFramework.MetroColorStyle.Red;
                txtMonto.Focus();
            }
            if (txtAnio.Text.Trim() == "")
            {
                ok = false;
                lblControlAnio.Visible = false;
                epError.SetError(txtAnio, "Introduce un AÑO igual o mayor al actual para el periodo del concepto, SOLO NUMEROS.");
                txtAnio.Style = MetroFramework.MetroColorStyle.Red;
                txtAnio.Focus();
            }
            if (cboSemestre.SelectedIndex == -1)
            {
                ok = false;
                lblControlSemestre.Visible = false;
                epError.SetError(cboSemestre, "Seleccione un SEMESTRE. (0 = no corresponde - 1 = PRIMER SEMESTRE - 2 = SEGUNDO SEMESTRE)");
                cboSemestre.Style = MetroFramework.MetroColorStyle.Red;
                cboSemestre.Theme = MetroFramework.MetroThemeStyle.Light;
                cboSemestre.Focus();
            }
            else
            {
                ok = true;
            }

            return ok;
        }


        private void limpiarCampos()
        {
            txt_Otros.Text = "";
            txt_Otros.Style = MetroFramework.MetroColorStyle.Green;

            txtMonto.Text = "";
            txtMonto.Style = MetroFramework.MetroColorStyle.Green;

            txtAnio.Text = "";
            txtMonto.Style = MetroFramework.MetroColorStyle.Green;

            dt_FechaAlta.Value = DateTime.Today;
            cboSemestre.SelectedItem = null;
            cbo_Conceptos.SelectedItem = null;
            cboSemestre.Theme = MetroFramework.MetroThemeStyle.Light;

        }

        private void btnCancelarIngresar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

               
    }
}

