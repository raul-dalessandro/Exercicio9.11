float n1 = 0;
float n2 = 0;
float n3 = 0;
float n4 = 0;
float nm = 0;
Console.WriteLine("---------Média das notas---------");
Console.WriteLine("---------------------------------");
Console.WriteLine("Digite as quatros notas em sequência(Aperte ENTER a cada nota digitada):");

n1 = float.Parse(Console.ReadLine());
n2 = float.Parse(Console.ReadLine());
n3 = float.Parse(Console.ReadLine());
n4 = float.Parse(Console.ReadLine());

nm = ((n1 + n2 + n3 + n4) / 4);

if (nm >= 7)
{
    Console.WriteLine($" Aprovoado!A media foi: {nm:f1}");
}
else if (nm > 5 && nm < 7)
{
    Console.WriteLine($"Terá que fazer recupeção!A media foi: {nm:f1}");
}
else
{
    Console.WriteLine($"Reprovado!A media foi: {nm:f1}");
}

