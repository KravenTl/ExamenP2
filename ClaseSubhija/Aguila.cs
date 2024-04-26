using ExamenP2.ClaseHija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExamenP2.ClaseSubhija
{
    public class Aguila:Rapaces
    {
        public int cantidaddecarne;
        private int pescados = 1;

        public Aguila()
        {
            this.Nombre = "Aguila Calva";
            this.Velocidadinicial = 50;
            this.cantidaddegarras = 8;
            this.cantidaddecarne = 4;
        }
        public void pescar()
        {
            Console.WriteLine("Va a pescar");
        }
        public override string comer()
        {
            return "Se alimenta de carne fresca";
        }
        public int cpescados
        {
            get
            {
                return pescados;
            }
            set
            {
                if (value > 0)
                {
                    pescados = value;
                }
                else
                {
                    pescados = 0;
                }
            }
        }
    }
}
