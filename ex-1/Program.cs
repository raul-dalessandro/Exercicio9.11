int a = 0;
int b = 0;

Console.WriteLine("---------Par ou ímpar---------");
Console.WriteLine("------------------------------");
Console.WriteLine("Digite um número qualquer inteiro:");
a = int.Parse(Console.ReadLine());


b = a % 2;

if (b == 0)                                                          
{
    Console.WriteLine("O número é par!");
}
else
{
    Console.WriteLine("O número é ímpar!");
}