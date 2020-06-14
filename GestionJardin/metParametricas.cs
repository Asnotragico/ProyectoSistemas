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
    public class metParametricas : Conexion
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter dta;
        DataTable dt;
        SqlDataReader dr;

        public string secuenciadorLegajoAlumnos()
        {
            string result = "";
            string valor_1 = "";
            string valor_2 = "";
            //DEVUELVE EL SIGUIENTE VALOR
            try
            {
                con = generarConexion();
                con.Open();


                string consulta = "SELECT P.PAR_VALOR_1, P.PAR_VALOR_2 from T_PARAMETRICA P WHERE P.PAR_ID = 1;";


                cmd = new SqlCommand(consulta, con);
                dta = new SqlDataAdapter(cmd);
                dt = new DataTable();
                dta.Fill(dt);

                con.Close();


                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        valor_1 = Convert.ToString(dr["PAR_VALOR_1"]);
                        valor_2 = Convert.ToString(dr["PAR_VALOR_2"]);
                    }
                }

                result = valor_2.PadLeft(5, '0');


            }
            catch
            {
                result = "ERROR";
                MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            //ADELANTA UN NUMERO EL SECUENCIADOR
            try
            {
                con = generarConexion();
                con.Open();


                string consulta = "UPDATE T_PARAMETRICA SET PAR_VALOR_1 = PAR_VALOR_1 + 1, PAR_VALOR_2 = PAR_VALOR_2 + 1 WHERE PAR_ID = 1; ";


                cmd = new SqlCommand(consulta, con);
                cmd.ExecuteNonQuery();

                con.Close();

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
