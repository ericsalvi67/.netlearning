

Dictionary<int,string> estados = new Dictionary<int, string>();
estados.Add(1, "São Paulo");
estados.Add(2, "Rio de Janeiro");
estados.Add(3, "Minas Gerais");

if(!estados.ContainsKey(4))
{
    estados.Add(4, "Santa Catarina");
}

foreach (string estado in estados.Values)
{
    Console.WriteLine(estado);
}

string est = null;
if(estados.TryGetValue(3, out est))
{
    Console.WriteLine(est);
}