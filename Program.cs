using System;

class Program
{
    static void Main()
    {
        List<string> names = new List<string>();

        Console.WriteLine("Digite os nomes (digite 'fim' para terminar):");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "fim")
            {
                break;
            }
            names.Add(input);
        }

        names.Sort();

        Console.WriteLine("\nLista de nomes ordenada em ordem alfabética:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}
