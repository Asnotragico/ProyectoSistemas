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


            DateTime v_fechaFinI = DateTime.MaxValue;
            DateTime v_FechaActual = DateTime.Today;
            double v_ValorVacio = 0;


            if (objConceptos.CON_FECHA_ACT >= v_FechaActual)
            {
                MessageBox.Show(objMet_Conceptos.InsertarConcepto(objConceptos.CON_CONCEPTO, objConceptos.CON_VALOR_ACTUAL, v_ValorVacio, objConceptos.CON_FECHA_ACT, v_fechaFinI, objConceptos.CON_FECHA_ACT, "S"));

                dgv_ConVisAbm.DataSource = objMet_Conceptos.Visualizar();
                dgv_ConVisAbm.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            }
            else
            {
                MessageBox.Show("Ingrese una fecha valida por favor. " + Convert.ToString(objConceptos.CON_FECHA_ACT));
            }
        }
    }
}
