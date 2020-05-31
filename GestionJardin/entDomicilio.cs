using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionJardin
{
    public class entDomicilio
    {
        private Int32 p_domID;
        public Int32 DOM_ID
        {
            get { return p_domID; }
            set { p_domID = value; }
        }

        private Int32 p_dom_PerID;
        public Int32 DOM_PER_ID
        {
            get { return p_dom_PerID; }
            set { p_dom_PerID = value; }
        }

        private string p_domCalle;
        public string DOM_CALLE
        {
            get { return p_domCalle; }
            set { p_domCalle = value; }
        }

        private Int32 p_domNumero;
        public Int32 DOM_NUMERO
        {
            get { return p_domNumero; }
            set { p_domNumero = value; }
        }

        private Int32 p_domPiso;
        public Int32 DOM_PISO
        {
            get { return p_domPiso; }
            set { p_domPiso = value; }
        }

        private string p_domDpto;
        public string DOM_DPTO
        {
            get { return p_domDpto; }
            set { p_domDpto = value; }
        }

        private string p_domBarrio;
        public string DOM_BARRIO
        {
            get { return p_domBarrio; }
            set { p_domBarrio = value; }
        }

        private Int32 p_domCP;
        public Int32 DOM_CP
        {
            get { return p_domCP; }
            set { p_domCP = value; }
        }

        private string p_domProvincia;
        public string DOM_PROVINCIA
        {
            get { return p_domProvincia; }
            set { p_domProvincia = value; }
        }

        private string p_domPais;
        public string DOM_PAIS
        {
            get { return p_domPais; }
            set { p_domPais = value; }
        }

        private string p_domTipo;
        public string DOM_TIPO
        {
            get { return p_domTipo; }
            set { p_domTipo = value; }
        }


        public entDomicilio()
        { }
    }
}
