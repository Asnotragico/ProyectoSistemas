using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;
using System.Windows.Forms;
using System.Drawing;
using FontAwesome.Sharp;

namespace GestionJardin
{
    public class metConcepto : Conexion
    {

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter dta;
        DataTable dt;
        SqlDataReader dr;

        //************************************************************
        //METODO QUE INSERTA LOS DATOS EN LA T_CONCEPTOS
        //************************************************************
        public string InsertarConcepto(string p_CON_CONCEPTO, double p_CON_VALOR_ACTUAL, DateTime p_CON_FECHA_INI, DateTime p_CON_FECHA_FIN, DateTime p_CON_FECHA_ACT, string p_CON_ACTIVO, int p_CON_PERIODO, int p_CON_SEMESTRE)
        {

            con = generarConexion();
            string result;

            try
            {

                con.Open();
                //el SqlCommand se usa para realizar consultas a la base
                cmd = new SqlCommand("INSERT INTO T_CONCEPTOS (CON_CONCEPTO, CON_VALOR_ACTUAL, CON_FECHA_INI, CON_FECHA_FIN, CON_FECHA_ACT, CON_ACTIVO, CON_PERIODO, CON_SEMESTRE) VALUES ('" + p_CON_CONCEPTO + "', " + p_CON_VALOR_ACTUAL + ", '" + p_CON_FECHA_INI + "','" + p_CON_FECHA_FIN + "', '" + p_CON_FECHA_ACT + "','" + p_CON_ACTIVO + "', " + p_CON_PERIODO + ", " + p_CON_SEMESTRE + ")", con);
                cmd.ExecuteNonQuery();
                result = "SE INSERTO EL CONCEPTO: " + p_CON_CONCEPTO;

              
            }
            catch (Exception ex)
            {
                result = "NO SE INSERTO EL CONCEPTO: " + ex.ToString();
                con.Close();
            }
            return result;
        }

        //************************************************************
        //METODO QUE ACTUALIZA LOS DATOS EN LA T_CONCEPTOS
        //************************************************************
        public string ActualizarConcepto(int P_CON_ID, string p_CON_CONCEPTO, Double p_CON_VALOR_ACTUAL, int p_CON_PERIODO, int p_CON_SEMESTRE, DateTime p_CON_FECHA_INI, DateTime p_CON_FECHA_ACT)
        {
            con = generarConexion();
            string result;
                        
                                 
            try
            {
                con.Open();
                cmd = new SqlCommand("UPDATE T_CONCEPTOS SET CON_CONCEPTO = '" + p_CON_CONCEPTO + "', CON_VALOR_ACTUAL = " + p_CON_VALOR_ACTUAL + ", CON_PERIODO = " + p_CON_PERIODO + ", CON_SEMESTRE = " + p_CON_SEMESTRE + ", CON_FECHA_INI = '" + p_CON_FECHA_INI + "', CON_FECHA_ACT = '" + p_CON_FECHA_ACT +"' WHERE CON_ID = "+ P_CON_ID+ "; ", con);
                cmd.ExecuteNonQuery();
                result = "SE ACTUALIZO" + p_CON_CONCEPTO; 
            }
            catch (Exception ex)
            {
                result = "NO SE ACTUALIZO EL CONCEPTO: " + ex.ToString();
                con.Close();
            }


            return result;

        }

        //************************************************************
        //METODO QUE ACTUALIZA EL ESTADO A INACTIVO EN LA T_CONCEPTOS
        //************************************************************
        public string EliminarConcepto(int P_CON_ID, DateTime p_FECHA_FIN)
        {
            con = generarConexion();
            string result;

            try 
            {
                con.Open();
                cmd = new SqlCommand("UPDATE T_CONCEPTOS SET CON_FECHA_FIN = '" + p_FECHA_FIN + "', CON_ACTIVO = 'N' WHERE CON_ID = "+ P_CON_ID + "; ", con);
                cmd.ExecuteNonQuery();
                result = "SE DESHABILITO EL CONCEPTO";

            }
            catch (Exception ex)
            {

                result = "NO SE DESHABILITO EL CONCEPTO: " + ex.ToString();
                con.Close();
            }


            return result;


        }
                     
        /*
         PARA VISUALIZAR DETOS EN LA GRILLA DE MANERA GENERAL 
             */
        public DataTable Visualizar()
        {
            con = generarConexion();
            con.Open();

            
            string consulta = "SELECT CON_ID 'ID', CON_CONCEPTO as 'CONCEPTO', CON_PERIODO 'PERIODO',  CON_SEMESTRE 'SEMESTRE', CON_VALOR_ACTUAL as 'VALOR ACTUAL', CONVERT(VARCHAR(10), T_CONCEPTOS.CON_FECHA_INI, 103) as 'ALTA', CONVERT(VARCHAR(10), T_CONCEPTOS.CON_FECHA_ACT, 103) as 'MODIFICADO', CONVERT(VARCHAR(10), T_CONCEPTOS.CON_FECHA_FIN, 103) as 'FIN', (CASE CON_ACTIVO WHEN 'S' THEN 'ACTIVO' WHEN 'N' THEN 'INACTIVO' END) ESTADO FROM T_CONCEPTOS;";
            cmd = new SqlCommand(consulta, con);
            dta = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dta.Fill(dt);

            con.Close();

            return dt;

        }

        /*
        PARA INICIALIZAR LOS DATOS EN EL ABM INGRESAR
            */
        public void InicializarCon(Panel p_panelConBuscar, Panel p_panel_ConEditar, Panel p_panel_ConEliminar, Panel p_panel_Con_Ingresar, Panel p_panel_ConAbm, 
                                   MetroComboBox p_nombreCon, MetroTextBox p_montoCon, MetroTextBox p_anioCon, MetroDateTime p_fechaCon, 
                                   MetroComboBox p_SemestreCon, MetroTextBox p_conOtros)
        {

            try
            {
                con = generarConexion();
                con.Open();
                //Paneles que se ocultan
                p_panelConBuscar.Visible = false;
                p_panel_ConEditar.Visible = false;
                p_panel_ConEliminar.Visible = false;

                //Paneles que se muestran
                p_panel_Con_Ingresar.Show();

                //Para identificarlo con el color del boton sobre el que se presiono. 
                p_panel_ConAbm.BackColor = Color.SeaGreen;
                
                //Se borran todos los controles
                p_fechaCon.Text = DateTime.Now.ToShortDateString();
                p_nombreCon.Focus();
                p_nombreCon.SelectedIndex = -1;
                p_montoCon.Clear();
                p_anioCon.Clear();
                p_SemestreCon.SelectedIndex = -1;
                p_conOtros.Clear();

                p_nombreCon.Size = new Size(280, 27);
                p_conOtros.Visible = false;
                
            }
            catch (Exception ex)
            {
                con.Close();
            }
                        
        }
        
        public void InicializarEditar(Panel p_panelConBuscar, Panel p_panel_Con_Ingresar,Panel p_panel_ConEliminar, Panel p_panel_ConAbm, MetroTextBox p_nombreCon, 
                                      IconButton p_icBtn_BuscarEdit, IconButton p_icBtn_GuardarConE, IconButton p_icBtn_CancelarConE, Panel p_panel_ConEditar, 
                                      Label p_lbl_EditConAnio, Label p_lbl_EditConMonto, Label p_lbl_EditConSemestre, Label p_lbl_EditConFechaMod,
                                      MetroTextBox p_conID, MetroTextBox p_montoCon, MetroTextBox p_anioCon, MetroDateTime p_fechaCon, MetroTextBox p_SemestreCon)
        {

            try
            {
                con = generarConexion();
                con.Open();


                //Paneles que oculta
                p_panelConBuscar.Visible = false;
                p_panel_Con_Ingresar.Visible = false;
                p_panel_ConEliminar.Visible = false;

                //El color del panel contenedor se debe poner del mismo colo cuando este se aprieta
                p_panel_ConAbm.BackColor = Color.CornflowerBlue;

                //Panel que muestra con las primeras opciones
                p_panel_ConEditar.Show();
                p_nombreCon.Visible = true;
                p_icBtn_BuscarEdit.Visible = true;

                //siempre esta en false
                p_conID.Visible = false;

                //Contenido que siempre se oculta
                p_lbl_EditConAnio.Visible = false;
                p_anioCon.Visible = false;
                p_lbl_EditConMonto.Visible = false;
                p_montoCon.Visible = false;
                p_lbl_EditConSemestre.Visible = false;
                p_SemestreCon.Visible = false;
                p_lbl_EditConFechaMod.Visible = false;
                p_fechaCon.Visible = false;
                p_icBtn_GuardarConE.Visible = false;
                p_icBtn_CancelarConE.Visible = false;

                               
                //Se borran todos los controles
                p_fechaCon.Text = DateTime.Now.ToShortDateString();
                p_nombreCon.Focus();
                p_nombreCon.Clear();
                p_montoCon.Clear();
                p_anioCon.Clear();
                p_SemestreCon.Clear();
                p_conID.Clear();
                      
             
            }
            catch (Exception ex)
            {
                con.Close();
            }

        }

        /*
        PARA BUSCAR LOS CONCEPTOS POR NOMBRE
            */
        public void autocompletarBuscar(MetroTextBox p_buscarCon)
        {
            con = generarConexion();
            con.Open();

            try
            {
                cmd = new SqlCommand("SELECT CON_CONCEPTO FROM T_CONCEPTOS",con);

                dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    p_buscarCon.AutoCompleteCustomSource.Add(dr.GetString(0));
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                con.Close();
            }

        }

        /*
      PARA VISUALIZAR EN LA GRILLA LOS CONCEPTOS DE LA BUSQUEDA QUE SE HIZO CON autocompletarBuscar
          */
        public DataTable VisualizarData(string data)
        {
            con = generarConexion();
            con.Open();


            string consulta = "SELECT CON_ID 'ID',CON_CONCEPTO as 'CONCEPTO', CON_PERIODO 'PERIODO',  CON_SEMESTRE 'SEMESTRE', CON_VALOR_ACTUAL as 'VALOR ACTUAL', CONVERT(VARCHAR(10), T_CONCEPTOS.CON_FECHA_INI, 103) as 'ALTA', CONVERT(VARCHAR(10), T_CONCEPTOS.CON_FECHA_ACT, 103) as 'MODIFICADO', CONVERT(VARCHAR(10), T_CONCEPTOS.CON_FECHA_FIN, 103) as 'FIN', (CASE CON_ACTIVO WHEN 'S' THEN 'ACTIVO' WHEN 'N' THEN 'INACTIVO' END) ESTADO FROM T_CONCEPTOS WHERE UPPER(CON_CONCEPTO) = '" + data + "' AND CON_ACTIVO = 'S';";
            cmd = new SqlCommand(consulta, con);
            dta = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dta.Fill(dt);

            con.Close();

            return dt;

        }

        /*
            PARA BUSCAR LOS CONCEPTOS POR FECHA
         */
        public DataTable Buscar(string data, DateTime p_fechaDesde, DateTime p_fechaHasta)
        {
            con = generarConexion();
            con.Open();

            string consulta = "SELECT CON_ID 'ID',CON_CONCEPTO as 'CONCEPTO', CON_PERIODO 'PERIODO',  CON_SEMESTRE 'SEMESTRE', CON_VALOR_ACTUAL as 'VALOR ACTUAL', CONVERT(VARCHAR(10), T_CONCEPTOS.CON_FECHA_INI, 103) as 'ALTA', CONVERT(VARCHAR(10), T_CONCEPTOS.CON_FECHA_ACT, 103) as 'MODIFICADO', CONVERT(VARCHAR(10), T_CONCEPTOS.CON_FECHA_FIN, 103) as 'FIN', (CASE CON_ACTIVO WHEN 'S' THEN 'ACTIVO' WHEN 'N' THEN 'INACTIVO' END) ESTADO FROM T_CONCEPTOS WHERE UPPER(CON_CONCEPTO) = '" + data + "' AND CON_FECHA_INI >= '" + p_fechaDesde + "' AND CON_FECHA_INI <= '" + p_fechaHasta + "';";
            cmd = new SqlCommand(consulta, con);
            dta = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dta.Fill(dt);

            con.Close();

            return dt;

        }


    }
}
