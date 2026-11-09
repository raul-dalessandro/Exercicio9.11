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
