
int[] v = { 0, 1, 2, 3, 4, 5};

foreach (int numero in v) //similar ao for ou while, mas mais simples
{
    Console.WriteLine(numero);
}
Console.WriteLine("Fim do loop foreach\n");

for (int i = 0; i < v.Length; i++)
{
    Console.WriteLine(v[i]);
}