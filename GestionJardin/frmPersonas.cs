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
    public partial class frmPersonas : Form
    {
        metTipoPersona objMetTipoPersona = new metTipoPersona();
        entPersona objPersona = new entPersona();
        metSalas objMetSalas = new metSalas();

        int EdadAños;
        int EdadMeses;

        public frmPersonas()
        {
            InitializeComponent();

            cbo_TipoPersonas.DataSource = objMetTipoPersona.ListarTipoPersona();
            cbo_TipoPersonas.DisplayMember = "TPE_NOMBRE";
            cbo_TipoPersonas.ValueMember = "TPE_ID";

            //Ver de hacer un metodo para inicializar 
            panel_PerDocente.Visible = true;
            panel_PerBuscarAlu.Visible = false;
            panel_PerAlumno.Visible = false;
            panel_PerAluTut.Visible = false;

        }

        private void cbo_TipoPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //VER COMO HACER PARA QUE SE BLOQUEE LA EDICION EN CBO

            int v_TipoPersona = cbo_TipoPersonas.SelectedIndex;

            switch (v_TipoPersona)
            {
                case 0:
                    panel_PerDocente.Visible = true;
                    panel_PerBuscarAlu.Visible = false;
                    panel_PerAlumno.Visible = false;
                    panel_PerAluTut.Visible = false;
                    break;
                case 1:
                    panel_PerAlumno.Visible = true;
                    panel_PerBuscarAlu.Visible = false;
                    panel_PerDocente.Visible = false;
                    panel_PerAluTut.Visible = false;
                    break;
                case 2:
                    panel_PerBuscarAlu.Visible = true;
                    panel_PerAluTut.Visible = true;
                    panel_PerAlumno.Visible = false;
                    panel_PerDocente.Visible = false;
                    break;
                case 3:
                    panel_PerBuscarAlu.Visible = true;
                    panel_PerAluTut.Visible = true;
                    panel_PerAlumno.Visible = false;
                    panel_PerDocente.Visible = false;
                    break;
                case 4:
                    panel_PerBuscarAlu.Visible = true;
                    panel_PerAluTut.Visible = true;
                    panel_PerAlumno.Visible = false;
                    panel_PerDocente.Visible = false;
                    break;
            }
        }


        private void cbx_Turno_Sala_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexTurno = cbo_SalTurnoA.SelectedIndex;// 0 Mañana 1 Tarde

            Console.WriteLine(indexTurno); // prueba
            //LISTA SALAS
            //metSalas objmetSalas = new metSalas();

            cbo_SalTurnoA.DataSource = objMetSalas.ListarSalas(indexTurno);
            // cbx_Nombre_Salas.DataSource = objmetSalas.ListarSalas(indexTurno);
            cbo_SalTurnoA.DisplayMember = "SAL_NOMBRE";
            cbo_SalTurnoA.ValueMember = "SAL_ID";

            if ((EdadAños == 1) || (EdadAños == 2 && EdadMeses <= 6))
            {
                //cbx_Nombre_Salas.ValueMember= "ROSA";
                cbo_SalNombreA.SelectedIndex = cbo_SalNombreA.FindStringExact("ROSA");
                cbo_SalNombreA.Enabled = false;
            }

            else if ((EdadAños == 2 && EdadMeses > 6))
            {
                cbo_SalNombreA.SelectedIndex = cbo_SalNombreA.FindStringExact("NARANJA");
                cbo_SalNombreA.Enabled = false;

            }

            if (EdadAños == 2 || (EdadAños == 3 && EdadMeses < 6))

            {
                cbo_SalNombreA.SelectedIndex = cbo_SalNombreA.FindStringExact("NARANJA");
                cbo_SalNombreA.Enabled = false;

            }

            else if (EdadAños == 3 && (EdadAños == 4 && EdadMeses > 6))
            {
                cbo_SalNombreA.SelectedIndex = cbo_SalNombreA.FindStringExact("VERDE");
                cbo_SalNombreA.Enabled = false;

            }

            if (EdadAños == 4 || (EdadAños == 5 && EdadMeses < 6))
            {
                cbo_SalNombreA.SelectedIndex = cbo_SalNombreA.FindStringExact("VERDE");
                cbo_SalNombreA.Enabled = false;
                // cbo_SalTurnoA
                cbo_SalTurnoA.SelectedIndex = cbo_SalTurnoA.FindStringExact("Mañana");
                cbo_SalTurnoA.Enabled = false;

            }

        }

        private void dateTime_Fecha_Nac_ValueChanged(object sender, EventArgs e)
        {
            DateTime FechaReferencia = new DateTime(2020, 06, 30);


            EdadAños = (Convert.ToInt32(FechaReferencia.Year - dtp_PerFechaNac.Value.Year));

            EdadMeses = (Convert.ToInt32(FechaReferencia.Month - dtp_PerFechaNac.Value.Month));


            if
                (FechaReferencia.Month < dtp_PerFechaNac.Value.Month)
            {
                EdadMeses = (12 - (Convert.ToInt32(dtp_PerFechaNac.Value.Month)) + Convert.ToInt32((FechaReferencia.Month)));
            }

        }
    }
}
