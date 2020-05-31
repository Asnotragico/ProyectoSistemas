using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionJardin
{
    public class entGrupoFlia
    {
        private Int32 p_grfID;
        public Int32 GRF_ID
        {
            get { return p_grfID; }
            set { p_grfID = value; }
        }

        private Int32 p_grf_PerID;
        public Int32 GRF_PER_ID
        {
            get { return p_grf_PerID; }
            set { p_grf_PerID = value; }
        }

        private string p_grfTutor;
        public string GRF_TUTOR
        {
            get { return p_grfTutor; }
            set { p_grfTutor = value; }
        }

        private string p_grfAutorizado;
        public string GRF_AUTORIZADO
        {
            get { return p_grfAutorizado; }
            set { p_grfAutorizado = value; }
        }

        private string p_grfLegajo;
        public string GRF_PER_LEGAJO
        {
            get { return p_grfLegajo; }
            set { p_grfLegajo = value; }
        }

        private string p_grfObservacion;
        public string GRF_OBSERVACION
        {
            get { return p_grfObservacion; }
            set { p_grfObservacion = value; }
        }


        public entGrupoFlia()
        { }
    }
}
