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
                SqlConnection con = generarConexion();

                con.Open();                         // abro conexion

                SqlCommand com = new SqlCommand();  //inicializo el comando
                com.Connection = con;               //asigno conexion al comando
                com.CommandText = "select * " +
                                    "from t_usuarios u " +
                                    "where u.usu_usuario = @usuario " +
                                    //"and u.udu_clave = @clave " +
                                    ";";               //asigno la búsqueda sql al comando

                com.Parameters.Add(new SqlParameter("@usuario", usuario.p_usuUsuario));



                SqlDataAdapter da = new SqlDataAdapter(com);

                DataSet ds = new DataSet();

                da.Fill(ds);

                dt = ds.Tables[0];

                con.Close();

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
