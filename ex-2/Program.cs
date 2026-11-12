//2) Maior, menor ou igual
//Escreva um programa que receba dois números
//decimais e informe qual deles é maior, qual é
//menor ou se são iguais.

float a = 0;
float b = 0;
Console.WriteLine("---------Maior ou Menor---------");
Console.WriteLine("--------------------------------");
Console.WriteLine("Digite dois números quaisquer decimais(A cada numero digitado aperte ENTER) :");
a = float.Parse(Console.ReadLine());
b = float.Parse(Console.ReadLine());

if (a >= b)
{
    Console.WriteLine(a + " é maior ");
}
else
{
    Console.WriteLine(b + " é maior ");
}


