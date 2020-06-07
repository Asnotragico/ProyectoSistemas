using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;
using System.Windows.Forms;

namespace GestionJardin
{
    public class metConcepto : Conexion
    {

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter dta;
        DataTable dt;
        SqlDataReader dr;

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


        public void InicializarCon(MetroComboBox p_nombreCon, MetroTextBox p_montoCon, MetroTextBox p_anioCon, MetroDateTime p_fechaCon, MetroComboBox p_SemestreCon)
        {


            try
            {

                con.Open();

                p_fechaCon.Text = DateTime.Now.ToShortDateString();
                p_nombreCon.Focus();
                p_nombreCon.SelectedIndex = -1;
                p_montoCon.Clear();
                p_anioCon.Clear();
                p_SemestreCon.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                con.Close();
            }



        }

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
