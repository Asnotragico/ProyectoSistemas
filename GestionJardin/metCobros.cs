using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using FontAwesome.Sharp;
using System.ComponentModel;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;

namespace GestionJardin
{
    public class metCobros : Conexion

    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter dta;
        DataTable dt;
        SqlDataReader dr;


        public string AutocompletarenCobros(MetroFramework.Controls.MetroTextBox pbarrabuscar)
        {

            con = generarConexion();

            con.Open();


            string consulta = "SELECT CONCAT(PER_NOMBRE, ', ', PER_APELLIDO, ' (', PER_DOCUMENTO, ')') NOMBRE  " +
                              "FROM T_PERSONAS " +
                              "WHERE PER_TPE_ID = '2'";

            cmd = new SqlCommand(consulta, con);

            dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                pbarrabuscar.AutoCompleteCustomSource.Add(dr["NOMBRE"].ToString());

            }
            dr.Close();

            con.Close();
            return consulta;



        }

        public string ExtraerDni(MetroFramework.Controls.MetroTextBox pbarrabuscao)

        {


            string info = pbarrabuscao.Text;
            string[] extraccion = info.Split('(', ')');

            return extraccion[1];

        }



        public String InsetarDatosCobrosenformBuscar(MetroFramework.Controls.MetroTextBox pbarrabuscao, MetroFramework.Controls.MetroTextBox pnomyapell, MetroFramework.Controls.MetroTextBox pdni, MetroFramework.Controls.MetroTextBox plegajo, MetroFramework.Controls.MetroComboBox pcuotas, MetroFramework.Controls.MetroTextBox pimporte, /*MetroFramework.Controls.MetroDateTime pfechacobro,*/ MetroFramework.Controls.MetroComboBox pformapago)


        {

            con = generarConexion();
            con.Open();

            metCobros ObjmetCobro = new metCobros();
            ObjmetCobro.ExtraerDni(pbarrabuscao);

            string dniencontrado = ExtraerDni(pbarrabuscao);

            string consulta = "SELECT co.COB_ID, " +
                                    "p.PER_NOMBRE + ',' + p.PER_APELLIDO NOMBRE_APELLIDO, " +
                                    "p.PER_DOCUMENTO, " +
                                    "p.PER_LEGAJO, " +
                                    "c.CUO_FECHA_VENC, " +
                                    "CONCAT(CONCAT('$', c.CUO_IMPORTE), '  ', convert(nvarchar(20), c.CUO_FECHA_VENC, 103), '  ', '(', c.CUO_ESTADO, ')') INFO_CUOTA " +
                                    "FROM T_PERSONAS p, T_CUOTA_FINAL c, T_COBRO co " +
                                    "WHERE p.PER_LEGAJO = c.CUO_PER_LEGAJO " +
                                    "AND co.COB_CUO_ID = c.CUO_ID " +
                                    "AND p.PER_DOCUMENTO = '" + dniencontrado + "' and c.CUO_ESTADO = 'PAGADA' ";

            cmd = new SqlCommand(consulta, con);



            dr = cmd.ExecuteReader();


            if (dr.Read() == true)
            {


                pnomyapell.Text = dr["NOMBRE_APELLIDO"].ToString();
                pdni.Text = dr["PER_DOCUMENTO"].ToString();
                plegajo.Text = dr["PER_LEGAJO"].ToString();



            }

            else

            {
                MessageBox.Show("El alumno ingresado no tiene registros de cuotas abonadas");
            }


            con.Close();

            con = generarConexion();
            con.Open();
            cmd = new SqlCommand(consulta, con);
            dta = new SqlDataAdapter(cmd);
            dt = new DataTable("INFO_CUOTA");
            dta.Fill(dt);


            pcuotas.DataSource = dt;
            pcuotas.DisplayMember = "INFO_CUOTA";
            pcuotas.ValueMember = "COB_ID";
            pcuotas.SelectedItem = null;



            con.Close();

            return dniencontrado;


        }

        public string ExtraerImporte(MetroFramework.Controls.MetroComboBox pcuotas)

        {
            string infocuota = pcuotas.Text;
            string[] extraer = infocuota.Split(' ');
            return extraer[0];

        }

        public String InsertarDatosCobrosenformAgregar(MetroFramework.Controls.MetroTextBox pbarrabuscao, MetroFramework.Controls.MetroTextBox pnomyapell, MetroFramework.Controls.MetroTextBox pdni, MetroFramework.Controls.MetroTextBox plegajo, MetroFramework.Controls.MetroComboBox pcuotas, MetroFramework.Controls.MetroTextBox pimporte, /*MetroFramework.Controls.MetroDateTime pfechacobro,*/ MetroFramework.Controls.MetroComboBox pformapago)


        {

            con = generarConexion();
            con.Open();

            metCobros ObjmetCobro = new metCobros();
            ObjmetCobro.ExtraerDni(pbarrabuscao);

            string dniencontrado = ExtraerDni(pbarrabuscao);



            string consulta = "SELECT DISTINCT (p.PER_NOMBRE + ',' + p.PER_APELLIDO)NOMBRE_APELLIDO, " +
                                                "p.PER_DOCUMENTO, " +
                                                "p.PER_LEGAJO, " +
                                                "c.CUO_FECHA_VENC, " +
                                                "CONCAT( CONCAT ('$', c.CUO_IMPORTE) ,  '  ' , c.CUO_FECHA_VENC, '  ', '(' , c.CUO_ESTADO , ')')INFO_CUOTA " +
                              "FROM T_PERSONAS p , T_CUOTA_FINAL c " +
                              "WHERE p.PER_LEGAJO = c.CUO_PER_LEGAJO " +
                              "AND p.PER_DOCUMENTO = '" + dniencontrado + "' " +
                              "AND c.CUO_ESTADO = 'ADEUDADA' ";

            cmd = new SqlCommand(consulta, con);



            dr = cmd.ExecuteReader();


            if (dr.Read() == true)
            {


                pnomyapell.Text = dr["NOMBRE_APELLIDO"].ToString();
                pdni.Text = dr["PER_DOCUMENTO"].ToString();
                plegajo.Text = dr["PER_LEGAJO"].ToString();



            }

            else

            {
                MessageBox.Show("El alumno ingresado no tiene registros de cuotas pendientes de cobro");
            }


            con.Close();

            con = generarConexion();
            con.Open();
            cmd = new SqlCommand(consulta, con);
            dta = new SqlDataAdapter(cmd);
            dt = new DataTable("INFO_CUOTA");
            dta.Fill(dt);


            pcuotas.DataSource = dt;
            pcuotas.DisplayMember = "INFO_CUOTA";
            pcuotas.SelectedItem = null;
            //pcuotas.SelectedIndex = 0;



            con.Close();

            return dniencontrado;


        }

        public string ExtraerFechaVenc(MetroFramework.Controls.MetroComboBox pcuotas)

        {
            string infocuota = pcuotas.Text;
            string[] extraer = infocuota.Split(' ');
            return extraer[2];

        }

        public string ModificarEstadoCuota(MetroFramework.Controls.MetroComboBox pcuotas, MetroFramework.Controls.MetroTextBox plegajo, MetroFramework.Controls.MetroTextBox pbarrabuscao)

        {
            con = generarConexion();
            con.Open();
            metCobros ObjMetCobros = new metCobros();
            ObjMetCobros.ExtraerFechaVenc(pcuotas);

            string FechaVencEncontrada = ExtraerFechaVenc(pcuotas);
            Convert.ToDateTime(FechaVencEncontrada).ToString("yyyy-MM-dd");

            string nlegajo = plegajo.Text;
            string consulta = "UPDATE T_CUOTA_FINAL " +
                              "SET CUO_ESTADO = 'PAGADA' " +
                              "WHERE CUO_FECHA_VENC =  '" + FechaVencEncontrada + "' " +
                              "AND CUO_PER_LEGAJO = '" + nlegajo + "'";

            cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();

            con.Close();


            con = generarConexion();
            con.Open();
            metCobros ObjMetCobro = new metCobros();
            ObjMetCobro.ExtraerDni(pbarrabuscao);

            string dniencontrado = ExtraerDni(pbarrabuscao);

            string consulta1 = "SELECT DISTINCT (p.PER_NOMBRE + ',' + p.PER_APELLIDO)NOMBRE_APELLIDO, " +
                                                "p.PER_DOCUMENTO, " +
                                                "p.PER_LEGAJO, " +
                                                "c.CUO_FECHA_VENC, " +
                                                "CONCAT( CONCAT ('$', c.CUO_IMPORTE) ,  '  ' , c.CUO_FECHA_VENC, '  ', '(' , c.CUO_ESTADO , ')')INFO_CUOTA " +
                                                "FROM T_PERSONAS p , T_CUOTA_FINAL c " +
                                                "WHERE p.PER_LEGAJO = c.CUO_PER_LEGAJO " +
                                                "AND p.PER_DOCUMENTO = '" + dniencontrado + "' " +
                                                "AND c.CUO_ESTADO = 'ADEUDADA' ";
            cmd = new SqlCommand(consulta1, con);
            dta = new SqlDataAdapter(cmd);
            dt = new DataTable("INFO_CUOTA");
            dta.Fill(dt);


            pcuotas.DataSource = dt;
            pcuotas.DisplayMember = "INFO_CUOTA";

            pcuotas.SelectedItem = null;
            //pcuotas.SelectedIndex = 0;

            //if (pcuotas.SelectedIndex == -1)
            //{
            //    MessageBox.Show("El alumno ingresado no tiene registros de cuotas pendientes de cobro");
            //}

            //pcuotas.SelectedIndex = -1;

            con.Close();

            return MessageBox.Show("Se registro el cobro. La cuota se encuentra PAGADA").ToString();

        }

        public string AnularCobro(int idCobro)
        {
            string result;

            try
            {
                con = generarConexion();
                con.Open();
                string consulta = "UPDATE T_COBRO " +
                                  "SET COB_ESTADO = 'BAJA' " +
                                  "WHERE COB_ID = " + idCobro + ";";


                cmd = new SqlCommand(consulta, con);
                cmd.ExecuteNonQuery();
                con.Close();

                result = "OK";

            }
            catch
            {
                result = "ERROR";
              //  MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (result == "OK")
            {
                result = ActualizaAnuladoEnCuota(idCobro);
            } else
            {
                result = "ERROR2";
            }


            return result;

        }

        public string ActualizaAnuladoEnCuota(int idCobro)
        {
            string result;

            try
            {
                con = generarConexion();
                con.Open();
                string consulta = "UPDATE T_CUOTA_FINAL " +
                                  "SET CUO_ESTADO = 'ADEUDADA' " +
                                  "WHERE CUO_ID = ( SELECT CF.CUO_ID " +
                                                     "FROM T_COBRO C, T_CUOTA_FINAL CF " +
                                                     "WHERE C.COB_CUO_ID = CF.CUO_ID " +
                                                     "AND C.COB_ID = " + idCobro + " );";


                cmd = new SqlCommand(consulta, con);
                cmd.ExecuteNonQuery();
                con.Close();

                result = "OK";

            }
            catch
            {
                result = "ERROR";
            //    MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return result;

        }

        public string ExtraercoutaId(MetroFramework.Controls.MetroComboBox pcuotas, MetroFramework.Controls.MetroTextBox plegajo)
        {
            con = generarConexion();

            con.Open();

            metCobros ObjMetCobros = new metCobros();
            ObjMetCobros.ExtraerFechaVenc(pcuotas);

            string nlegajo = plegajo.Text;

            string FechaVencEncontrada = ExtraerFechaVenc(pcuotas);
            DateTime fecha = Convert.ToDateTime(FechaVencEncontrada);

            string consulta = "SELECT  c.CUO_ID CUOTA_ID " +
                              "FROM T_CUOTA_FINAL c  " +
                              "WHERE  c.CUO_FECHA_VENC = '" + FechaVencEncontrada + "' " +
                              "AND c.CUO_PER_LEGAJO = '" + nlegajo + "' " +
                              "AND c.CUO_ESTADO = 'ADEUDADA' ";
            cmd = new SqlCommand(consulta, con);
           

            dta = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dta.Fill(dt);

            string extraer = "";

            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["CUOTA_ID"] != DBNull.Value)
                        extraer = Convert.ToString(dr["CUOTA_ID"]);
                }
            }


            con.Close();
            return extraer;



        }

        public string InsertarenTCobros(MetroFramework.Controls.MetroComboBox pcuotas, MetroFramework.Controls.MetroTextBox plegajo)

        {
            string result;

            try
            {
                SqlConnection con1;
                con1 = generarConexion();
                con1.Open();


                string cuoId = ExtraercoutaId(pcuotas, plegajo);

                string consulta = "INSERT INTO T_COBRO ( COB_CUO_ID, COB_ESTADO, COB_IMPORTE, COB_FECHA, COB_FORMA_PAGO ) " +
                                              "VALUES ( " + cuoId + ", 'TOTAL', (SELECT cf.CUO_IMPORTE FROM T_CUOTA_FINAL cf WHERE cf.CUO_ID = " + cuoId + "), GETDATE(), 'EFECTIVO');";

                cmd = new SqlCommand(consulta, con1);
                cmd.ExecuteNonQuery();
                con1.Close();

                result = "OK";

            }
            catch
            {
                result = "ERROR";
          //     MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return result;
        }
    

    }
}
