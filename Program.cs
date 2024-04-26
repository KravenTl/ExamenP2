using ExamenP2.ClasePadre;
using ExamenP2.ClaseHija;
using ExamenP2.ClaseSubhija;

int opi = 99;
Aguila aguila = new Aguila();
Buitre buitre = new Buitre();
try
{
    do
    {
        int ver = 0;
        Console.Clear();
        Console.WriteLine("Bienvenido al aviario!!!!");
        Console.WriteLine("Por el momento solo contamos con dos especies de aves");
        Console.WriteLine("1. Aguilas");
        Console.WriteLine("2. Buitres");
        Console.WriteLine("0. Salir del aviario");
        Console.WriteLine("Que deseas hacer?");
        opi = int.Parse(Console.ReadLine());
        Console.Clear();
        if (opi != 0)
        {
            switch (opi)
            {
                case 1:
                    {
                       Console.Clear();
                        Console.WriteLine("Nombre de la especie: " + aguila.Nombre);
                        Console.WriteLine($"Cantidad de garras del {aguila.Nombre}: {aguila.cantidaddegarras}");
                        Console.WriteLine("Su velocidad inicial es de: " + aguila.Velocidadinicial + " Kilometros por hora");
                        Console.WriteLine("La cantidad de carne que puede ingerir es de: " + aguila.cantidaddecarne + " Kilogramos");
                        Console.WriteLine($"Esta ave esta entrenada, deseas ver una demostracion de como esta ave pesca?");
                        Console.WriteLine("1.Si");
                        Console.WriteLine("2.No");
                        ver = int.Parse(Console.ReadLine());
                        switch (ver)
                        {
                            case 1: 
                                {
                                    Console.Clear();
                                    aguila.pescar();
                                    Console.WriteLine($"El {aguila.Nombre} logro atrapar: {aguila.cpescados} peces");
                                    Console.ReadLine();
                                    break;
                                }
                        }
                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("Nombre de la especie: " + buitre.Nombre);
                        Console.WriteLine($"Cantidad de garras del {buitre.Nombre}: {buitre.cantidaddegarras}");
                        Console.WriteLine("Su velocidad inicial es de: " + buitre.Velocidadinicial + " Kilometros por hora");
                        Console.WriteLine("La cantidad de carne que puede ingerir es de: " + buitre.cantidaddecarroña + " gramos");
                        Console.WriteLine($"Esta ave esta entrenada, deseas ver una demostracion de como esta busca animales muertos para alimentarse de ellos?");
                        Console.WriteLine("1.Si");
                        Console.WriteLine("2.No");
                        ver = int.Parse(Console.ReadLine());
                        switch (ver)
                        {
                            case 1:
                                {
                                    Console.Clear();
                                    buitre.rapiñar();
                                    Console.WriteLine($"El {buitre.Nombre} logro encontrar: {buitre.canimalesm} animales");
                                    Console.ReadLine();
                                    break;
                                }
                        }
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Esa no es una de las opciones disponibles");
                        break;
                    }
            }
        }
    } while (opi != 0);
    {
        Console.WriteLine("Haz salido del aviario");
    }
}
catch (Exception)
{
    Console.WriteLine("Opcion no disponible");
}


