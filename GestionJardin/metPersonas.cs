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

        public string Insertar(entPersona persona)
        {
            string result;

            try
            { 
                con = generarConexion();
                con.Open();

                string consulta = "INSERT INTO T_PERSONAS " +
                                                "(PER_NOMBRE" +
                                                ", PER_APELLIDO" +
                                                ", PER_DOCUMENTO" +
                                                ", PER_GENERO" +
                                                ", PER_FECHA_NAC" +
                                                ", PER_TELEFONO" +
                                                ", PER_TELEFONO_2" +
                                                ", PER_EMAIL" +
                                                ", PER_TPE_ID" +
                                                ", PER_LEGAJO" +
                                                ", PER_ESTADO" +
                                                ", PER_FECHA_ALTA" +
                                                ", PER_FECHA_MOD" +
                                                ", PER_FECHA_BAJA) " +
                                        "VALUES " +
                                                "('"+ persona.PER_NOMBRE +"'" +
                                                ", '" + persona.PER_APELLIDO + "'" +
                                                ", '" + persona.PER_DOCUMENTO + "'" +
                                                ", '" + persona.PER_GENERO + "'" +
                                                ", '" + persona.PER_FECHA_NAC + "'" +
                                                ", '" + persona.PER_TELEFONO + "'" +
                                                ", '" + persona.PER_TELEFONO_2 + "'" +
                                                ", '" + persona.PER_EMAIL + "'" +
                                                ", '" + persona.PER_TPE_ID + "'" +
                                                ", '" + persona.PER_LEGAJO + "'" +
                                                ", '" + persona.PER_ESTADO + "'" +
                                                ", GETDATE()" +
                                                ", NULL" +
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

        public string BuscaPersona(string nombre, string apellido, string documento)
        {
            string result = "";

            try
            {
                con = generarConexion();
                con.Open();


                string consulta = "SELECT P.PER_ID FROM T_PERSONAS P WHERE P.PER_NOMBRE = '" + nombre + "' AND P.PER_APELLIDO = '" + apellido + "' AND P.PER_DOCUMENTO = '" + documento + "';";

                    
                cmd = new SqlCommand(consulta, con);
                dta = new SqlDataAdapter(cmd);
                dt = new DataTable();
                dta.Fill(dt);

                con.Close();


                if (dt != null)
                {                 
                    foreach (DataRow dr in dt.Rows)
                    {        
                         result = Convert.ToString(dr["PER_ID"]);
                        
                    }
                }

                return result;


            }
            catch
            {
                result = "ERROR";
                MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return result;
            }

        }

    }
}
