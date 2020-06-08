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
             cmd = new SqlCommand(consulta,con);

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
            try { 

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
        
    }
}
