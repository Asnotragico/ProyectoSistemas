using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public DataTable ListarSalas(int turno)

        {
            con = generarConexion();
            string turnoR;

            DataTable Tabla = new DataTable();
            con.Open();

            string consulta = "SELECT * FROM T_SALA S WHERE S.SAL_TURNO = @turnoSala";
            cmd = new SqlCommand(consulta,con);

            if (turno == 0)
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
    }
}
