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

           // cmd.CommandText = "SELECT * FROM T_SALA S WHERE S.SAL_TURNO = @turnoSala";

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
    }
}
