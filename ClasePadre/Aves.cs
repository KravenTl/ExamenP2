using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenP2.ClasePadre
{
    public class Aves
    {
        public string Nombre;
        protected int Alas = 2;
        public int Velocidadinicial;
        public virtual string comer()
        {
            return "Se alimenta";
        }
    }
}
