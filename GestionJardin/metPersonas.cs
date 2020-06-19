using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;

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
                tipoPersona = "WHERE PER_TPE_ID = " + tipo_persona + "ORDER BY 1;";
            }

            con = generarConexion();

            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            con.Open();


            string consulta = "SELECT CONCAT(PER_NOMBRE, ', ', PER_APELLIDO, ' (', PER_DOCUMENTO, ')') FROM T_PERSONAS " + tipoPersona;

            //"SELECT CONCAT(PER_NOMBRE, ', ', PER_APELLIDO, ' (', PER_DOCUMENTO, ')') FROM T_PERSONAS P " + tipoPersona;
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
                                                "('" + persona.PER_NOMBRE + "'" +
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

        public entPersona BuscaPersona(string nombre, string apellido, string documento)
        {
            //string result = "";
            entPersona ent = new entPersona();

            try
            {
                con = generarConexion();
                con.Open();


                string consulta = "SELECT * FROM T_PERSONAS P WHERE P.PER_NOMBRE = '" + nombre + "' AND P.PER_APELLIDO = '" + apellido + "' AND P.PER_DOCUMENTO = '" + documento + "';";


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


                        if (dr["PER_ID"] != DBNull.Value)
                            ent.PER_ID = Convert.ToInt32(dr["PER_ID"]);
                        if (dr["PER_NOMBRE"] != DBNull.Value)
                            ent.PER_NOMBRE = Convert.ToString(dr["PER_NOMBRE"]);
                        if (dr["PER_APELLIDO"] != DBNull.Value)
                            ent.PER_APELLIDO = Convert.ToString(dr["PER_APELLIDO"]);
                        if (dr["PER_DOCUMENTO"] != DBNull.Value)
                            ent.PER_DOCUMENTO = Convert.ToInt32(dr["PER_DOCUMENTO"]);
                        if (dr["PER_GENERO"] != DBNull.Value)
                            ent.PER_GENERO = Convert.ToString(dr["PER_GENERO"]);
                        if (dr["PER_FECHA_NAC"] != DBNull.Value)
                            ent.PER_FECHA_NAC = Convert.ToDateTime(dr["PER_FECHA_NAC"]);
                        if (dr["PER_TELEFONO"] != DBNull.Value)
                            ent.PER_TELEFONO = Convert.ToString(dr["PER_TELEFONO"]);
                        if (dr["PER_TELEFONO_2"] != DBNull.Value)
                            ent.PER_TELEFONO_2 = Convert.ToString(dr["PER_TELEFONO_2"]);
                        if (dr["PER_EMAIL"] != DBNull.Value)
                            ent.PER_EMAIL = Convert.ToString(dr["PER_EMAIL"]);
                        if (dr["PER_TPE_ID"] != DBNull.Value)
                            ent.PER_TPE_ID = Convert.ToString(dr["PER_TPE_ID"]);
                        if (dr["PER_LEGAJO"] != DBNull.Value)
                            ent.PER_LEGAJO = Convert.ToString(dr["PER_LEGAJO"]);

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


        public string editarPersona(entPersona personaEditar)
        {
            string result;

            try
            {
                con = generarConexion();
                con.Open();

                string consulta = "UPDATE T_PERSONAS SET " +
                                                "PER_NOMBRE = " + "'" + personaEditar.PER_NOMBRE + "'" +
                                                ", PER_APELLIDO = " + "'" + personaEditar.PER_APELLIDO + "'" +
                                                ", PER_DOCUMENTO = " + "'" + personaEditar.PER_DOCUMENTO + "'" +
                                                ", PER_GENERO = " + "'" + personaEditar.PER_GENERO + "'" +
                                                ", PER_FECHA_NAC = " + "'" + personaEditar.PER_FECHA_NAC + "'" +
                                                ", PER_TELEFONO = " + "'" + personaEditar.PER_TELEFONO + "'" +
                                                ", PER_TELEFONO_2 = " + "'" + personaEditar.PER_TELEFONO_2 + "'" +
                                                ", PER_EMAIL = " + "'" + personaEditar.PER_EMAIL + "'" +
                                                " " +
                                        "WHERE PER_ID = " + "'" + personaEditar.PER_ID + "'" +
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


        public string ValidarDni(string pDNI)
        {
            con = generarConexion();
            con.Open();


            string consulta = "SELECT PER_DOCUMENTO FROM T_PERSONAS WHERE PER_DOCUMENTO = '" + pDNI + "'";



            cmd = new SqlCommand(consulta, con);

            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                MessageBox.Show("La persona ya se encuentra registrada").ToString();                    
            }

            return pDNI;


        }

        public int EdadDocente(DateTime pfechaNacimiento)

        {
            DateTime FechaActual = DateTime.Today;


            int Edad_D = FechaActual.Year - pfechaNacimiento.Year;
            if (FechaActual < pfechaNacimiento.AddYears(Edad_D))
                Edad_D--;

            if (Edad_D < 18)
            {
                MessageBox.Show("Este docente tiene menos de 18 años. No puede ser registrado.");

            }
            return Edad_D;

        }

        public bool ValidarEmail(String pEmail)
        {
            String validar;
            validar = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (Regex.IsMatch(pEmail, validar))

            {
                if (Regex.Replace(pEmail, validar, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
            else
            {
                return false;
            }


        }
        
    }
}
