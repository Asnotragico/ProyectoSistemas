using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionJardin
{
    public class metCuota : Conexion
    {

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter dta;
        DataTable dt;
        SqlDataReader dr;

        public entSala.entSalaColeccion buscarSalas()
        {
            entSala.entSalaColeccion SalaCol = new entSala.entSalaColeccion();

            try
            {

                SqlConnection con = generarConexion();
                con.Open();

                SqlCommand com = new SqlCommand();
                com.Connection = con;

                com.CommandText = "select CONCAT(u.SAL_NOMBRE, ' ', u.SAL_TURNO) NOMBRE, u.* " +
                                    "from T_SALA u " +
                                    ";";

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet ds = new DataSet();

                da.Fill(ds, "T_SALA");
                dt = ds.Tables[0];
                con.Close();

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        entSala ent = new entSala();
                        if (dr["SAL_ID"] != DBNull.Value)
                            ent.SAL_ID = Convert.ToInt32(dr["SAL_ID"]);
                        if (dr["NOMBRE"] != DBNull.Value)
                            ent.SAL_NOMBRE = Convert.ToString(dr["NOMBRE"]);
                        if (dr["SAL_EDAD_MIN"] != DBNull.Value)
                            ent.SAL_EDAD_MIN = Convert.ToInt32(dr["SAL_EDAD_MIN"]);
                        if (dr["SAL_EDAD_MAX"] != DBNull.Value)
                            ent.EDAD_SALA_MAX = Convert.ToInt32(dr["SAL_EDAD_MAX"]);
                        if (dr["SAL_CANT_ALUM"] != DBNull.Value)
                            ent.SALA_CANT_ALUM = Convert.ToInt32(dr["SAL_CANT_ALUM"]);
                        if (dr["SAL_TURNO"] != DBNull.Value)
                            ent.SALA_TURNO = Convert.ToString(dr["SAL_TURNO"]);
                        if (dr["SAL_ACTIVO"] != DBNull.Value)
                            ent.SALA_ACTIVO = Convert.ToString(dr["SAL_ACTIVO"]);

                        SalaCol.Add(ent);
                    }
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return SalaCol;

        }

        public DataTable traeConceptos(int añoEjercicio)
        {
            SqlConnection con = generarConexion();
            con.Open();

            SqlCommand com = new SqlCommand();
            com.Connection = con;

            com.CommandText = "SELECT C.CON_ID ID, C.CON_CONCEPTO CONCEPTO, C.CON_VALOR_ACTUAL VALOR, C.CON_SEMESTRE SEMESTRE " +
                                "FROM T_CONCEPTOS C " +
                                "WHERE C.CON_ACTIVO = 'S' " +
                                "AND C.CON_PERIODO = " + añoEjercicio + ";";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();

            da.Fill(ds, "T_CONCEPTOS");
            dt = ds.Tables[0];
            con.Close();

            return dt;
        }

        public string insertaCuotaFinal(string legajo, int periodoCuota, int anoCuota, string estadoCuota)
        {
            string result;

            try
            {
                con = generarConexion();
                con.Open();
                string consulta = "INSERT INTO T_CUOTA_FINAL" +
                                        "(CUO_PER_LEGAJO" +
                                        ", CUO_NUMERO" +
                                        ", CUO_ANO_CUOTA" +
                                        ", CUO_ESTADO" +
                                        ", CUO_FECHA_EMISION)" +
                                    "VALUES " +
                                        "('" + legajo + "'" +
                                        ", '" + periodoCuota + "'" +
                                        ", '" + anoCuota + "'" +
                                        ", '" + estadoCuota + "'" +
                                        ", GETDATE()" +
                                        ");";


                cmd = new SqlCommand(consulta, con);
                cmd.ExecuteNonQuery();
                con.Close();

                result = "OK";

            }
            catch
            {
                result = "ERROR";
                MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return result;
        }

        public string InsertarCuotaDetalle(string legajo, int periodoCuota, int anoCuota, int idConcepto, int importeConcepto)
        {
            string result;

            try
            {
                con = generarConexion();
                con.Open();
                string consulta = "INSERT INTO T_CUOTA_DETALLE" +
                                        "(DET_CUO_ID" +
                                        ", DET_CON_ID" +
                                        ", DET_IMPORTE" +
                                        ", DET_CANTIDAD" +
                                        ", DET_ACTIVO)" +
                                    "VALUES " +
                                        "( (SELECT CF.CUO_ID FROM T_CUOTA_FINAL CF WHERE CF.CUO_ANO_CUOTA = " + anoCuota + " AND CF.CUO_PER_LEGAJO = '" + legajo + "' AND CF.CUO_NUMERO = " + periodoCuota + " ) " +
                                        ", '" + idConcepto + "'" +
                                        ", '" + importeConcepto + "'" +
                                        ", 1" +
                                        ", 'S'" +
                                        ");";


                cmd = new SqlCommand(consulta, con);
                cmd.ExecuteNonQuery();
                con.Close();

                result = "OK";

            }
            catch
            {
                result = "ERROR";
                MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return result;
        }

        public string ActualizaMontoCuotaFinal(string legajo, int periodoCuota, int anoCuota, int importeConcepto)
        {
            string result;

            try
            {
                con = generarConexion();
                con.Open();
                string consulta = "UPDATE T_CUOTA_FINAL SET CUO_IMPORTE = " + importeConcepto + " WHERE CUO_PER_LEGAJO = '" + legajo + "' AND CUO_ANO_CUOTA = " + anoCuota + " AND CUO_NUMERO = " + periodoCuota + " AND CUO_ESTADO = 'ADEUDADA';";


                cmd = new SqlCommand(consulta, con);
                cmd.ExecuteNonQuery();
                con.Close();

                result = "OK";

            }
            catch
            {
                result = "ERROR";
                MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return result;
        }

        public int CuentaCuotasValidacion(string legajo, int periodoCuota, int anoCuota)
        {
            int result = 1;

            try
            {
                SqlConnection con = generarConexion();
                con.Open();

                SqlCommand com = new SqlCommand();
                com.Connection = con;

                com.CommandText = "SELECT COUNT(*) CUENTA FROM T_CUOTA_FINAL CF WHERE CF.CUO_ANO_CUOTA = " + anoCuota + " AND CF.CUO_PER_LEGAJO = '" + legajo + "' AND CF.CUO_NUMERO = " + periodoCuota + ";";

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet ds = new DataSet();

                da.Fill(ds);
                dt = ds.Tables[0];
                con.Close();

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {

                        if (dr["CUENTA"] != DBNull.Value)
                            result = Convert.ToInt32(dr["CUENTA"]);


                    }
                }

            }
            catch
            {
                result = 1;
                MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return result;
        }
    }
}
