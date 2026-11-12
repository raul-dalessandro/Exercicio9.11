//6) Faixa etária
//Escreva um programa que leia a idade de uma pessoa
//e classifique-a de acordo com as regras:
//Criança até 12 anos,
//Adolescente de 13 a 17,
//Adulto de 18 a 59,
//Idoso de 60 para cima.

int idade = 0;

Console.WriteLine("---------Idade---------");
Console.WriteLine("-----------------------");
Console.WriteLine("Digite sua idade:");
idade = int.Parse(Console.ReadLine());
if(idade <= 12)
{
    Console.WriteLine("Você é uma criança!");
}
else if (idade >= 13 && idade <=17)
{
    Console.WriteLine("Você é um adolescente!");
}
else if(idade >= 18 && idade <= 59)
{
    Console.WriteLine("Você é um adulto!");
}
else
{
    Console.WriteLine("Você é um idoso!");
}
