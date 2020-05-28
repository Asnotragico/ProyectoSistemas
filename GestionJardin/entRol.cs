using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionJardin
{
    public class entRol
    {

        private Int32 p_rolId;
        public Int32 ROL_ID
        {
            get { return p_rolId; }
            set { p_rolId = value; }
        }

        private String p_rolNombre;
        public String ROL_NOMBRE
        {
            get { return p_rolNombre; }
            set { p_rolNombre = value; }
        }

        public entRol()
        {

        }


    }
}
