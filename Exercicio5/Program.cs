const string Ap = "Aprovado";
const string Rp = "Reprovado";
const string Rec = "RECUPERACAO";

Console.WriteLine("Digite a nota: ");
decimal nota = Convert.ToDecimal(Console.ReadLine());

if(nota >= 6)
{
    Console.WriteLine(Ap);
}
else if (nota < 6 && nota >= 4)
{
    Console.WriteLine(Rec);
}
else
{
    Console.WriteLine(Rp);
}

const string d28 = "Fevereiro tem 28 dias";
const string d30 = "Mês com 30 dias";
const string d31 = "Mês com 31 dias";
const string erro = "Mês invalido";

Console.WriteLine("Digite o mês: ");
string mes = Console.ReadLine();

switch (mes.ToLower())
{
    case "janeiro":
    case "marco":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine(d31);
        break;
    case "abril":
    case "junho":
    case "setembro":
    case "novembro":
        Console.WriteLine(d30);
        break;
    case "fevereiro":
        Console.WriteLine(d28);
        break;
    default:
        Console.WriteLine(erro);
        break;
}

