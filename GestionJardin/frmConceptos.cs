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

    public partial class frmConceptos : Form
    {
        metConcepto objMet_Conceptos = new metConcepto();
        entConcepto objConceptos = new entConcepto();




        public frmConceptos()
        {

            InitializeComponent();

        }

        private void frmConceptos_Load(object sender, EventArgs e)
        {

            panelConData.Show();
            //dgv_ConVisualizar.Visible = true;
            panelConBuscar.Show();
            panel_ConMenu2.Show();
            panel_Con_Ingresar.Visible = false;
            panel_ConEditar.Visible = false;
            panel_ConEliminar.Visible = false;

            objMet_Conceptos.autocompletarBuscar(txt_ConBuscar);

            panel_ConAbm.BackColor = Color.FromArgb(45, 66, 91);

            dgv_ConVisualizar.DataSource = objMet_Conceptos.Visualizar();
            dgv_ConVisualizar.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        //*********************************************************
        //BOTON AGREGAR SIGNO +, SE APRIETA Y CARGA FORM DE INSERTAR a traves del metodo InicializarCon
        //*********************************************************

        private void icBtn_AgregarConc_Click_1(object sender, EventArgs e)
        {

           objMet_Conceptos.InicializarCon(panelConBuscar, panel_ConEditar, panel_ConEliminar, panel_Con_Ingresar, panel_ConAbm, cbo_IngresarCon, txt_Con_MontoI,
                                            txt_ConAnioI, dt_FechaAlta, cbo_ConSemestreI, txt_OtrosCon);

        }

        // PERMITE INGRESAR OTRO CONCEPTO QUE NO SE ENCUENTRE COMPRENDIDO ENTRE LOS CONSTANTES DEL JARDIN

        private void cbo_IngresarCon_SelectedIndexChanged(object sender, EventArgs e)
        {
            int v_otros = cbo_IngresarCon.SelectedIndex;

            if (v_otros == 8)
            {
                txt_OtrosCon.Visible = true;
                cbo_IngresarCon.Size = new Size(126, 30);
            }
        }


        //*********************************************************
        // BOTON GUARDAR DEL INSERTAR-- LLAMA AL METODO InsertarConcepto

        private void Ibtn_ConGuardar_Click(object sender, EventArgs e)
        {
            objConceptos.CON_CONCEPTO = cbo_IngresarCon.SelectedItem.ToString();
            objConceptos.CON_VALOR_ACTUAL = Convert.ToDouble(txt_Con_MontoI.Text);
            objConceptos.CON_FECHA_INI = dt_FechaAlta.Value;
            objConceptos.CON_PERIODO = Convert.ToInt32(txt_ConAnioI.Text);
            objConceptos.CON_SEMESTRE = Convert.ToInt32(cbo_ConSemestreI.SelectedItem);
            objConceptos.CON_FECHA_ACT = DateTime.Today;

            int v_controlInsertar = 0;
            DateTime v_fechaFinI = DateTime.MaxValue;

            //Se controla que ingrese una fecha valida
            if (objConceptos.CON_FECHA_INI >= objConceptos.CON_FECHA_ACT)
            {
                v_controlInsertar = 0;
            }
            else
            {
                v_controlInsertar = 1;
                MessageBox.Show("Error; " + v_controlInsertar.ToString() + ". Ingrese una FECHA valida por favor. " + Convert.ToString(objConceptos.CON_FECHA_INI.ToShortDateString()));
            }

            //Se controla que ingrese un semestre dentro de los comprendidos
            if (objConceptos.CON_SEMESTRE == 0 || objConceptos.CON_SEMESTRE == 1 || objConceptos.CON_SEMESTRE == 2)
            {
                v_controlInsertar = 0;
            }
            else
            {
                v_controlInsertar = 2;
                MessageBox.Show("Error; " + v_controlInsertar.ToString() + ".Ingrese un SEMESTRE valido por favor. ");
            }

            //Se controla que el ingrese un año actual
            if (objConceptos.CON_PERIODO >= 2020 && objConceptos.CON_PERIODO <= 9998)
            {
                v_controlInsertar = 0;
            }
            else
            {
                v_controlInsertar = 3;
                MessageBox.Show("Error; " + v_controlInsertar.ToString() + ".Ingrese un AÑO valido por favor. " + Convert.ToString(objConceptos.CON_PERIODO));
            }

            //Si todo lo anterior esta ok, se realiza el ingreso de la persona
            if (v_controlInsertar == 0)
            {

                if (objConceptos.CON_CONCEPTO != "OTROS")
                {

                    MessageBox.Show(objMet_Conceptos.InsertarConcepto(objConceptos.CON_CONCEPTO, objConceptos.CON_VALOR_ACTUAL, objConceptos.CON_FECHA_INI, v_fechaFinI, objConceptos.CON_FECHA_ACT, "S", objConceptos.CON_PERIODO, objConceptos.CON_SEMESTRE));

                    dgv_ConVisualizar.DataSource = objMet_Conceptos.Visualizar();
                    dgv_ConVisualizar.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                    objMet_Conceptos.InicializarCon(panelConBuscar, panel_ConEditar, panel_ConEliminar, panel_Con_Ingresar, panel_ConAbm, cbo_IngresarCon, txt_Con_MontoI, txt_ConAnioI, dt_FechaAlta, cbo_ConSemestreI, txt_OtrosCon);
                    

                }
                else if (objConceptos.CON_CONCEPTO == "OTROS")
                {
                    objConceptos.CON_CONCEPTO = txt_OtrosCon.Text.ToUpper();

                    MessageBox.Show(objMet_Conceptos.InsertarConcepto(objConceptos.CON_CONCEPTO, objConceptos.CON_VALOR_ACTUAL, objConceptos.CON_FECHA_INI, v_fechaFinI, objConceptos.CON_FECHA_ACT, "S", objConceptos.CON_PERIODO, objConceptos.CON_SEMESTRE));

                    dgv_ConVisualizar.DataSource = objMet_Conceptos.Visualizar();
                    dgv_ConVisualizar.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                    objMet_Conceptos.InicializarCon(panelConBuscar, panel_ConEditar, panel_ConEliminar, panel_Con_Ingresar, panel_ConAbm, cbo_IngresarCon, txt_Con_MontoI, txt_ConAnioI, dt_FechaAlta, cbo_ConSemestreI, txt_OtrosCon);
                   

                }

            }
        }

        //*********************************************************
        //BOTON CANCELAR EN FORM INGRESAR inicializa todos los controles. 
        //*********************************************************

        private void Ibtn_ConCancelar_Click(object sender, EventArgs e)
        {
            objMet_Conceptos.InicializarCon(panelConBuscar, panel_ConEditar, panel_ConEliminar, panel_Con_Ingresar, panel_ConAbm, cbo_IngresarCon, 
                                            txt_Con_MontoI, txt_ConAnioI, dt_FechaAlta, cbo_ConSemestreI, txt_OtrosCon);
            
        }

        
        //*********************************************************
        //BOTON AGREGAR SIGNO LUPA, SE APRIETA Y CARGA FORM DE BUSCAR 
        //*********************************************************
        private void icBtn_VisualizarConc_Click_1(object sender, EventArgs e)
        {
            panelConData.Show();
           
            panel_Con_Ingresar.Visible = false;
            panel_ConEditar.Visible = false;
            panel_ConEliminar.Visible = false;
            panelConBuscar.Show();
            panel_ConAbm.BackColor = Color.FromArgb(45, 66, 91);


            objMet_Conceptos.autocompletarBuscar(txt_ConBuscar);
                       
            dgv_ConVisualizar.DataSource = objMet_Conceptos.Visualizar();
            dgv_ConVisualizar.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        //*********************************************************
        // BOTON BUSCAR FORM BUSQUEDA-- LLAMA AL METODO Buscar

        private void icBtn_ConBuscar_Click(object sender, EventArgs e)
        {
            objConceptos.CON_CONCEPTO = txt_ConBuscar.Text;
            DateTime v_fechaDesde = dt_DesdeBuscarCon.Value;
            DateTime v_fechaHasta = dt_BuscarHastaCon.Value;


            if (v_fechaDesde <= v_fechaHasta)
            {
                dgv_ConVisualizar.DataSource = objMet_Conceptos.Buscar(objConceptos.CON_CONCEPTO, v_fechaDesde, v_fechaHasta);
                dgv_ConVisualizar.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        }

        private void icBtn_ConCancelar_Click(object sender, EventArgs e)
        {
            txt_ConBuscar.Clear();
            dt_DesdeBuscarCon.Text = DateTime.Now.ToShortDateString();
            dt_BuscarHastaCon.Text = DateTime.Now.ToShortDateString();

        }

        //*********************************************************
        //BOTON EDITAR SIGNO LAPIZ, SE APRIETA Y CARGA FORM DE EDITAR 
        //*********************************************************
        private void icBtn_EditarConc_Click(object sender, EventArgs e)
        {

            panelConBuscar.Visible = false;
            panel_Con_Ingresar.Visible = false;
            panel_ConEliminar.Visible = false;
            panel_ConAbm.BackColor = Color.CornflowerBlue;
            panel_ConEditar.Show();

            txt_BuscarConE.Visible = true;
            icBtn_BuscarEdit.Visible = true;

            txt_EditCon_ID.Visible = false;

            lbl_EditConAnio.Visible = false;
            txt_EditarAnio.Visible = false;
            lbl_EditConMonto.Visible = false;
            txt_EditarMonto.Visible = false;
            lbl_EditConSemestre.Visible = false;
            txt_EditarSemestre.Visible = false;
            icBtn_GuardarConE.Visible = false;
            icBtn_CancelarConE.Visible = false;
            lbl_EditConFechaMod.Visible = false;
            dt_EditarFechaAc.Visible = false;

            //    objMet_Conceptos.InicializarEditar(panelConBuscar, panel_Con_Ingresar, panel_ConEliminar, panel_ConAbm, txt_BuscarConE, icBtn_BuscarEdit, icBtn_GuardarConE, icBtn_CancelarConE, panel_ConEditar, lbl_EditConAnio, lbl_EditConMonto, lbl_EditConSemestre, lbl_EditConFechaMod, txt_EditCon_ID, txt_EditarMonto, txt_EditarAnio, dt_EditarFechaAc, txt_EditarSemestre);

            objMet_Conceptos.autocompletarBuscar(txt_BuscarConE);
        }


        //*********************************************************
        // BOTON BUSCAR FORM EDITAR-- LLAMA AL METODO VisualizarData pasando el nombre del concepto

        private void icBtn_BuscarE_Click(object sender, EventArgs e)
        {
            objConceptos.CON_CONCEPTO = txt_BuscarConE.Text.ToUpper();
            dgv_ConVisualizar.DataSource = objMet_Conceptos.VisualizarData(objConceptos.CON_CONCEPTO);
            dgv_ConVisualizar.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            txt_BuscarConE.Visible = false;
            icBtn_BuscarEdit.Visible = false;
            txt_EditCon_ID.Visible = false;

            txt_BuscarConE.Visible = true;
            lbl_EditConAnio.Visible = true;
            txt_EditarAnio.Visible = true;
            lbl_EditConMonto.Visible = true;
            txt_EditarMonto.Visible = true;
            lbl_EditConSemestre.Visible = true;
            txt_EditarSemestre.Visible = true;
            icBtn_GuardarConE.Visible = true;
            icBtn_CancelarConE.Visible = true;
            lbl_EditConFechaMod.Visible = true;
            dt_EditarFechaAc.Visible = true;
            icBtn_GuardarEliminar.Visible = true;
            icBtn_CancelarEliminar.Visible = true;


        }

        //////////////////////
        /////UNA VEZ QUE SE BUSCA SE PRESIONA EN LA GRILLA EL DESEADO Y SE CARGAN LOS DATOS CON EL EVENTO dgv_ConVisualizar_CellContentClick
        /////////////////////


        //*********************************************************
        // BOTON GUARDAR FORM EDITAR-- LLAMA AL METODO ActualizarConcepto 

        private void icBtn_GuardarConE_Click(object sender, EventArgs e)
        {

            objConceptos.CON_ID = Convert.ToInt32(txt_EditCon_ID.Text);
            objConceptos.CON_CONCEPTO = txt_BuscarConE.Text;
            objConceptos.CON_VALOR_ACTUAL = Convert.ToDouble(txt_EditarMonto.Text);
            objConceptos.CON_PERIODO = Convert.ToInt32(txt_EditarAnio.Text);
            objConceptos.CON_SEMESTRE = Convert.ToInt32(txt_EditarSemestre.Text);
            objConceptos.CON_FECHA_INI = dt_EditarFechaAc.Value;
            objConceptos.CON_FECHA_ACT = DateTime.Today;

            if (objConceptos.CON_FECHA_INI >= objConceptos.CON_FECHA_ACT)
            {
                objMet_Conceptos.ActualizarConcepto(objConceptos.CON_ID, objConceptos.CON_CONCEPTO, objConceptos.CON_VALOR_ACTUAL, objConceptos.CON_PERIODO, objConceptos.CON_SEMESTRE, objConceptos.CON_FECHA_INI, objConceptos.CON_FECHA_ACT);
                dgv_ConVisualizar.DataSource = objMet_Conceptos.Visualizar();
                dgv_ConVisualizar.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            }

        }

        //*********************************************************
        //BOTON ELIMINAR SIGNO CESTO, SE APRIETA Y CARGA FORM DE ELIMINAR 
        //*********************************************************
        private void icBtn_EliminarConc_Click(object sender, EventArgs e)
        {

            panel_ConEditar.Visible = false;
            panel_Con_Ingresar.Visible = false;
            panelConBuscar.Visible = false;
            panel_ConAbm.BackColor = Color.LightCoral;
            panel_ConEliminar.Show();

            txt_BuscarConEli.Visible = true;
            icBtn_BuscarEliminar.Visible = true;

            txt_EliminarConID.Visible = false;

            lbl_EliminarConMonto.Visible = false;
            txt_MontoConEli.Visible = false;
            lbl_EliminarConAnio.Visible = false;
            txt_AnioConEli.Visible = false;
            lbl_EliminarConSemestre.Visible = false;
            txt_SemestreConEli.Visible = false;
            lbl_EliminarConFA.Visible = false;
            dt_FechaAltaCon.Visible = false;
            lbl_EliminarConEstado.Visible = false;
            cbo_EliminarConEstado.Visible = false;
            lbl_EliminarConFF.Visible = false;
            dt_FechaFinCon.Visible = false;
            icBtn_GuardarEliminar.Visible = false;
            icBtn_CancelarEliminar.Visible = false;

            objMet_Conceptos.autocompletarBuscar(txt_BuscarConEli);

        }

        //*********************************************************
        // BOTON BUSCAR FORM ELIMINAR-- LLAMA AL METODO VisualizarData pasando el nombre del concepto

        private void icBtn_BuscarEliminar_Click(object sender, EventArgs e)
        {
            objConceptos.CON_CONCEPTO = txt_BuscarConEli.Text.ToUpper();
            dgv_ConVisualizar.DataSource = objMet_Conceptos.VisualizarData(objConceptos.CON_CONCEPTO);
            dgv_ConVisualizar.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            txt_BuscarConEli.Visible = false;
            icBtn_BuscarEliminar.Visible = false;

            txt_EliminarConID.Visible = false;


            lbl_EliminarConMonto.Visible = true;
            txt_MontoConEli.Visible = true;
            lbl_EliminarConAnio.Visible = true;
            txt_AnioConEli.Visible = true;
            lbl_EliminarConSemestre.Visible = true;
            txt_SemestreConEli.Visible = true;
            lbl_EliminarConFA.Visible = true;
            dt_FechaAltaCon.Visible = true;
            lbl_EliminarConEstado.Visible = true;
            cbo_EliminarConEstado.Visible = true;
            lbl_EliminarConFF.Visible = true;
            dt_FechaFinCon.Visible = true;
            icBtn_GuardarEliminar.Visible = true;
            icBtn_CancelarEliminar.Visible = true;

        }

        //////////////////////
        /////UNA VEZ QUE SE BUSCA SE PRESIONA EN LA GRILLA EL DESEADO Y SE CARGAN LOS DATOS CON EL EVENTO dgv_ConVisualizar_CellContentClick
        /////////////////////


        //*********************************************************
        // BOTON GUARDAR FORM ELIMINAR-- LLAMA AL METODO EliminarConcepto

        private void icBtn_GuardarEliminar_Click(object sender, EventArgs e)
        {
            objConceptos.CON_ID = Convert.ToInt32(txt_EliminarConID.Text);
            string v_estado = cbo_EliminarConEstado.SelectedItem.ToString();
            objConceptos.CON_FECHA_FIN = dt_FechaFinCon.Value;
            objConceptos.CON_FECHA_INI = dt_FechaAltaCon.Value;
            int v_control = 0;

            if (objConceptos.CON_FECHA_FIN >= objConceptos.CON_FECHA_INI)
            {

                v_control = 0;
            }
            else
            {
                v_control = 1;
                MessageBox.Show("La fecha de fin no puede ser menor a la fecha de alta. Ingrese otra fecha por favor.");
            }


            if (v_estado == "INACTIVO")
            {
                v_control = 0;
            }
            else
            {
                v_control = 2;
                MessageBox.Show("Por favor seleccione 'INACTIVO' si desea deshabilitar el concepto.");
            }

            if (v_control == 0)
            {

                objMet_Conceptos.EliminarConcepto(objConceptos.CON_ID, objConceptos.CON_FECHA_FIN);
                dgv_ConVisualizar.DataSource = objMet_Conceptos.Visualizar();
                dgv_ConVisualizar.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            }


        }

        //CARGA DE DATOS EN LOS TEXTBOX PARA EL EDITAR Y EL ELIMINAR

        private void dgv_ConVisualizar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (panel_ConEditar.Visible == true )
            {

                txt_EditarMonto.Text = dgv_ConVisualizar.CurrentRow.Cells[4].Value.ToString();
                txt_EditarAnio.Text = dgv_ConVisualizar.CurrentRow.Cells[2].Value.ToString();
                txt_EditarSemestre.Text = dgv_ConVisualizar.CurrentRow.Cells[3].Value.ToString();
                txt_EditCon_ID.Text = dgv_ConVisualizar.CurrentRow.Cells[0].Value.ToString();
                dt_EditarFechaAc.Value = Convert.ToDateTime(dgv_ConVisualizar.CurrentRow.Cells[5].Value.ToString());

            }
            else if (panel_ConEliminar.Visible == true)
            {
                txt_EliminarConID.Text = dgv_ConVisualizar.CurrentRow.Cells[0].Value.ToString();
                txt_MontoConEli.Text = dgv_ConVisualizar.CurrentRow.Cells[4].Value.ToString();
                txt_AnioConEli.Text = dgv_ConVisualizar.CurrentRow.Cells[2].Value.ToString();
                txt_SemestreConEli.Text = dgv_ConVisualizar.CurrentRow.Cells[3].Value.ToString();
                dt_FechaAltaCon.Value = Convert.ToDateTime(dgv_ConVisualizar.CurrentRow.Cells[5].Value.ToString());
                cbo_EliminarConEstado.Text = dgv_ConVisualizar.CurrentRow.Cells[8].Value.ToString();


            }

        }



        private void icBtn_CancelarConE_Click(object sender, EventArgs e)
        {

            objMet_Conceptos.InicializarEditar(panelConBuscar, panel_Con_Ingresar, panel_ConEliminar, panel_ConAbm, txt_BuscarConE, icBtn_BuscarEdit, 
                                               icBtn_GuardarConE, icBtn_CancelarConE, panel_ConEditar, lbl_EditConAnio, lbl_EditConMonto, lbl_EditConSemestre, 
                                               lbl_EditConFechaMod, txt_EditCon_ID, txt_EditarMonto, txt_EditarAnio, dt_EditarFechaAc, txt_EditarSemestre);

            objMet_Conceptos.autocompletarBuscar(txt_BuscarConE);

        }

    }
}
