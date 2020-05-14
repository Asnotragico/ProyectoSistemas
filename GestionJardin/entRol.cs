using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionJardin
{
    public class entRol
    {
    
        public Int32 p_rolId;
        private Int32 ROL_ID
        {
            get { return p_rolId; }
            set { p_rolId = value; }
        }

        public String p_rolNombre;
        private String ROL_NOMBRE
        {
            get { return p_rolNombre; }
            set { p_rolNombre = value; }
        }

        public entRol()
        {

        }


    }
}
