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
        int via = 0; // 0 masiva - 1 particular
        string legajo;
        string nombreB = "";
        string apellidoB = "";
        string documentoB = "";

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
            btnBajaCuota.Visible = false;
        }

        private void btnParticular_Click(object sender, EventArgs e)
        {
            via = 1;
            //agregar funcion para limpiar controles
            limpiaCasillas();

            panelGeneracion.Hide();
            panelBusqueda.Show();
            lblAyuda.Text = "Ingrese el nombre del matriculado.";
        }

        private void btnMasivo_Click(object sender, EventArgs e)
        {
            via = 0;
            //agregar funcion para limpiar controles

            limpiaCasillas();

            cbSalas.Visible = true;
            panelGeneracion.Show();
            panelBusqueda.Hide();
            lblAyuda.Text = "Complete los Datos de la Cuota.";
        }

        private void cbSalas_SelectedValueChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(cbSalas.SelectedValue);  // prueba

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
                    dgvMatriculados.ClearSelection();

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
            listConceptos.Columns.Add(conceptos.Columns[1].ToString(), 130);
            listConceptos.Columns.Add(conceptos.Columns[2].ToString(), 110);
            //listConceptos.Columns.Add(conceptos.Columns[3].ToString(), 110);

            listConceptos.Show();

            foreach (DataRow renglon in conceptos.Rows)
            {
                string[] arr = new string[4];
                ListViewItem itm = new ListViewItem();


                //ADICIONAR ITEM AL LISTVIEW                   

                for (int ncolumna = 0; ncolumna < 3; ncolumna++)
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
            if (via == 0) { 

                if (conceptos.Rows.Count > 0) { 

                    foreach (DataRow persona in colPersona.Rows)
                    {
                        DataRow dr2 = persona;
                        int montoTotalM = 0;
                        string legajoM = Convert.ToString(dr2.ItemArray[6]);
                        int periodoCuotaM = Convert.ToInt32(cbPeriodo.SelectedItem.ToString());
                        int anoCuotaM = Convert.ToInt32(cbAnoEjercicio.SelectedItem.ToString()); ;
                        string estadoCuotaM = "ADEUDADA";

                        metCuota objMetCuota = new metCuota();

                        int cuentaValida = objMetCuota.CuentaCuotasValidacion(legajoM, periodoCuotaM, anoCuotaM);

                        if (cuentaValida == 0) { 
                            string resultado = objMetCuota.insertaCuotaFinal(legajoM, periodoCuotaM, anoCuotaM, estadoCuotaM);

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

                                            string resultado2 = objMetCuota.InsertarCuotaDetalle(legajoM, periodoCuotaM, anoCuotaM, idConcepto, importeConcepto);

                                            montoTotalM += importeConcepto;

                                            string resultado3 = objMetCuota.ActualizaMontoCuotaFinal(legajoM, periodoCuotaM, anoCuotaM, montoTotalM);

                                        }
                                    }

                                }

                        
                            }
                    
                        } else
                        {
                            MessageBox.Show("El matriculado " + legajoM + " ya tiene cuotas generadas para ese periodo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    MessageBox.Show("Se han generado las cuotas exitosamente.", "Cuotas generadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar al menos un Concepto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            } else if (via == 1) {

                //nombreB.ToString();
                //apellidoB.ToString();
                //documentoB.ToString();
                //legajo.ToString();

                if (conceptos.Rows.Count > 0)
                {

                    int montoTotal = 0;
                    int periodoCuota;

                    if (cbPeriodo.SelectedItem.ToString() == "MATRICULA")
                    {
                        periodoCuota = 00;
                    } else if (cbPeriodo.SelectedItem.ToString() == "ESPECIAL")
                    {
                        periodoCuota = 99;
                    } else
                    {
                        periodoCuota = Convert.ToInt32(cbPeriodo.SelectedItem.ToString());
                    }
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

                        txtMatriculados_ButtonClick(sender, e);
                        MessageBox.Show("Se ha generado la cuota exitosamente.", "Cuotas generadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El matriculado " + legajo + " ya tiene cuotas generadas para ese periodo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar al menos un Concepto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            

        }

        private void txtMatriculados_ButtonClick(object sender, EventArgs e)
        {
            btnBajaCuota.Visible = false;
            lblAyuda.Text = "Complete los datos para generar una Cuota, o seleccione las Cuotas para dar de baja.";

            int contador = 0;

            string busqueda = txtMatriculados.Text;

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

            DataTable cuotas = new DataTable();
            metCuota objMetCuota = new metCuota();

            legajo = objMetCuota.traeLegajo(nombreB, apellidoB, documentoB);

            metCuota objMetCuota2 = new metCuota();
            cuotas = objMetCuota2.traeCuotasXPersona(legajo);

            if ((cuotas != null) && (cuotas.Rows.Count != 0)) {

                dgvMatriculados.DataSource = cuotas;
                dgvMatriculados.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvMatriculados.Columns["ID"].Visible = false;


            }

            dgvMatriculados.Visible = true; // muestra el DGV oculto
            dgvMatriculados.ClearSelection();

            cbSalas.Visible = false;
            panelGeneracion.Show();

        }

        private void dgvMatriculados_SelectionChanged(object sender, EventArgs e)
        {
            
            if ((dgvMatriculados.SelectedRows.Count > 0) && (via == 1)) {
                btnBajaCuota.Visible = true;


            } else
            {
                btnBajaCuota.Visible = false;
            }

        }

        private void btnBajaCuota_Click(object sender, EventArgs e)
        {
            int idCuotaFinal;

            foreach ( DataGridViewRow cuota in dgvMatriculados.SelectedRows)
            {
                DataGridViewRow cuota1 = cuota;

                if (cuota.Cells[0].Value != null)
                {
                    idCuotaFinal = Convert.ToInt32(cuota.Cells[0].Value.ToString());

                    metCuota objMetCuota = new metCuota();
                    string resultado = objMetCuota.bajaCuotaFinal(idCuotaFinal);

                    txtMatriculados_ButtonClick(sender, e);
                }    

            }
        }

        private void limpiaCasillas()
        {
            cbPeriodo.SelectedItem = null;
            cbAnoEjercicio.SelectedItem = null;
            cbSalas.SelectedItem = null;
            listConceptos.Clear();
            listConceptos.Visible = false;
            dgvMatriculados.ClearSelection();
            txtMatriculados.Text = "";
            dgvMatriculados.DataSource = null;


        }
    }
}
