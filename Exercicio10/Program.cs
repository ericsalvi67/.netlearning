

/*List<int> numeros = new List<int>() {1,0,9,6,3,5,2,8,7,4 };
numeros.Sort();
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}*/

Queue<string> numeros = new Queue<string>();
numeros.Enqueue("ola");
numeros.Enqueue("mundo");
numeros.Enqueue("!");


foreach (string palavra in numeros)
{
    Console.WriteLine(palavra);
}

Console.WriteLine("-------------------------------------");

numeros.Dequeue(); //remove o primeiro elemento da fila

foreach (string palavra in numeros)
{
    Console.WriteLine(palavra);
}

int total = numeros.Count;

Console.WriteLine("-------------------------------------");
Console.WriteLine(numeros.Peek()); //mostra o primeiro elemento da fila
