string frase = "O rato roeu a roupa do rei de Roma!";


Console.WriteLine(frase.Substring(0, 6)); // O rato
Console.WriteLine(frase.Replace("rato", "macaco")); // O macaco roeu a roupa do rei de Roma
Console.WriteLine(frase.Trim('!')); 
Console.WriteLine(frase.ToUpper()); // O RATO ROEU A ROUPA DO REI DE ROMA
Console.WriteLine(frase.ToLower()); // o rato roeu a roupa do rei de roma
Console.WriteLine(frase.Length); // 35

string cpf = "123.456.789-00";
Console.WriteLine(cpf.PadLeft(19, '0'));
Console.WriteLine(cpf.PadRight(19, '1'));

string frase2 = frase + " DESGRAÇADO!";
Console.WriteLine(frase2);

string frase3 = $"{frase} Vou Matar esse rato!";
Console.WriteLine(frase3);
