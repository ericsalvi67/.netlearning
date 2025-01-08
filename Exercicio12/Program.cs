

SortedList<int, string> lista = new SortedList<int, string>();
lista.Add(4, "RJ");
lista.Add(1, "SC");
lista.Add(3, "SP");
lista.Add(2, "MG");
Console.WriteLine("-----------------------");
foreach (string estado in lista.Values)
{
    Console.WriteLine(estado);
}
Console.WriteLine("-----------------------");
