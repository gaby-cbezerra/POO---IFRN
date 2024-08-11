int soma = 0;
int number;
do {
    Console.WriteLine("Digite um número:");
    number = int.Parse(Console.ReadLine());
    
    if ( number != 0){
    soma += number;
    }

}  while( number != 0);

Console.WriteLine($"A soma de todos os números digitados é: {soma}");