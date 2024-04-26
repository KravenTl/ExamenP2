using Delegados.ClasesDelegados;

namespace Delegados
{
    public delegate void delagadosal_des(string m);

    class Program
    {
        static void Main(string[] args)
        {
            delagadosal_des delegado = new delagadosal_des(Csaludo.saludar);
            delegado("Hola que hacen");

            delegado = new delagadosal_des(Cdespedida.despedir);
            delegado("Nos vemos luego");

        }
    }
}
