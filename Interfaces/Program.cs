using Interfaces.Operar;
using Interfaces.Operar.Operaciones;

int v1 = 0, v2 = 0;
int opi = 9;
try
{
    do
    {
        Console.Clear();
        Console.WriteLine("Ingrese los dos numeros");
        v1 = int.Parse(Console.ReadLine());
        v2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Que desea hacer");
        Console.WriteLine("1.Suma");
        Console.WriteLine("2.Resta");
        Console.WriteLine("3.Numero mayor");
        Console.WriteLine("4.Numero menor");
        opi = int.Parse(Console.ReadLine());
        if(opi != 0) {
            switch (opi)
            {
                case 1:
                    {
                        Ioperar operar = new Csuma();
                        operar.calcular(v1, v2);
                        operar.verresul();
                        Console.ReadLine();
                        break;
                    }
                case 2:
                    {
                        Ioperar operar = new Cresta();
                        operar.calcular(v1, v2);
                        operar.verresul();
                        Console.ReadLine();
                        break;
                    }
                case 3:
                    {
                        Ioperar operar = new Cnummayor();
                        operar.calcular(v1, v2);
                        operar.verresul();
                        Console.ReadLine();
                        break;
                    }
                case 4:
                    {
                        Ioperar operar = new Cnummenor();
                        operar.calcular(v1, v2);
                        operar.verresul();
                        Console.ReadLine();
                        break;
                    }
            }
        }
    } while (opi != 0);
    {
        Console.WriteLine("Saliste de la calculadora");
    }
}catch (Exception)
{
    Console.WriteLine("Valor invalido");
}