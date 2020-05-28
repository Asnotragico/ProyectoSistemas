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
    public class metCuota : Conexion
    {

        public entSala.entSalaColeccion buscarSalas()
        {
            entSala.entSalaColeccion SalaCol = new entSala.entSalaColeccion();
   
            try
            {

                SqlConnection con = generarConexion();
                con.Open();

                SqlCommand com = new SqlCommand();
                com.Connection = con;

                com.CommandText = "select * " +
                                    "from T_SALA u " +
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
                        entSala ent = new entSala();
                        if (dr["SAL_ID"] != DBNull.Value)
                            ent.SAL_ID = Convert.ToInt32(dr["SAL_ID"]);
                        if (dr["SAL_NOMBRE"] != DBNull.Value)
                            ent.SAL_NOMBRE = Convert.ToString(dr["SAL_NOMBRE"]);
                        if (dr["SAL_EDAD_MIN"] != DBNull.Value)
                            ent.SAL_EDAD_MIN = Convert.ToInt32(dr["SAL_EDAD_MIN"]);
                        if (dr["SAL_EDAD_MAX"] != DBNull.Value)
                            ent.EDAD_SALA_MAX = Convert.ToInt32(dr["SAL_EDAD_MAX"]);
                        if (dr["SAL_CANT_ALUM"] != DBNull.Value)
                            ent.SALA_CANT_ALUM = Convert.ToInt32(dr["SAL_CANT_ALUM"]);
                        if (dr["SAL_TURNO"] != DBNull.Value)
                            ent.SALA_TURNO = Convert.ToString(dr["SAL_TURNO"]);
                        if (dr["SAL_ACTIVO"] != DBNull.Value)
                            ent.SALA_ACTIVO = Convert.ToString(dr["SAL_ACTIVO"]);

                        SalaCol.Add(ent);
                    }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return SalaCol;

        }


    }
}
