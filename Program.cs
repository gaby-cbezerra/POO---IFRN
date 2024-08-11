        Console.Write("Digite o primeiro número: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Digite o terceiro número: ");
        int num3 = int.Parse(Console.ReadLine());

        int maior;
        if (num1 >= num2 && num1 >= num3)
        {
            maior = num1;
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            maior = num2;
        }
        else
        {
            maior = num3;
        }

        int menor;
        if (num1 <= num2 && num1 <= num3)
        {
            menor = num1;
        }
        else if (num2 <= num1 && num2 <= num3)
        {
            menor = num2;
        }
        else
        {
            menor = num3;
        }

        Console.WriteLine($"O maior número é: {maior}");
        Console.WriteLine($"O menor número é: {menor}");
    
