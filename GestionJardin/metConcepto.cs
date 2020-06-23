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
        public string InsertarConcepto(entConcepto concepto)
        {

            con = generarConexion();
            string result;

            try
            {

                con.Open();
                //el SqlCommand se usa para realizar consultas a la base
                cmd = new SqlCommand("INSERT INTO T_CONCEPTOS " +
                                                            "(CON_CONCEPTO ," +
                                                            " CON_VALOR_ACTUAL, " +
                                                            " CON_FECHA_INI, " +
                                                            " CON_FECHA_FIN, " +
                                                            " CON_FECHA_ACT, " +
                                                            " CON_ACTIVO, " +
                                                            " CON_PERIODO, " +
                                                            " CON_VALOR_ANTERIOR) " +
                                                "VALUES " +
                                                        "('" + concepto.CON_CONCEPTO + "', " +
                                                        " " + concepto.CON_VALOR_ACTUAL.ToString().Replace(",",".") + "," +
                                                        "'" + concepto.CON_FECHA_INI + "', " +
                                                        "'" + concepto.CON_FECHA_FIN + "', " +
                                                        "'" + concepto.CON_FECHA_ACT + "'," +
                                                        "'" + concepto.CON_ACTIVO + "', " +
                                                        " " + concepto.CON_PERIODO + ", " +
                                                        " " + concepto.CON_VALOR_ANTERIOR + ")", con);
                cmd.ExecuteNonQuery();
                result = "SE INSERTO EL CONCEPTO: " + concepto.CON_CONCEPTO;


            }
            catch (Exception ex)
            {
                result = "NO SE INSERTO EL CONCEPTO: " + ex.ToString();
                con.Close();
            }
            return result;
        }


        //************************************************************
        //METODO QUE VALIDA QUE LOS DATOS A INGRESAR EN LA T_CONCEPTOS NO ESTEN REPETIDOS
        //************************************************************

        public int ValidarConcepto(string p_CON_CONCEPTO, int p_CON_PERIODO)
        {
            con = generarConexion();
            con.Open();

            int result = 1;
            try
            {

                cmd = new SqlCommand("SELECT COUNT(*) CANTIDAD " +
                                     " FROM T_CONCEPTOS WHERE CON_CONCEPTO = '" + p_CON_CONCEPTO + 
                                     "' AND CON_PERIODO  = " + p_CON_PERIODO + ";", con);
          

                dt = new DataTable();
                dta = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                dta.Fill(ds);
                dt = ds.Tables[0];
                con.Close();

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {

                        if (dr["CANTIDAD"] != DBNull.Value)
                            result = Convert.ToInt32(dr["CANTIDAD"]);


                    }
                }
            }
            catch (Exception ex)
            {
                result = 1;
                MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            return result;
        }


        
        /*
        PARA BUSCAR LOS CONCEPTOS POR NOMBRE
            */
        public void autocompletarBuscar(MetroTextBox p_buscarCon)
        {
            SqlDataReader dr2;
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();

            con = generarConexion();
            con.Open();     

            try
            {
                
                string consulta = "SELECT CONCAT(CON_CONCEPTO, '_', " +
                                                "CON_PERIODO, ' (', " +
                                                "CASE CON_ACTIVO " +
                                                     "WHEN 'S' THEN 'ACTIVO' " +
                                                     "WHEN 'N' THEN 'INACTIVO' " +
                                                "END, ')') " +
                                   "FROM T_CONCEPTOS; ";

                cmd = new SqlCommand(consulta, con);

                dr2 = cmd.ExecuteReader();


                while (dr2.Read())
                {
                    autoComplete.Add(dr2.GetString(0));
                }
                dr2.Close();

                p_buscarCon.AutoCompleteSource = AutoCompleteSource.CustomSource;
                p_buscarCon.AutoCompleteCustomSource = autoComplete;

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public entConcepto BuscaConcepto(string concepto, string anio, string estado)
        {
            //string result = "";
            entConcepto ent = new entConcepto();

            try
            {
                con = generarConexion();
                con.Open();


                string consulta = "SELECT * " +
                                    "FROM T_CONCEPTOS " +
                                   "WHERE CON_CONCEPTO = '"+ concepto + "' " +
                                     "AND CON_PERIODO = '"+ anio + "' " +                                  
                                     "AND CON_ACTIVO = '" + estado + "' ";
              

                cmd = new SqlCommand(consulta, con);
                dta = new SqlDataAdapter(cmd);
                dt = new DataTable();
                dta.Fill(dt);

                con.Close();


                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        //result = Convert.ToString(dr["PER_ID"]);

                        if (dr["CON_ID"] != DBNull.Value)
                            ent.CON_ID = Convert.ToInt32(dr["CON_ID"]);
                        if (dr["CON_CONCEPTO"] != DBNull.Value)
                            ent.CON_CONCEPTO = Convert.ToString(dr["CON_CONCEPTO"]);
                        if (dr["CON_VALOR_ACTUAL"] != DBNull.Value)
                            ent.CON_VALOR_ACTUAL = Convert.ToDecimal(dr["CON_VALOR_ACTUAL"]);
                        if (dr["CON_FECHA_INI"] != DBNull.Value)
                            ent.CON_FECHA_INI = Convert.ToDateTime(dr["CON_FECHA_INI"]);
                        if (dr["CON_FECHA_FIN"] != DBNull.Value)
                            ent.CON_FECHA_FIN = Convert.ToDateTime(dr["CON_FECHA_FIN"]);
                        if (dr["CON_FECHA_ACT"] != DBNull.Value)
                            ent.CON_FECHA_ACT = Convert.ToDateTime(dr["CON_FECHA_ACT"]);
                        if (dr["CON_ACTIVO"] != DBNull.Value)
                            ent.CON_ACTIVO = Convert.ToString(dr["CON_ACTIVO"]);
                        if (dr["CON_PERIODO"] != DBNull.Value)
                            ent.CON_PERIODO = Convert.ToInt32(dr["CON_PERIODO"]);
                        if (dr["CON_VALOR_ANTERIOR"] != DBNull.Value)
                            ent.CON_VALOR_ANTERIOR = Convert.ToDecimal(dr["CON_VALOR_ANTERIOR"]);

                    }
                }



            }
            catch
            {
                //result = "ERROR";
                MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            return ent;

        }
        

        /*
         PARA VISUALIZAR DETOS EN LA GRILLA DE MANERA GENERAL 
             */
        public DataTable Visualizar()
        {
            con = generarConexion();
            con.Open();


            string consulta = "SELECT CON_CONCEPTO as 'CONCEPTO', " +
                                     "CON_PERIODO 'PERIODO',  " +
                                     "CON_VALOR_ACTUAL as 'VALOR ACTUAL', " +
                                     "CON_VALOR_ANTERIOR 'VALOR ANTERIOR',  " +
                                     "CONVERT(VARCHAR(10), T_CONCEPTOS.CON_FECHA_INI, 103) as 'ALTA', " +
                                     "CONVERT(VARCHAR(10), T_CONCEPTOS.CON_FECHA_ACT, 103) as 'MODIFICADO', " +
                                     "CONVERT(VARCHAR(10), T_CONCEPTOS.CON_FECHA_FIN, 103) as 'FIN', " +
                                     "(CASE CON_ACTIVO " +
                                        "WHEN 'S' THEN 'ACTIVO' " +
                                        "WHEN 'N' THEN 'INACTIVO' " +
                                      "END) ESTADO " +
                               "FROM T_CONCEPTOS " +
                               "ORDER BY 1,8;";
            cmd = new SqlCommand(consulta, con);
            dta = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dta.Fill(dt);

            con.Close();

            return dt;

        }

        // Esto solo pasaria cuando se activa un inactivo y ademas cambia el monto
        public string ActualizarMontoEstado(entConcepto conceptoME)
        {

            con = generarConexion();
            string result;

            try
            {

                con.Open();
                //el SqlCommand se usa para realizar consultas a la base
                cmd = new SqlCommand("UPDATE T_CONCEPTOS SET CON_FECHA_ACT = '"+ conceptoME.CON_FECHA_ACT+"', " +
                                                            "CON_ACTIVO = 'S', " +
                                                            "CON_VALOR_ACTUAL = "+ conceptoME.CON_VALOR_ACTUAL.ToString().Replace(",", ".") + "," +
                                                            " CON_VALOR_ANTERIOR = "+ conceptoME.CON_VALOR_ANTERIOR.ToString().Replace(",", ".") + ", " +
                                                            "CON_FECHA_FIN = '"+ conceptoME.CON_FECHA_FIN +"' " +
                                                            "WHERE CON_ID = " + conceptoME.CON_ID+"; ", con);
                cmd.ExecuteNonQuery();
                result = "SE ACTUALIZO MONTO Y ESTADO DEL CONCEPTO";


            }
            catch (Exception ex)
            {
                result = "NO SE PUDO ACTUALIZAR EL CONCEPTO: " + ex.ToString();
                con.Close();
            }
            return result;
        }

        // Esto solo pasaria cuando se inactiva un concepto activo. El monto no deberia cambiar
        public string ActualizarEstadoN(entConcepto conceptoEN)
        {

            con = generarConexion();
            string result;

            try
            {

                con.Open();
                //el SqlCommand se usa para realizar consultas a la base
                cmd = new SqlCommand("UPDATE T_CONCEPTOS SET CON_FECHA_ACT = '" + conceptoEN.CON_FECHA_ACT + "', " +
                                                            "CON_ACTIVO = 'N', " +
                                                            "CON_FECHA_FIN = '"+ conceptoEN.CON_FECHA_FIN+"' " +
                                                            "WHERE CON_ID = "+ conceptoEN.CON_ID+";", con);
                cmd.ExecuteNonQuery();
                result = "SE DESHABILITO EL CONCEPTO";


            }
            catch (Exception ex)
            {
                result = "NO SE PUDO DESHABILITAR EL CONCEPTO: " + ex.ToString();
                con.Close();
            }
            return result;
        }

        // Esto solo pasaria cuando SOLO se activa un concepto inactivo y el monto no cambia
        public string ActualizarEstadoS(entConcepto conceptoES)
        {

            con = generarConexion();
            string result;

            try
            {

                con.Open();
                //el SqlCommand se usa para realizar consultas a la base
                cmd = new SqlCommand("UPDATE T_CONCEPTOS SET CON_FECHA_ACT = '" + conceptoES.CON_FECHA_ACT + "', " +
                                                            "CON_ACTIVO = 'S', " +
                                                            "CON_FECHA_FIN = '" + conceptoES.CON_FECHA_FIN + "' " +
                                                            "WHERE CON_ID = " + conceptoES.CON_ID + ";", con);
                cmd.ExecuteNonQuery();
                result = "SE HABILITO EL CONCEPTO";


            }
            catch (Exception ex)
            {
                result = "NO SE PUDO HABILITAR EL CONCEPTO: " + ex.ToString();
                con.Close();
            }
            return result;
        }

        //Cuando solo se modifica el monto de un concepto Activo
        public string ActualizarMonto(entConcepto conceptoM)
        {

            con = generarConexion();
            string result;

            try
            {

                con.Open();
                //el SqlCommand se usa para realizar consultas a la base
                cmd = new SqlCommand("UPDATE T_CONCEPTOS SET CON_FECHA_ACT = '" + conceptoM.CON_FECHA_ACT+ "'," +
                                                             " CON_VALOR_ACTUAL = "+ conceptoM.CON_VALOR_ACTUAL.ToString().Replace(",",".")+", " +
                                                             "CON_VALOR_ANTERIOR = "+ conceptoM.CON_VALOR_ANTERIOR.ToString().Replace(",", ".") + " " +
                                                             "WHERE CON_ID = "+ conceptoM.CON_ID+"; ", con);
                cmd.ExecuteNonQuery();

                result = "SE ACTUALIZO EL MONTO DEL CONCEPTO";


            }
            catch (Exception ex)
            {
                result = "NO SE PUDO ACTUALIZAR EL MONTO DEL CONCEPTO: " + ex.ToString();
                con.Close();
            }
            return result;
        }

    }
}
