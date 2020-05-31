using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionJardin
{
    public class entTipoPersona
    {
        private Int32 p_tpe_ID;
        public Int32 TPE_ID
        {
            get { return p_tpe_ID; }
            set { p_tpe_ID = value; }
        }

        private string p_tpeNombre;
        public string TPE_NOMBRE
        {
            get { return p_tpeNombre; }
            set { p_tpeNombre = value; }
        }

        public entTipoPersona()
        { }

        public class enTipoPersonaColeccion : List<entTipoPersona>
        { }

    }
}
