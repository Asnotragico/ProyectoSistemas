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
    public class metUsuario : Conexion
    {

        public DataTable buscarUsuario(entUsuario usuario)
        {

            DataTable dt = new DataTable();

            try
            {
      /*1*/    SqlConnection con = generarConexion();

      /*2*/     con.Open();                         // abro conexion

      /*3*/     SqlCommand com = new SqlCommand();  //inicializo el comando
      /*4*/     com.Connection = con;               //asigno conexion al comando
      /*5*/     com.CommandText = "select * " +
                                    "from t_usuarios u " +
                                    "where u.usu_usuario = @usuario " +
                                    ";";               //asigno la búsqueda sql al comando

      /*6*/     com.Parameters.Add(new SqlParameter("@usuario", usuario.p_usuUsuario));

      /*7*/     SqlDataAdapter da = new SqlDataAdapter(com);
      /*8*/     DataSet ds = new DataSet();
      /*9*/     da.Fill(ds);
     /*10*/     dt = ds.Tables[0];
     /*11*/     con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return dt;

        }



        public bool ingresar(string usuario, string contrasena)
        {
            bool valido = new bool();

            entUsuario usr = new entUsuario();
            usr.p_usuUsuario = usuario;

            DataTable t_usuario = buscarUsuario(usr);

            if (t_usuario.Rows.Count == 0)
            {
                valido = false;
            }

            else if (t_usuario.Rows[0]["USU_CLAVE"].ToString() == contrasena)

            {
                valido = true;
            } else
            {
                valido = false;
            }


            return valido;
        }

    }
}
