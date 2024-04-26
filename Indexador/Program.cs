using Indexador.ClasePersona;
int p=2;

Cverpersonas personitas= new Cverpersonas();
Cpersona gente= personitas[0];
gente.verpersona();

Console.WriteLine();
Console.WriteLine("Listado completo de las personas: ");
for(int i = 0; i < 4; i++)
{
    personitas[i].verpersona();
}