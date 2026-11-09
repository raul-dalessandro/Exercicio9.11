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
