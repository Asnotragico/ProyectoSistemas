using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionJardin
{
    public class entPersona
    {
        private Int32 p_perId;
        public Int32 PER_ID
        {
            get { return p_perId; }
            set { p_perId = value; }
        }

        private String p_perNombre;
        public String PER_NOMBRE
        {
            get { return p_perNombre; }
            set { p_perNombre = value; }
        }

        private String p_perApellido;
        public String PER_APELLIDO
        {
            get { return p_perApellido; }
            set { p_perApellido = value; }
        }

        private Int32 p_perDocumento;
        public Int32 PER_DOCUMENTO
        {
            get { return p_perDocumento; }
            set { p_perDocumento = value; }
        }

        private String p_perGenero;
        public String PER_GENERO
        {
            get { return p_perGenero; }
            set { p_perGenero = value; }
        }

        private DateTime p_perFechaNac;
        public DateTime PER_FECHA_NAC
        {
            get { return p_perFechaNac; }
            set { p_perFechaNac = value; }
        }

        private String p_perTelefono;
        public String PER_TELEFONO
        {
            get { return p_perTelefono; }
            set { p_perTelefono = value; }
        }

        private String p_perTelefono2;
        public String PER_TELEFONO_2
        {
            get { return p_perTelefono2; }
            set { p_perTelefono2 = value; }
        }

        private String p_perEmail;
        public String PER_EMAIL
        {
            get { return p_perEmail; }
            set { p_perEmail = value; }
        }

        private String p_perTpeId;
        public String PER_TPE_ID
        {
            get { return p_perTpeId; }
            set { p_perTpeId = value; }
        }

        private String p_perLegajo;
        public String PER_LEGAJO
        {
            get { return p_perLegajo; }
            set { p_perLegajo = value; }
        }

        private String p_perEstado;
        public String PER_ESTADO
        {
            get { return p_perEstado; }
            set { p_perEstado = value; }
        }

        private DateTime p_perFechaAlta;
        public DateTime PER_FECHA_ALTA
        {
            get { return p_perFechaAlta; }
            set { p_perFechaAlta = value; }
        }

        private DateTime p_perFechaMod;
        public DateTime PER_FECHA_MOD
        {
            get { return p_perFechaMod; }
            set { p_perFechaMod = value; }
        }

        private DateTime p_perFechaBaja;
        public DateTime PER_FECHA_BAJA
        {
            get { return p_perFechaBaja; }
            set { p_perFechaBaja = value; }
        }


        public entPersona()
        {

        }


    }
}
