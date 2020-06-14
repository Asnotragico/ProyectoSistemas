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
    public partial class frmGestionCuotas : Form
    {
        //metro colors https://www.w3schools.com/colors/colors_metro.asp

        DataTable colPersona = new DataTable();
        DataTable conceptos = new DataTable();

        public frmGestionCuotas()
        {
            InitializeComponent();
        }

        private void frmGestionCuotas_Load(object sender, EventArgs e)
        {

            //cargar combo Salas
            metCuota metCobro = new metCuota();
            entSala.entSalaColeccion salas = metCobro.buscarSalas(); 

            cbSalas.DataSource = new BindingSource(salas, null);
            cbSalas.ValueMember = "SAL_ID";
            cbSalas.DisplayMember = "SAL_NOMBRE";
            cbSalas.SelectedItem = null;

            // oculta los paneles

            panelBusqueda.Hide();
            panelGeneracion.Hide();
            listConceptos.Hide();

            //Autocompletar

            AutoCompleteStringCollection alumnos = new AutoCompleteStringCollection();
            metPersonas metPersonas = new metPersonas();
            alumnos = metPersonas.traerPersonasAutocompetar("2");

            txtMatriculados.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtMatriculados.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtMatriculados.AutoCompleteCustomSource = alumnos;


            dgvMatriculados.Visible = false;

        }


        private void btnParticular_Click_1(object sender, EventArgs e)
        {
            //agregar funcion para limpiar controles

            panelGeneracion.Hide();
            panelBusqueda.Show();
            lblAyuda.Text = "Ingrese el apellido del matriculado.";
        }


        private void btnMasivo_Click_1(object sender, EventArgs e)
        {
            panelGeneracion.Show();
            panelBusqueda.Hide();
            lblAyuda.Text = "Complete los Datos de la Cuota.";
        }

        private void cbSalas_SelectedValueChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(cbSalas.SelectedValue);  // prueba

            listConceptos.Show();

            Int32 idSala;

            if (cbSalas.SelectedValue != null)
            {
                if (cbSalas.SelectedValue.ToString() == "GestionJardin.entSala")
                {

                }
                else
                {
                    idSala = Convert.ToInt32(cbSalas.SelectedValue);

                    metSalas objMetSala = new metSalas();

                    //entPersona.entPersonaColeccion colPersona = new entPersona.entPersonaColeccion();

                    colPersona = objMetSala.traerPersonasXSala(idSala);

                    dgvMatriculados.DataSource = colPersona;
                    dgvMatriculados.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    dgvMatriculados.Columns["PER_ID"].Visible = false;


                    dgvMatriculados.Visible = true; // muestra el DGV oculto


                }
            }

        }

        private void cbAnoEjercicio_SelectedValueChanged(object sender, EventArgs e)
        {
            int anioEjercicio = Convert.ToInt32(cbAnoEjercicio.SelectedItem);
            metCuota metCuota = new metCuota();
            conceptos = metCuota.traeConceptos(anioEjercicio);

            listConceptos.Clear();

            listConceptos.View = View.Details;
            listConceptos.GridLines = true;
            listConceptos.FullRowSelect = true;

            listConceptos.Columns.Add(conceptos.Columns[0].ToString(), 0);
            listConceptos.Columns.Add(conceptos.Columns[1].ToString(), 120);
            listConceptos.Columns.Add(conceptos.Columns[2].ToString(), 70);
            listConceptos.Columns.Add(conceptos.Columns[3].ToString(), 70);

            foreach (DataRow renglon in conceptos.Rows)
            {
                string[] arr = new string[4];
                ListViewItem itm = new ListViewItem();


                //ADICIONAR ITEM AL LISTVIEW                   

                for (int ncolumna = 0; ncolumna < 4; ncolumna++)
                {
                    arr[ncolumna] = renglon[ncolumna].ToString();
                    itm = new ListViewItem(arr);
                }
                listConceptos.Items.Add(itm);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //FOR inserta una cuota_final por cada persona
            //      FOR por cada cuota_final inserta un detalle por cada concepto seleccionado
            //      UPDATE la cuota con el monto suma de los detalles agregados.

            foreach (DataRow persona in colPersona.Rows)
            {
                DataRow dr2 = persona;
                int montoTotal = 0;
                string legajo = Convert.ToString(dr2.ItemArray[6]);
                int periodoCuota = Convert.ToInt32(cbPeriodo.SelectedItem.ToString());
                int anoCuota = Convert.ToInt32(cbAnoEjercicio.SelectedItem.ToString()); ;
                string estadoCuota = "ADEUDADA";

                metCuota objMetCuota = new metCuota();

                int cuentaValida = objMetCuota.CuentaCuotasValidacion(legajo, periodoCuota, anoCuota);

                if (cuentaValida == 0)
                {
                    string resultado = objMetCuota.insertaCuotaFinal(legajo, periodoCuota, anoCuota, estadoCuota);

                    if (resultado == "OK")
                    {
                        ListView.SelectedListViewItemCollection conceptosSelected = listConceptos.SelectedItems;
                        foreach (ListViewItem item in conceptosSelected)
                        {
                            string index = item.Text;
                            int idConcepto;
                            int importeConcepto;
                            DataRow drConcepto; //= conceptos.Rows[Convert.ToInt32(index)];
                            foreach (DataRow dr in conceptos.Rows)
                            {
                                if (dr["ID"].ToString() == index)
                                {
                                    drConcepto = dr;

                                    idConcepto = Convert.ToInt32(drConcepto.ItemArray[0]);
                                    importeConcepto = Convert.ToInt32(drConcepto.ItemArray[2]);

                                    string resultado2 = objMetCuota.InsertarCuotaDetalle(legajo, periodoCuota, anoCuota, idConcepto, importeConcepto);

                                    montoTotal += importeConcepto;

                                    string resultado3 = objMetCuota.ActualizaMontoCuotaFinal(legajo, periodoCuota, anoCuota, montoTotal);

                                }
                            }

                        }


                    }



                }
                else
                {
                    MessageBox.Show("El matriculado " + legajo + " ya tiene cuotas generadas para ese periodo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            MessageBox.Show("Se han generado las cuotas exitosamente.", "Cuotas generadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}

