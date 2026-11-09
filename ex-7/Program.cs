double peso = 0;
double altura = 0;
double imc = 0;
Console.WriteLine("---------IMC---------");
Console.WriteLine("---------------------");
Console.WriteLine("Digite seu peso em kg:");
peso = double.Parse(Console.ReadLine());
Console.WriteLine("Digite sua altura em cm:");
altura = double.Parse(Console.ReadLine());
altura = altura / 100;
imc = peso / (altura *= altura);
Console.WriteLine("Seu imc é: " + imc);

if (imc < 18.5)
{
    Console.WriteLine("Você está abaixo do peso.");
}
else if (imc < 25)
{
    Console.WriteLine("Você está no peso saudável.");
}
else if (imc < 30)
{
    Console.WriteLine("Você está com sobrepeso.");
}
else if (imc < 35)
{
    Console.WriteLine("Você está com obesesidade grau 1.");
}
else if (imc < 40)
{
    Console.WriteLine("Você está com obesesidade grau 2.");
}
else
{
    Console.WriteLine("Você está com obesesidade grau 3.");
}
