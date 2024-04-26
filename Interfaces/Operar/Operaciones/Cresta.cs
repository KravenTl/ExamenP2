using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Operar.Operaciones
{
    internal class Cresta : Ioperar
    {
        private double resul = 0;

        public void calcular(double x, double y)
        {
            resul = x - y;
        }
        public void verresul()
        {
            Console.WriteLine("El resultado de la resta es: " + resul);
        }
    }
}