using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexador.ClasePersona
{
    internal class Cpersona
    {
        public string nombre;
        public int edad;
        public string sexo;
        
        public Cpersona(string onombre, int oedad, string osexo)
        {
            this.nombre = onombre;
            this.edad = oedad;
            this.sexo = osexo;
        }
        public void verpersona()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: "+edad);
            Console.WriteLine("Sexo: "+sexo);
        }
    }
}
