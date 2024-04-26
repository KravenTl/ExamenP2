using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexador.ClasePersona
{
    internal class Cverpersonas
    {
        private Cpersona []presentes;
        public Cverpersonas()
        {
            presentes = new Cpersona[4];
            presentes[0] = new Cpersona("Marvin", 18, "Masculino");
            presentes[1] = new Cpersona("Yenci", 22, "Femenino");
            presentes[2] = new Cpersona("Carlos", 18, "Masculino");
            presentes[3] = new Cpersona("Alan", 23, "Masculino");

        }
        public Cpersona this[int posicion]
        {
            get { return presentes[posicion];}
            set { presentes[posicion] = value;}
        }

    }
}
