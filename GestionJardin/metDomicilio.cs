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
    public class metDomicilio : Conexion
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter dta;
        DataTable dt;
        SqlDataReader dr;

        public string Insertar (entDomicilio domicilio)
        {

            string result;

            try
            {
                con = generarConexion();
                con.Open();
                string consulta = "INSERT INTO T_DOMICILIOS " +
                                                    "(DOM_PER_ID" +
                                                    ", DOM_CALLE" +
                                                    ", DOM_NUMERO" +
                                                    ", DOM_PISO" +
                                                    ", DOM_DPTO" +
                                                    ", DOM_BARRIO" +
                                                    ", DOM_CP" +
                                                    ", DOM_PROVINCIA" +
                                                    ", DOM_PAIS" +
                                                    ", DOM_TIPO) " +
                                        "VALUES " +
                                                    "('" + domicilio.DOM_PER_ID + "'" +
                                                    ", '" + domicilio.DOM_CALLE + "'" +
                                                    ", '" + domicilio.DOM_NUMERO + "'" +
                                                    ", '" + domicilio.DOM_PISO + "'" +
                                                    ", '" + domicilio.DOM_DPTO + "'" +
                                                    ", '" + domicilio.DOM_BARRIO + "'" +
                                                    ", '" + domicilio.DOM_CP + "'" +
                                                    ", 'CORDOBA'" +
                                                    ", 'ARGENTINA'" +
                                                    ", NULL);";


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

        public entDomicilio buscarDomicilioXPersona(Int32 idPersona)
        {
            entDomicilio ent = new entDomicilio();

            try
            {
                con = generarConexion();
                con.Open();


                string consulta = "SELECT * FROM T_DOMICILIOS D WHERE D.DOM_PER_ID = '" + idPersona + "';";


                cmd = new SqlCommand(consulta, con);
                dta = new SqlDataAdapter(cmd);
                dt = new DataTable();
                dta.Fill(dt);

                con.Close();


                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {


                        if (dr["DOM_ID"] != DBNull.Value)
                            ent.DOM_ID = Convert.ToInt32(dr["DOM_ID"]);
                        if (dr["DOM_PER_ID"] != DBNull.Value)
                            ent.DOM_PER_ID = Convert.ToInt32(dr["DOM_PER_ID"]);
                        if (dr["DOM_CALLE"] != DBNull.Value)
                            ent.DOM_CALLE = Convert.ToString(dr["DOM_CALLE"]);
                        if (dr["DOM_NUMERO"] != DBNull.Value)
                            ent.DOM_NUMERO = Convert.ToInt32(dr["DOM_NUMERO"]);
                        if (dr["DOM_PISO"] != DBNull.Value)
                            ent.DOM_PISO = Convert.ToInt32(dr["DOM_PISO"]);
                        if (dr["DOM_DPTO"] != DBNull.Value)
                            ent.DOM_DPTO = Convert.ToString(dr["DOM_DPTO"]);
                        if (dr["DOM_BARRIO"] != DBNull.Value)
                            ent.DOM_BARRIO = Convert.ToString(dr["DOM_BARRIO"]);
                        if (dr["DOM_CP"] != DBNull.Value)
                            ent.DOM_CP = Convert.ToInt32(dr["DOM_CP"]);


                    }
                }
            }
            catch
            {
                MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ent;
        }

        public string editarDomicilio(entDomicilio domicilioEditar)
        {

            string result;

            try
            {
                con = generarConexion();
                con.Open();

                string consulta = "UPDATE T_DOMICILIOS SET " +
                                                "DOM_CALLE = " + "'" + domicilioEditar.DOM_CALLE + "'" +
                                                ", DOM_NUMERO = " + "'" + domicilioEditar.DOM_NUMERO + "'" +
                                                ", DOM_PISO = " + "'" + domicilioEditar.DOM_PISO + "'" +
                                                ", DOM_DPTO = " + "'" + domicilioEditar.DOM_DPTO + "'" +
                                                ", DOM_BARRIO = " + "'" + domicilioEditar.DOM_BARRIO + "'" +
                                                ", DOM_CP = " + "'" + domicilioEditar.DOM_CP + "'" +
                                                " " +
                                        "WHERE DOM_PER_ID = " + "'" + domicilioEditar.DOM_PER_ID + "'" +
                                                ";";

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

    }
}
