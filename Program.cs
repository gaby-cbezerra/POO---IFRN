using System;

class Program
{
    
    static int CalcularFatorial(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("O número deve ser não-negativo.");
        }

        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            return n * CalcularFatorial(n - 1);
        }
    }

    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Fatorial de 4: " + CalcularFatorial(4));  
            Console.WriteLine("Fatorial de 0: " + CalcularFatorial(0));  
            Console.WriteLine("Fatorial de 5: " + CalcularFatorial(5));  
            Console.WriteLine("Fatorial de -3: " + CalcularFatorial(-3)); 
        }
         catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
}
}

    