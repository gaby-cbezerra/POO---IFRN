Console.WriteLine("Informe um valor em R$ para conversão em dólar:");
float money = float.Parse(Console.ReadLine());
Console.WriteLine("Informe a taxa de câmbio:");
float taxa = float.Parse(Console.ReadLine());

float dol = money * taxa;

Console.WriteLine($"O valor é {dol}$");