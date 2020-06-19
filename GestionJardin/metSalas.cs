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
    public class metSalas : Conexion
    {

        SqlCommand cmd = new SqlCommand();
        SqlConnection con;
        SqlDataReader dr;
        DataTable dt;
        SqlDataAdapter dta;
        // private Conexion Conexion = new Conexion();
        //private SqlCommand Comando = new SqlCommand();
        //private SqlDataReader leerFilas;

        public DataTable ListarSalas(string turno)

        {
            con = generarConexion();
            string turnoR;

            DataTable Tabla = new DataTable();
            con.Open();

            string consulta = "SELECT * FROM T_SALA S WHERE S.SAL_TURNO = @turnoSala";
            cmd = new SqlCommand(consulta, con);

            if (turno == "0")
            {
                turnoR = "MANANA";
            }
            else
            {
                turnoR = "TARDE";
            }

            cmd.Parameters.Add(new SqlParameter("@turnoSala", turnoR));

            dr = cmd.ExecuteReader();
            Tabla.Load(dr);
            dr.Close();

            con.Close();
            return Tabla;

        }

        public string insertarGrupoSala(entGrupoSala grupoSala)
        {
            string result = "";
            try
            {

                con = generarConexion();
                con.Open();

                string consulta = "INSERT INTO T_GRUPO_SALA " +
                                                "(GRS_SAL_ID" +
                                                ", GRS_PER_ID)" +
                                        "VALUES " +
                                                "('" + grupoSala.GRS_SAL_ID + "'" +
                                                ", '" + grupoSala.GRS_PER_ID + "')";


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

        public entSala buscarSalaXPersona(Int32 idPersona)
        {
            entSala ent = new entSala();

            try
            {
                con = generarConexion();
                con.Open();


                string consulta = "SELECT S.* " +
                                        "FROM T_SALA S, T_GRUPO_SALA GS " +
                                        "WHERE S.SAL_ID = GS.GRS_SAL_ID " +
                                        "AND GS.GRS_PER_ID = " + idPersona + ";";

                cmd = new SqlCommand(consulta, con);
                dta = new SqlDataAdapter(cmd);
                dt = new DataTable();
                dta.Fill(dt);

                con.Close();


                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {

                        if (dr["SAL_ID"] != DBNull.Value)
                            ent.SAL_ID = Convert.ToInt32(dr["SAL_ID"]);
                        if (dr["SAL_NOMBRE"] != DBNull.Value)
                            ent.SAL_NOMBRE = Convert.ToString(dr["SAL_NOMBRE"]);
                        if (dr["SAL_TURNO"] != DBNull.Value)
                            ent.SALA_TURNO = Convert.ToString(dr["SAL_TURNO"]);

                    }
                }
            }
            catch
            {
                MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ent;

        }

        public string editarGrupoSala(entGrupoSala grupoSalaEditar)
        {
            string result = "";
            try
            {

                con = generarConexion();
                con.Open();

                string consulta = "UPDATE T_GRUPO_SALA SET " +
                                                "GRS_SAL_ID = " + "'" + grupoSalaEditar.GRS_SAL_ID + "'" +
                                                " " +
                                        "WHERE GRS_PER_ID = " + "'" + grupoSalaEditar.GRS_PER_ID + "'" +
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

        public DataTable traerPersonasXSala(Int32 idSala)

        {

            //entPersona.entPersonaColeccion colPers = new entPersona.entPersonaColeccion();
            con = generarConexion();

            DataTable dt = new DataTable();
            con.Open();

            string consulta = "select P.PER_ID, P.PER_NOMBRE NOMBRE, P.PER_APELLIDO APELLIDO, P.PER_TELEFONO TELEFONO, P.PER_TELEFONO_2 CELULAR, P.PER_EMAIL EMAIL, P.PER_LEGAJO LEGAJO from T_GRUPO_SALA GS, T_PERSONAS P WHERE P.PER_ID = GS.GRS_PER_ID AND GS.GRS_SAL_ID = @salaID AND P.PER_TPE_ID = 2 ;";
            cmd = new SqlCommand(consulta, con);

            cmd.Parameters.Add(new SqlParameter("@salaID", idSala));

            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dr.Close();

            //if (dt != null)
            //{ 
            //    foreach (DataRow dr in dt.Rows)
            //    {
            //        entPersona ent = new entPersona();
            //        if (dr["PER_ID"] != DBNull.Value)
            //            ent.PER_ID = Convert.ToInt32(dr["PER_ID"]);
            //        if (dr["PER_NOMBRE"] != DBNull.Value)
            //            ent.PER_NOMBRE = Convert.ToString(dr["PER_NOMBRE"]);
            //        if (dr["PER_APELLIDO"] != DBNull.Value)
            //            ent.PER_APELLIDO = Convert.ToString(dr["PER_APELLIDO"]);
            //        if (dr["PER_DOCUMENTO"] != DBNull.Value)
            //            ent.PER_DOCUMENTO = Convert.ToInt32(dr["PER_DOCUMENTO"]);
            //        if (dr["PER_GENERO"] != DBNull.Value)
            //            ent.PER_GENERO = Convert.ToString(dr["PER_GENERO"]);
            //        if (dr["PER_FECHA_NAC"] != DBNull.Value)
            //            ent.PER_FECHA_NAC = Convert.ToDateTime(dr["PER_FECHA_NAC"]);
            //        if (dr["PER_TELEFONO"] != DBNull.Value)
            //            ent.PER_TELEFONO = Convert.ToString(dr["PER_TELEFONO"]);
            //        if (dr["PER_TELEFONO_2"] != DBNull.Value)
            //            ent.PER_TELEFONO_2 = Convert.ToString(dr["PER_TELEFONO_2"]);
            //        if (dr["PER_EMAIL"] != DBNull.Value)
            //            ent.PER_EMAIL = Convert.ToString(dr["PER_EMAIL"]);
            //        if (dr["PER_TPE_ID"] != DBNull.Value)
            //            ent.PER_TPE_ID = Convert.ToString(dr["PER_TPE_ID"]);
            //        if (dr["PER_LEGAJO"] != DBNull.Value)
            //            ent.PER_LEGAJO = Convert.ToString(dr["PER_LEGAJO"]);


            //        colPers.Add(ent);
            //    }
            //}

            con.Close();
            return dt; //colPers;

        }

        public DataTable traerSalasCupo()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = generarConexion();
                con.Open();

                SqlCommand com = new SqlCommand();
                com.Connection = con;

                com.CommandText = "select s.SAL_NOMBRE SALA, s.SAL_TURNO TURNO, count(gs.GRS_SAL_ID) CANTIDAD, s.SAL_CANT_ALUM MAXIMO " +
                                        "from T_GRUPO_SALA GS, T_SALA S, T_PERSONAS P " +
                                        "where p.PER_ID = gs.GRS_PER_ID " +
                                        "and gs.GRS_SAL_ID = s.SAL_ID " +
                                        "group by gs.GRS_SAL_ID, s.SAL_NOMBRE, s.SAL_TURNO, s.SAL_CANT_ALUM;";


                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet ds = new DataSet();

                da.Fill(ds);
                dt = ds.Tables[0];
                con.Close();


            }
            catch
            {
                MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return dt;
        }

    }
}
