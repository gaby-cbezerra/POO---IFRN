Console.WriteLine("Informe sua idade:");
int age = int.Parse(Console.ReadLine());
if ( age >= 18){
    Console.WriteLine("Você é maior de idade, está apto(a) a dirigir e votar");
}
else{
    Console.WriteLine("Você não é maior de idade, logo não está apto(a) a dirigir e votar");
}