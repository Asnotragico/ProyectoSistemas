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
            panel_ConVisualizar.Show();
            panel_ConAbm.Visible = false;

            dgv_ConVisualizar.DataSource = objMet_Conceptos.Visualizar();
            dgv_ConVisualizar.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void icBtn_AgregarConc_Click(object sender, EventArgs e)
        {
            panel_ConVisualizar.Visible = false;
            panel_ConIngresar.Show();
            panel_ConAbm.Visible = true;
        }



        private void icBtn_VisualizarConc_Click(object sender, EventArgs e)
        {
            panel_ConVisualizar.Show();
            panel_ConAbm.Visible = false;

            dgv_ConVisualizar.DataSource = objMet_Conceptos.Visualizar();
            dgv_ConVisualizar.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void Ibtn_ConGuardar_Click_1(object sender, EventArgs e)
        {

            objConceptos.CON_CONCEPTO = txt_ConNombre.Text.ToUpper();
            objConceptos.CON_VALOR_ACTUAL = Convert.ToDouble(txt_MontoConp.Text);
            objConceptos.CON_FECHA_ACT = dtp_ConFechaAlta.Value;
            objConceptos.CON_PERIODO = Convert.ToInt32(txt_ConPeriodo.Text);
            objConceptos.CON_SEMESTRE = Convert.ToInt32(cbo_Con_Semestre.SelectedItem);

            int v_controlInsertar = 0;
            DateTime v_fechaFinI = DateTime.MaxValue;
            DateTime v_FechaActual = DateTime.Today;

            //Se controla que ingrese una fecha valida
            if (objConceptos.CON_FECHA_ACT >= v_FechaActual)
            {
                v_controlInsertar = 0;
            }
            else
            {
                MessageBox.Show("Ingrese una FECHA valida por favor. " + Convert.ToString(objConceptos.CON_FECHA_ACT));
            }

            //Se controla que ingrese un semestre dentro de los comprendidos
            if (objConceptos.CON_SEMESTRE == 0 || objConceptos.CON_SEMESTRE == 1 || objConceptos.CON_SEMESTRE == 2)
            {
                v_controlInsertar = 0;
            }
            else
            {
                MessageBox.Show("Ingrese un SEMESTRE valido por favor. " + Convert.ToString(objConceptos.CON_SEMESTRE));
            }

            //Se controla que el ingrese un año actual
            if (objConceptos.CON_PERIODO >= 2020 && objConceptos.CON_PERIODO <= 9998)
            {
                v_controlInsertar = 0;
            }
            else
            {
                MessageBox.Show("Ingrese un AÑO valido por favor. " + Convert.ToString(objConceptos.CON_SEMESTRE));
            }

            //Si todo lo anterior esta ok, se realiza el ingreso de la persona
            if (v_controlInsertar == 0)
            {
                MessageBox.Show(objMet_Conceptos.InsertarConcepto(objConceptos.CON_CONCEPTO, objConceptos.CON_VALOR_ACTUAL, objConceptos.CON_FECHA_ACT, v_fechaFinI, v_FechaActual, "S", objConceptos.CON_PERIODO, objConceptos.CON_SEMESTRE));

                dgv_ConVisAbm.DataSource = objMet_Conceptos.VisualizarIngreso();
                dgv_ConVisAbm.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            }

        }

       
    }
}
