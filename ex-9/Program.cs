float l1 = 0;
float l2 = 0;
float l3 = 0;
Console.WriteLine("---------Triangulo---------");
Console.WriteLine("---------------------------");
Console.WriteLine("Digite os tres lados do triangulo (Aperte ENTER a cada número digitado):");

l1 = float.Parse(Console.ReadLine());
l2 = float.Parse(Console.ReadLine());
l3 = float.Parse(Console.ReadLine());

if(l1 + l2 > l3 && l1 + l3 > l2 && l2  + l3 > l1)
{
    if (l1 == l2 && l2 == l3)
    {
        Console.WriteLine("É um triangulo equilátero!");
    }
    else if ((l1 == l2 && l2 != l3) || (l2 == l3 && l3 != l1) || (l1 == l3 && l1 != l2))
    {
        Console.WriteLine("É um triangulo isóceles!");
    }
    else
    {
        Console.WriteLine("É um triangulo Escaleno!");
    }
}

else
{
    Console.WriteLine("Digite numeros para um triangulo válido!");
}
