


int[] ints = new int[] {1,2,3,4,5};
int num = ints[0];

Console.WriteLine($"{num}\n"); // 1

int total = ints.Length;

List <int> list = new List<int>();
List<int> list2 = new List<int>() {1,2,3,4,5};

int count = list2.Count;
list2.Add(6);
list2.Remove(3);


int num2 = list2.ElementAt(2);
Console.WriteLine($"{num2}\n");

foreach (int i in list2)
{
    Console.WriteLine(i);
}

list2.Clear();