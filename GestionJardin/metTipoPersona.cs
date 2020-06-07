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

        public entTipoPersona.enTipoPersonaColeccion buscarTipoPersonas()
        {
            entTipoPersona.enTipoPersonaColeccion TipoPerCol = new entTipoPersona.enTipoPersonaColeccion();

            try
            {

                SqlConnection con = generarConexion();
                con.Open();

                SqlCommand com = new SqlCommand();
                com.Connection = con;

                com.CommandText = "select * " +
                                    "from T_TIPO_PERSONA" +
                                    ";";

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet ds = new DataSet();

                da.Fill(ds, "T_SALA");
                dt = ds.Tables[0];
                con.Close();

                if (dt != null)
                    foreach (DataRow dr in dt.Rows)
                    {
                        entTipoPersona ent = new entTipoPersona();
                        if (dr["TPE_ID"] != DBNull.Value)
                            ent.TPE_ID = Convert.ToInt32(dr["TPE_ID"]);
                        if (dr["TPE_NOMBRE"] != DBNull.Value)
                            ent.TPE_NOMBRE = Convert.ToString(dr["TPE_NOMBRE"]);


                        TipoPerCol.Add(ent);
                    }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return TipoPerCol;

        }
    }
}
