using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionJardin
{
    public class entSala
    {
        private int p_sal_Id;
        public int SAL_ID
        {
            get { return p_sal_Id; }
            set { p_sal_Id = value; }
        }

        private string p_sal_Nombre;
        public string SAL_NOMBRE
        {
            get { return p_sal_Nombre; }
            set { p_sal_Nombre = value; }
        }

        private int p_sal_Edad_Min;
        public int SAL_EDAD_MIN
        {
            get { return p_sal_Edad_Min; }
            set { p_sal_Edad_Min = value; }
        }

        private int p_sal_Edad_Max;
        public int EDAD_SALA_MAX
        {
            get { return p_sal_Edad_Max; }
            set { p_sal_Edad_Max = value; }
        }


        private int p_sal_Cant_Alum;
        public int SALA_CANT_ALUM
        {
            get { return p_sal_Cant_Alum; }
            set { p_sal_Cant_Alum = value; }
        }

        private string p_sala_Turno;
        public string SALA_TURNO
        {
            get { return p_sala_Turno; }
            set { p_sala_Turno = value; }
        }

        private string p_sala_Activo;
        public string SALA_ACTIVO
        {
            get { return p_sala_Activo; }
            set { p_sala_Activo = value; }
        }

        //creo método

        public entSala()
        { }

        public class entSalaColeccion : List<entSala>
        {
        }
    }
}
