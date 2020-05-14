using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionJardin
{
    public class entUsuario
    {
        public Int32 p_usuID;
        private Int32 USU_ID
        {
            get { return p_usuID; }
            set { p_usuID = value; }
        }

        public Int32 p_usuPerId;
        private Int32 USU_PER_ID
        {
            get { return p_usuPerId; }
            set { p_usuPerId = value; }
        }

        public String p_usuUsuario;
        private String USU_USUARIO
        {
            get { return p_usuUsuario; }
            set { p_usuUsuario = value; }
        }

        public String p_usuClave;
        private String USU_CLAVE
        {
            get { return p_usuClave; }
            set { p_usuClave = value; }
        }

        public Int32 p_usuRolId;
        private Int32 USU_ROL_ID
        {
            get { return p_usuRolId; }
            set { p_usuRolId = value; }
        }

        public DateTime p_usuFechaAlta;
        private DateTime USU_FECHA_ALTA
        {
            get { return p_usuFechaAlta; }
            set { p_usuFechaAlta = value; }
        }

        public DateTime p_usuFechaMod;
        private DateTime USU_FECHA_MOD
        {
            get { return p_usuFechaMod; }
            set { p_usuFechaMod = value; }
        }

        public DateTime p_usuFechaBaja;
        private DateTime USU_FECHA_BAJA
        {
            get { return p_usuFechaBaja; }
            set { p_usuFechaBaja = value; }
        }

        public entUsuario()
        {

        }

    }
}
