using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionJardin
{
    public class entConcepto
    {
        private string p_concepto;
        public string CON_CONCEPTO
        {
            get { return p_concepto; }
            set { p_concepto = value; }
        }

        private double p_valoractual;
        public double CON_VALOR_ACTUAL
        {
            get { return p_valoractual; }
            set { p_valoractual = value; }
        }

        private double p_valoranterior;
        public double CON_VALOR_ANTERIOR
        {
            get { return p_valoranterior; }
            set { p_valoranterior = value; }
        }

        private DateTime p_fechainicio;
        public DateTime CON_FECHA_INI
        {
            get { return p_fechainicio; }
            set { p_fechainicio = value; }
        }

        private DateTime p_fechafin;
        public DateTime CON_FECHA_FIN
        {
            get { return p_fechafin; }
            set { p_fechafin = value; }
        }
        private DateTime p_fecha_activo;
        public DateTime CON_FECHA_ACT
        {
            get { return p_fecha_activo; }
            set { p_fecha_activo = value; }
        }
        private Int32 p_activo;
        public Int32 CON_ACT
        {
            get { return p_activo; }
            set { p_activo = value; }
        }

        public entConcepto()
        {

        }

    }

}
