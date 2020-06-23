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
    public partial class frmCobros : Form
    {
        metCobros ObjMetCobro = new metCobros();
        public frmCobros()
        {
            InitializeComponent();
        }
        
    
        private void cboCuotas_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            if (panlBtnAnular.Visible == false) { 

                if (cboCuotas.SelectedIndex == 0)
                {
                    metCobros ObjMetCobros = new metCobros();
                    ObjMetCobros.ExtraerImporte(cboCuotas);

                    string importecuotaextraida = ObjMetCobros.ExtraerImporte(cboCuotas);

                    txtImporte.Text = importecuotaextraida;
                    dtCobro.Value = DateTime.Today;
                    cboMediodepago.SelectedItem = cboMediodepago.SelectedIndex = 0;
                    dtCobro.Enabled = false;
                    txtImporte.Enabled = false;
                    cboMediodepago.Enabled = false;

                }

                else
                {
                    MessageBox.Show("Debe seleccionar la cuota pendiente con mayor fecha de vencmiento");
                }
            } else
            {
                metCobros ObjMetCobros = new metCobros();
                ObjMetCobros.ExtraerImporte(cboCuotas);

                string importecuotaextraida = ObjMetCobros.ExtraerImporte(cboCuotas);

                txtImporte.Text = importecuotaextraida;
                dtCobro.Value = DateTime.Today;
                cboMediodepago.SelectedItem = cboMediodepago.SelectedIndex = 0;
                dtCobro.Enabled = false;
                txtImporte.Enabled = false;
                cboMediodepago.Enabled = false;
            }
        }

        private void frmCobros_Load_1(object sender, EventArgs e)
        {
            panelBotones.Visible = false;
            panelBusqueda.Visible = false;
            panelCobro.Visible = false;
            panlBtnAnular.Visible = false;
            panelDatos.Visible = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            limpiar();
            panelBusqueda.Visible = true;
            panelBotones.Visible = true;
            panelCobro.Visible = true;
            panelDatos.Visible = true;
            panelBotones.Visible = false;
            txtBuscarCobroIngresar.Clear();
            txtDocumento.Clear();
            txtLegajo.Clear();
            txtNombreyApellido.Clear();
            panlBtnAnular.Visible = true;
            txtBuscarCobroIngresar.Visible = false;
            txtBuscarDatos.Visible = true;

            btnEditar.Visible = false;
            ObjMetCobro.AutocompletarenCobros(txtBuscarDatos);

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            limpiar();
            panelBusqueda.Visible = true;
            panelBotones.Visible = true;
            panelCobro.Visible = true;
            panelDatos.Visible = true;
            txtBuscarCobroIngresar.Clear();
            txtDocumento.Clear();
            txtLegajo.Clear();
            txtNombreyApellido.Clear();
            panelBotones.Visible = true;
            panlBtnAnular.Visible = false;
            txtBuscarCobroIngresar.Visible = true;
            txtBuscarDatos.Visible = false;

            ObjMetCobro.AutocompletarenCobros(txtBuscarCobroIngresar);

        }
   
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            metCobros ObjMetCobros = new metCobros();
            ObjMetCobros.ModificarEstadoCuota(cboCuotas, txtLegajo, txtBuscarCobroIngresar);
            string resultado = ObjMetCobros.InsertarenTCobros(cboCuotas, txtLegajo);

        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txtBuscarCobroIngresar.Clear();
            txtDocumento.Clear();
            txtLegajo.Clear();
            txtNombreyApellido.Clear();
            txtImporte.Clear();
            cboCuotas.SelectedIndex = -1;
            dtCobro.Value = DateTime.Today;
            cboMediodepago.SelectedIndex = -1;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idCobro = Convert.ToInt32(cboCuotas.SelectedValue.ToString());

            metCobros ObjMetCobros = new metCobros();
            string resultado = ObjMetCobros.AnularCobro(idCobro);

            if (resultado == "OK") { 

                MessageBox.Show("La Cuota ha sido anulada con éxito.", "Cuota anulada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ObjMetCobros.ExtraerDni(txtBuscarDatos);

                ObjMetCobros.InsetarDatosCobrosenformBuscar(txtBuscarDatos, txtNombreyApellido, txtDocumento, txtLegajo, cboCuotas, txtImporte, cboMediodepago);
                ObjMetCobros.ExtraerImporte(cboCuotas);

            }
        }

        private void txtBuscarCobroIngresar_ButtonClick(object sender, EventArgs e)
        {
            metCobros ObjMetCobros = new metCobros();
            ObjMetCobros.ExtraerDni(txtBuscarCobroIngresar);


            ObjMetCobros.InsertarDatosCobrosenformAgregar(txtBuscarCobroIngresar, txtNombreyApellido, txtDocumento, txtLegajo, cboCuotas, txtImporte, cboMediodepago);
            ObjMetCobros.ExtraerImporte(cboCuotas);
        }

        private void txtBuscarDatos_ButtonClick(object sender, EventArgs e)
        {
            metCobros ObjMetCobros = new metCobros();
            //if txtBuscarCobro is null no entra
            ObjMetCobros.ExtraerDni(txtBuscarDatos);

            ObjMetCobros.InsetarDatosCobrosenformBuscar(txtBuscarDatos, txtNombreyApellido, txtDocumento, txtLegajo, cboCuotas, txtImporte, cboMediodepago);
            ObjMetCobros.ExtraerImporte(cboCuotas);
            btnEditar.Visible = true;
        }
    }
}
