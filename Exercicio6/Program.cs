int i = 0;

while (i < 10)
{
    Console.WriteLine(i);
    i++;
}

Console.WriteLine("Fim do loop while\n");

for (int k=0; k < 10; k++)
{
    Console.WriteLine(k);
}

Console.WriteLine("Fim do loop for\n");

i = 0;
int[] v = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
while (i < v.Length)
{
    Console.WriteLine($"{v[10-i]}\n");
    i++;
}