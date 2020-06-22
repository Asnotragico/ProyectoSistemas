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
    class metGrupoFlia : Conexion
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter dta;
        DataTable dt;
        SqlDataReader dr;


        public string insertaEnGrupoFlia(int idPersonaIngresada, string legajo)
        {
            string result;

            try
            {
                con = generarConexion();
                con.Open();

                string consulta = "INSERT INTO T_GRUPO_FLIA " +
                                                "(GRF_PER_ID" +
                                                ", GRF_TUTOR" +
                                                ", GRF_AUTORIZADO" +
                                                ", GRF_GRUPO_LEGAJO" +
                                                ", GRF_OBSERVACION) " +
                                        "VALUES " +
                                                "('" + idPersonaIngresada + "'" +
                                                ", 'N'" +
                                                ", 'N'" +
                                                ", '" + legajo + "'" +
                                                ", NULL);";



                cmd = new SqlCommand(consulta, con);
                cmd.ExecuteNonQuery();
                con.Close();

                result = "OK";

            }
            catch (Exception ex)
            {
                result = "ERROR";
                MessageBox.Show("Hubo un problema. Contáctese con su administrador." +  ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return result;
        }

        public DataTable traerPersonasXGrupoFliar(string idPersona) {
            
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = generarConexion();
                con.Open();

                SqlCommand com = new SqlCommand();
                com.Connection = con;

                com.CommandText = "select" +
                                    "(select CONCAT(p.PER_NOMBRE, ' ', p.PER_APELLIDO) from T_PERSONAS p where p.PER_ID = GF2.GRF_PER_ID) NOMBRE, " +
                                    "(select tp.TPE_NOMBRE from T_PERSONAS p, T_TIPO_PERSONA tp where tp.TPE_ID = p.PER_TPE_ID and p.PER_ID = GF2.GRF_PER_ID) RELACION " +
                                    "from T_GRUPO_FLIA gf2 " +
                                    "where gf2.GRF_GRUPO_LEGAJO in " +
                                                "(select gf.GRF_GRUPO_LEGAJO " +
                                                "from T_GRUPO_FLIA GF " +
                                                "where gf.GRF_PER_ID = " + idPersona + ");";

                
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet ds = new DataSet();

                da.Fill(ds);
                dt = ds.Tables[0];
                con.Close();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un problema. Contáctese con su administrador." + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return dt;
        }

    }
}
