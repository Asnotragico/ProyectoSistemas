using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionJardin
{
    public class metTipoPersona : Conexion
    {

        SqlCommand cmd = new SqlCommand();
        SqlConnection con;
        SqlDataReader dr;

        //private Conexion Conexion = new Conexion();
        //private SqlCommand Comando = new SqlCommand();
        //private SqlDataReader leerFilas;

        public DataTable ListarTipoPersona()

        {
            con = generarConexion();

            DataTable Tabla = new DataTable();
            con.Open();

            string consulta = "SELECT * FROM T_TIPO_PERSONA";

            cmd = new SqlCommand(consulta,con);
            dr = cmd.ExecuteReader();
            Tabla.Load(dr);
            dr.Close();

            con.Close();
            return Tabla;
        }
    }
}
