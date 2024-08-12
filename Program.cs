using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número:");
        int number;

        if (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
        {
            Console.WriteLine("Por favor, insira um número inteiro positivo.");
            return; 
        }

        int a = 0, b = 1;

        Console.WriteLine("Sequência de Fibonacci até " + number + ":");
        while (a <= number)
        {
            Console.Write(a + " ");

            int temp = a;
            a = b;
            b = temp + b;
        }
    }
}
