double a = 0;
double b = 0;
double c = 0;

Console.WriteLine("---------Calculadora---------");
Console.WriteLine("--------------------------------");
Console.WriteLine("Digite dois números quaisquer (A cada número digitado aperte ENTER) :");
a = double.Parse(Console.ReadLine());
b = double.Parse(Console.ReadLine());


        c = a + b;
        Console.WriteLine($"O resultado da Adição é {c}");
    
        c = a - b;
        Console.WriteLine($"O resultado da Subtração é {c}");
    
        c = a * b;
        Console.WriteLine($"O resultado da Multiplicação é {c}");
    
        c = a / b;
        Console.WriteLine($"O resultado da Divisão é {c}");
