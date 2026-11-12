//8) Aumento salarial
//Escreva um programa que, com base no salário
//informado, calcule o aumento salarial de acordo
//com as regras a seguir:
//Até 2000, aumento de 15%;
//de 2000,01 até 4000, aumento de 10%;
//acima de 4000, aumento de 5%.

double salario = 0;
Console.WriteLine("---------Salário---------");
Console.WriteLine("-------------------------");
Console.WriteLine("Digite seu salário:");
salario = double.Parse(Console.ReadLine());
if (salario <= 2000)
{
    Console.WriteLine("Seu salário aumentará para:" + salario * 1.15);
}
else if (salario <= 4000)
{
    Console.WriteLine("Seu salário aumentará para:" + salario * 1.10);
}
else
{
    Console.WriteLine("Seu salário aumentará para:" + salario * 1.05);
}
