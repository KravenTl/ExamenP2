using ExamenP2.ClaseHija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExamenP2.ClaseSubhija
{
    public class Buitre:Rapaces
    {
        public double cantidaddecarroña;
        private int animalesmuertos = 2;
        public Buitre()
        {
            this.Nombre = "Buitre cabezinegro";
            this.Velocidadinicial = 30;
            this.cantidaddegarras = 6;
            this.cantidaddecarroña = 0.500;

        }
        public void rapiñar()
        {
            Console.WriteLine("Busca algun animal muerto");
        }
        public override string comer()
        {
            return "Se alimenta de un animal muerto";
        }
        public int canimalesm
        {
            get
            {
                return animalesmuertos;
            }
            set
            {
                if (animalesmuertos > 0)
                {
                    animalesmuertos = value;
                }
                else
                {
                    animalesmuertos = 0;
                }
            }
        }

    }
}
