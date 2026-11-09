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


