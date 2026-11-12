//3) Média e status
//Escreva um programa que receba 4 notas de um aluno,
//calcule a média aritmética e informe o status
//baseado nas seguintes condições:
//Aprovado se a média for maior ou igual a 7,
//recuperação se a média for entre 5,1 e 6,9
//e reprovado se for menor ou igual a 5.

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

