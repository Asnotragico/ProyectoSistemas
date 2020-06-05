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
    public class metPersonas : Conexion
    {

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter dta;
        DataTable dt;
        SqlDataReader dr;


        public AutoCompleteStringCollection traerPersonasAutocompetar(string tipo_persona) //FILTRA POR TIPO DE PERSONA. "0" TRAE TODOS. 
        {
            string tipoPersona;

            if (tipo_persona == "0")
            {
                tipoPersona = ";";

            }
            else
            {
                tipoPersona = "WHERE P.PER_TPE_ID = " + tipo_persona + ";";
            }

            con = generarConexion();

            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            con.Open();


            string consulta = "SELECT CONCAT(PER_NOMBRE, ' ', PER_APELLIDO, ' (', PER_DOCUMENTO, ') ') FROM T_PERSONAS P " + tipoPersona;
            cmd = new SqlCommand(consulta, con);

            dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                autoComplete.Add(dr.GetString(0));
            }
            dr.Close();

            con.Close();
            return autoComplete;

        }

    }
}
