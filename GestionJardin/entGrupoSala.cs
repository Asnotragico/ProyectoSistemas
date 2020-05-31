using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionJardin
{
    public class entGrupoSala
    {
        private Int32 p_grsID;
        public Int32 GRS_ID
        {
            get { return p_grsID; }
            set { p_grsID = value; }
        }

        private Int32 p_grs_SalID;
        public Int32 GRS_SAL_ID
        {
            get { return p_grs_SalID; }
            set { p_grs_SalID = value; }
        }

        private Int32 p_grs_PerID;
        public Int32 GRS_PER_ID
        {
            get { return p_grs_PerID; }
            set { p_grs_PerID = value; }
        }

        public entGrupoSala()
        { }
    }
}
