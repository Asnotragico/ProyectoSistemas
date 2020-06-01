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

        public string InsertarConcepto(string p_CON_CONCEPTO, double p_CON_VALOR_ACTUAL, double p_CON_VALOR_ANTERIOR, DateTime p_CON_FECHA_INI, DateTime p_CON_FECHA_FIN, DateTime p_CON_FECHA_ACT, string p_CON_ACTIVO)
        {

            con = generarConexion();
            string result;

            try
            {

                con.Open();
                //el SqlCommand se usa para realizar consultas a la base
                cmd = new SqlCommand("INSERT INTO T_CONCEPTOS (CON_CONCEPTO, CON_VALOR_ACTUAL, CON_VALOR_ANTERIOR, CON_FECHA_INI,	CON_FECHA_FIN, CON_FECHA_ACT, CON_ACTIVO) VALUES ('" + p_CON_CONCEPTO + "', " + p_CON_VALOR_ACTUAL + ", " + p_CON_VALOR_ANTERIOR + ", '" + p_CON_FECHA_INI + "','" + p_CON_FECHA_FIN + "', '" + p_CON_FECHA_ACT + "','" + p_CON_ACTIVO + "')", con);
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


        public DataTable Visualizar()
        {
            con = generarConexion();
            con.Open();

            string consulta = "SELECT CON_CONCEPTO as 'CONCEPTO', CON_VALOR_ACTUAL as 'VALOR ACTUAL', CON_VALOR_ANTERIOR as 'VALOR ANTERIOR', CONVERT(VARCHAR(10), T_CONCEPTOS.CON_FECHA_ACT, 103) as 'ALTA', CONVERT(VARCHAR(10), T_CONCEPTOS.CON_FECHA_ACT, 103) as 'MODIFICADO',CONVERT(VARCHAR(10), T_CONCEPTOS.CON_FECHA_FIN, 103) as 'FIN' FROM T_CONCEPTOS; ";
            cmd = new SqlCommand(consulta, con);
            dta = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dta.Fill(dt);

            con.Close();

            return dt;

           
        }

    }
}
