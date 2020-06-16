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
        DateTime fechaFin = DateTime.MaxValue;
        int idConceptoBuscar;
        decimal montoAct;
        string estadoIni;


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
            txtBuscarConcepto.Visible = true;
            lblControlOtros.Visible = true;

            objMet_Conceptos.autocompletarBuscar(txtBuscarConcepto);

            cbo_Conceptos.Visible = false;
            txt_Otros.Visible = false;
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
            cbo_Conceptos.Visible = true;
            txt_Otros.Visible = false;
            txtBuscarConcepto.Visible = false;
            lblControlOtros.Visible = false;

        }

        private void cbo_Conceptos_SelectedIndexChanged(object sender, EventArgs e)
        {

            int v_otros = cbo_Conceptos.SelectedIndex;

            if (v_otros == 8) //solo se puede cargar un item fuera de los comprendidos si selecciona "OTRO"
            {
                txt_Otros.Visible = true;
                lblControlOtros.Visible = true;
            }
            else
            {
                txt_Otros.Visible = false;
                lblControlOtros.Visible = false;
            }

            //info global se oculta
            lbl_Titulo.Visible = false;
            panelData.Visible = false;


            //Panel abm
            panelAcciones.Visible = true;
            btnGuardarIngresar.Visible = true;
            btnCancelarIngresar.Visible = true;
            btnGuardarEd.Visible = false;
            //btnCancelarEd.Visible = false;

            lblControlMonto.Visible = true;
            lblControlAnio.Visible = true;
            lblControlFecha.Visible = true;

            btnBloqueoEditar.Visible = false;
            lblEditar.Visible = false;

            cbo_Estado.Visible = false;
            btnBloqueoInactivar.Visible = false;
            lblDeshabilitar.Visible = false;
            lblErAnio.Visible = false;
            btnEliminar.Visible = false;
            btnEliminar.Visible = false;


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
                decimal montoAnterior = 0;

                int anioActual = fechaActual.Year;

                int control = 0;

                if (anio < anioActual)
                {

                    lblErAnio.Visible = true;
                    lblErAnio.Text = "Ingrese un añor mayor o igual al actual";
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
                objConceptos.CON_VALOR_ANTERIOR = montoAnterior;
                objConceptos.CON_ACTIVO = "S";


                if (control == 0)
                {
                    if (objConceptos.CON_CONCEPTO != "OTROS")
                    {
                        if (objMet_Conceptos.ValidarConcepto(objConceptos.CON_CONCEPTO, objConceptos.CON_PERIODO) == 0)
                        {
                            MessageBox.Show(objMet_Conceptos.InsertarConcepto(objConceptos));
                            limpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("YA EXISTE el concepto: " + objConceptos.CON_CONCEPTO + " para el año: " + objConceptos.CON_PERIODO.ToString()
                                            + "\n Por favor verifique el AÑO y SEMESTRE ingresado o verifique el mismo en la opcion BUSCAR(lupa) y modifique lo que crea necesario");
                        }
                    }
                    else if (objConceptos.CON_CONCEPTO == "OTROS")
                    {
                        objConceptos.CON_CONCEPTO = txt_Otros.Text;

                        if (objMet_Conceptos.ValidarConcepto(objConceptos.CON_CONCEPTO, objConceptos.CON_PERIODO) == 0)
                        {
                            MessageBox.Show(objMet_Conceptos.InsertarConcepto(objConceptos));
                            limpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("YA EXISTE el concepto: " + objConceptos.CON_CONCEPTO + " para el año: " + objConceptos.CON_PERIODO.ToString()
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
            lblErrorAnio.Visible = false; //no lo puedo encontrar por boba
            lblErAnio.Visible = false;
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
                lblControlFechaAlta.Text = "Ingrese una fecha mayor o igual a la actual";
            }
            else
            {
                lblControlFechaAlta.Text = "";
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
            cbo_Conceptos.SelectedItem = null;
            cbo_Estado.Visible = false;
            cbo_Estado.SelectedItem = null;
            txtBuscarConcepto.Text = "";

            btnBloqueoInactivar.Visible = false;
            lblDeshabilitar.Visible = false;
            btnEliminar.Visible = false;

        }

        private void btnCancelarIngresar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }



        private void txtBuscarConcepto_ButtonClick(object sender, EventArgs e)
        {
            panelData.Visible = false;
            panelAcciones.Visible = true;
            cbo_Estado.Visible = true;
            btnGuardarEd.Visible = true;

            lblErAnio.Visible = false;
            lblControlFecha.Visible = false;
            lblControlAnio.Visible = false;
            lblControlMonto.Visible = false;
            btnGuardarIngresar.Visible = false;
            btnEliminar.Visible = false;
            lblControlFecha.Visible = false;
            lblControlFechaAlta.Visible = false;


            lbl_Titulo.Visible = false;


            string conceptoB = "";
            string anioB = "";
            string estadoB = "";
            int contador = 0;

            string busqueda = txtBuscarConcepto.Text;

            char[] separadores = { '_', '(', ')' };
            string[] palabras = busqueda.Split(separadores);

            foreach (var palabra in palabras)
            {
                contador += 1;
                if (contador == 1)
                {
                    conceptoB = palabra.Trim();
                }
                else if (contador == 2)
                {
                    anioB = palabra.Trim();
                }
                else if (contador == 3)
                {
                    estadoB = palabra.Trim();
                }

            }


            if (estadoB == "ACTIVO")
            {
                estadoB = "S";
            }
            else if (estadoB == "INACTIVO")
            {
                estadoB = "N";
            }


            entConcepto conceptoBuscar = new entConcepto();
            conceptoBuscar = objMet_Conceptos.BuscaConcepto(conceptoB, anioB, estadoB);


            if (conceptoBuscar.CON_CONCEPTO != null)
            {
                idConceptoBuscar = conceptoBuscar.CON_ID; // se usara en el editar
                montoAct = conceptoBuscar.CON_VALOR_ACTUAL; // se usara en el editar
                                                            //  estadoIni = conceptoBuscar.CON_ACTIVO; // se usara en el editar

                txtMonto.Text = Convert.ToString(conceptoBuscar.CON_VALOR_ACTUAL);
                txtMonto.Style = MetroFramework.MetroColorStyle.Blue;
                dt_FechaAlta.Value = conceptoBuscar.CON_FECHA_INI;
                dt_FechaAlta.Style = MetroFramework.MetroColorStyle.Blue;
                txtAnio.Text = Convert.ToString(conceptoBuscar.CON_PERIODO);
                txtAnio.Style = MetroFramework.MetroColorStyle.Blue;

                cbo_Estado.SelectedValue = conceptoBuscar.CON_ACTIVO;
                cbo_Estado.Style = MetroFramework.MetroColorStyle.Blue;

                if (conceptoBuscar.CON_ACTIVO.StartsWith("S"))
                {
                    cbo_Estado.SelectedIndex = cbo_Estado.FindStringExact("ACTIVO");
                    estadoIni = "ACTIVO"; // se usara en el editar
                    btnBloqueoEditar.Visible = true;
                    lblEditar.Visible = true;
                    btnEliminar.Visible = true;
                    btnBloqueoInactivar.Visible = false;
                    lblDeshabilitar.Visible = false;
                    this.btnBloqueoInactivar.IconChar = FontAwesome.Sharp.IconChar.Lock;
                    //lblDeshabilitar.Visible = true;
                    //lblDeshabilitar.Text = "DESHABILITAR";
                }
                else
                {
                    cbo_Estado.SelectedIndex = cbo_Estado.FindStringExact("INACTIVO");
                    estadoIni = "INACTIVO";
                    btnBloqueoEditar.Visible = false;
                    lblEditar.Visible = false;
                    btnBloqueoInactivar.Visible = true;
                    lblDeshabilitar.Visible = true;
                    lblDeshabilitar.Text = "HABILITAR";

                }

            }

            txtMonto.Enabled = false;
            txtAnio.Enabled = false;
            dt_FechaAlta.Enabled = false;
            cbo_Estado.Enabled = false;
        }


        private void onOffCamposInactivar(bool onOff)
        {
            cbo_Estado.Enabled = onOff;
        }

        private void onOffCamposEditar(bool onOff)
        {
            txtMonto.Enabled = onOff;
            cbo_Estado.Enabled = false;
            btnEliminar.Visible = false;
        }

        private void btnBloqueoInactivar_Click(object sender, EventArgs e)
        {
            if (this.btnBloqueoInactivar.IconChar == FontAwesome.Sharp.IconChar.Lock)
            {
                this.btnBloqueoInactivar.IconChar = FontAwesome.Sharp.IconChar.Unlock;
                onOffCamposInactivar(true);
            }
            else
            {
                this.btnBloqueoInactivar.IconChar = FontAwesome.Sharp.IconChar.Lock;
                onOffCamposInactivar(false);
            }
        }

        private void cbo_Estado_SelectedValueChanged(object sender, EventArgs e)
        {

            string estado;
            if (cbo_Estado.SelectedItem == null)
            {
                estado = "";
            }
            else
            {
                estado = cbo_Estado.SelectedItem.ToString();
            }

            if (estado == "ACTIVO")
            {
                btnBloqueoEditar.Visible = true;
                lblEditar.Visible = true;
                btnEliminar.Visible = false;
                btnBloqueoInactivar.Visible = false;
                lblDeshabilitar.Visible = false;
            }
            else
            {
                btnBloqueoEditar.Visible = false;
                lblEditar.Visible = false;
            }
        }

        private void btnBloqueoEditar_Click(object sender, EventArgs e)
        {
            if (this.btnBloqueoEditar.IconChar == FontAwesome.Sharp.IconChar.Lock)
            {
                this.btnBloqueoEditar.IconChar = FontAwesome.Sharp.IconChar.Unlock;
                onOffCamposEditar(true);
            }
            else
            {
                this.btnBloqueoEditar.IconChar = FontAwesome.Sharp.IconChar.Lock;
                onOffCamposEditar(false);
                btnEliminar.Visible = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            btnBloqueoInactivar.Visible = true;
            lblDeshabilitar.Visible = true;
            lblDeshabilitar.Text = "DESHABILITAR";
            btnBloqueoEditar.Visible = false;
            lblEditar.Visible = false;
        }

        private void btnGuardarEd_Click(object sender, EventArgs e)
        {
            decimal montoE = Convert.ToDecimal(txtMonto.Text);

            string estadoE;

            if (cbo_Estado.SelectedItem == null)
            {
                estadoE = "";
            }
            else
            {
                estadoE = cbo_Estado.SelectedItem.ToString();
            }


            if (estadoE != estadoIni && montoE != montoAct)
            {
                objConceptos.CON_ID = idConceptoBuscar;
                objConceptos.CON_FECHA_ACT = fechaActual;
                objConceptos.CON_VALOR_ACTUAL = montoE;
                objConceptos.CON_VALOR_ANTERIOR = montoAct;
                objConceptos.CON_FECHA_FIN = fechaFin;
                
                MessageBox.Show(objMet_Conceptos.ActualizarMontoEstado(objConceptos));
                
            }
            else if (estadoE != estadoIni && montoE == montoAct)
            {
                if (estadoE == "INACTIVO")
                {
                    objConceptos.CON_ID = idConceptoBuscar;
                    objConceptos.CON_FECHA_ACT = fechaActual;
                    objConceptos.CON_FECHA_FIN = fechaActual;
                                       
                    MessageBox.Show(objMet_Conceptos.ActualizarEstadoN(objConceptos));

                }
                else if (estadoE == "ACTIVO")
                {
                    objConceptos.CON_ID = idConceptoBuscar;
                    objConceptos.CON_FECHA_ACT = fechaActual;
                    objConceptos.CON_FECHA_FIN = fechaFin;
                    
                    MessageBox.Show(objMet_Conceptos.ActualizarEstadoS(objConceptos));
                }
            }
            else if (estadoE == estadoIni && montoE != montoAct)
            {
                objConceptos.CON_ID = idConceptoBuscar;
                objConceptos.CON_FECHA_ACT = fechaActual;
                objConceptos.CON_VALOR_ACTUAL = montoE;
                objConceptos.CON_VALOR_ANTERIOR = montoAct;

                MessageBox.Show(objMet_Conceptos.ActualizarMonto(objConceptos));
            }
            else
            {
                MessageBox.Show("NO SE DETECTARON CAMBIOS A REALIZAR");
            }

        }
    }
}

