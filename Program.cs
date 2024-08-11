Console.WriteLine("Digite um número:");
int number = int.Parse(Console.ReadLine());

if (number > 0){
    Console.WriteLine($"{number} é positivo");
}
else if( number < 0){
    Console.WriteLine($"{number} é negativo");
}
else{
    Console.WriteLine($"{number} é zero");
}