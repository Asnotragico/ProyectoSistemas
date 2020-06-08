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


    }
}
