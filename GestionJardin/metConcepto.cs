using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionJardin
{
    public class metConcepto : Conexion
    {

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter dta;
        DataTable dt;

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

              con.Close();
            }
            catch (Exception ex)
            {
                result = "NO SE INSERTO EL PRODUCTO: " + ex.ToString();
                //con.Close();
            }
            return result;
        }


        public DataTable VisualizarIngreso()
        {
            con = generarConexion();
            con.Open();

            string consulta = "SELECT CON_CONCEPTO as 'CONCEPTO', CON_PERIODO 'PERIODO', CON_SEMESTRE 'SEMESTRE', CON_VALOR_ACTUAL as 'VALOR ACTUAL', CONVERT(VARCHAR(10), T_CONCEPTOS.CON_FECHA_ACT, 103) as 'ALTA' FROM T_CONCEPTOS; ";
            cmd = new SqlCommand(consulta, con);
            dta = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dta.Fill(dt);

            con.Close();

            return dt;
                       
        }


        public DataTable Visualizar()
        {
            con = generarConexion();
            con.Open();

            string consulta = "SELECT CON_CONCEPTO as 'CONCEPTO', CON_PERIODO 'PERIODO',  CON_SEMESTRE 'SEMESTRE', CON_VALOR_ACTUAL as 'VALOR ACTUAL', CONVERT(VARCHAR(10), T_CONCEPTOS.CON_FECHA_ACT, 103) as 'ALTA', CONVERT(VARCHAR(10), T_CONCEPTOS.CON_FECHA_ACT, 103) as 'MODIFICADO', CONVERT(VARCHAR(10), T_CONCEPTOS.CON_FECHA_FIN, 103) as 'FIN' FROM T_CONCEPTOS;";
            cmd = new SqlCommand(consulta, con);
            dta = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dta.Fill(dt);

            con.Close();

            return dt;

        }

    }
}
