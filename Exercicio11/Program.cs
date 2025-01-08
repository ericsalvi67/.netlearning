

Stack<string> lista = new Stack<string>(); // Cria uma pilha de strings, conceito de LIFO (Last In First Out)
lista.Push("Ola");
lista.Push("Mundo");
lista.Push("!");

foreach (var item in lista)
{
    Console.WriteLine(item);
}
Console.WriteLine("-----------------------");
Console.WriteLine(lista.Pop()); // Remove o ultimo item adicionado
Console.WriteLine("-----------------------");
Console.WriteLine(lista.Peek()); // Retorna o ultimo item adicionado sem remove-lo
Console.WriteLine("-----------------------");
int total = lista.Count; // Retorna a quantidade de itens na pilha