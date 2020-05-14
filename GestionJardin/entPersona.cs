using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionJardin
{
    public class entPersona
    {
        public Int32 p_perId;
        private Int32 PER_ID
        {
            get { return p_perId; }
            set { p_perId = value; }
        }

        public String p_perNombre;
        private String PER_NOMBRE
        {
            get { return p_perNombre; }
            set { p_perNombre = value; }
        }

        public String p_perApellido;
        private String PER_APELLIDO
        {
            get { return p_perApellido; }
            set { p_perApellido = value; }
        }

        public Int32 p_perDocumento;
        private Int32 PER_DOCUMENTO
        {
            get { return p_perDocumento; }
            set { p_perDocumento = value; }
        }

        public String p_perGenero;
        private String PER_GENERO
        {
            get { return p_perGenero; }
            set { p_perGenero = value; }
        }

        public DateTime p_perFechaNac;
        private DateTime PER_FECHA_NAC
        {
            get { return p_perFechaNac; }
            set { p_perFechaNac = value; }
        }

        public String p_perTelefono;
        private String PER_TELEFONO
        {
            get { return p_perTelefono; }
            set { p_perTelefono = value; }
        }

        public String p_perTelefono2;
        private String PER_TELEFONO_2
        {
            get { return p_perTelefono2; }
            set { p_perTelefono2 = value; }
        }

        public String p_perEmail;
        private String PER_EMAIL
        {
            get { return p_perEmail; }
            set { p_perEmail = value; }
        }

        public String p_perTipo;
        private String PER_TIPO
        {
            get { return p_perTipo; }
            set { p_perTipo = value; }
        }

        public String p_perLegajo;
        private String PER_LEGAJO
        {
            get { return p_perLegajo; }
            set { p_perLegajo = value; }
        }

        public String p_perEstado;
        private String PER_ESTADO
        {
            get { return p_perEstado; }
            set { p_perEstado = value; }
        }

        public DateTime p_perFechaAlta;
        private DateTime PER_FECHA_ALTA
        {
            get { return p_perFechaAlta; }
            set { p_perFechaAlta = value; }
        }

        public DateTime p_perFechaMod;
        private DateTime PER_FECHA_MOD
        {
            get { return p_perFechaMod; }
            set { p_perFechaMod = value; }
        }

        public DateTime p_perFechaBaja;
        private DateTime PER_FECHA_BAJA
        {
            get { return p_perFechaBaja; }
            set { p_perFechaBaja = value; }
        }


        public entPersona()
        {

        }


    }
}
