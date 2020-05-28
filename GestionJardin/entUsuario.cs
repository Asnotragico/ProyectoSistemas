using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionJardin
{
    public class entUsuario
    {
        private Int32 p_usuID;
        public Int32 USU_ID
        {
            get { return p_usuID; }
            set { p_usuID = value; }
        }

        private Int32 p_usuPerId;
        public Int32 USU_PER_ID
        {
            get { return p_usuPerId; }
            set { p_usuPerId = value; }
        }

        private String p_usuUsuario;
        public String USU_USUARIO
        {
            get { return p_usuUsuario; }
            set { p_usuUsuario = value; }
        }

        private String p_usuClave;
        public String USU_CLAVE
        {
            get { return p_usuClave; }
            set { p_usuClave = value; }
        }

        private Int32 p_usuRolId;
        public Int32 USU_ROL_ID
        {
            get { return p_usuRolId; }
            set { p_usuRolId = value; }
        }

        private DateTime p_usuFechaAlta;
        public DateTime USU_FECHA_ALTA
        {
            get { return p_usuFechaAlta; }
            set { p_usuFechaAlta = value; }
        }

        private DateTime p_usuFechaMod;
        public DateTime USU_FECHA_MOD
        {
            get { return p_usuFechaMod; }
            set { p_usuFechaMod = value; }
        }

        private DateTime p_usuFechaBaja;
        public DateTime USU_FECHA_BAJA
        {
            get { return p_usuFechaBaja; }
            set { p_usuFechaBaja = value; }
        }

        public entUsuario()
        {

        }

    }
}
