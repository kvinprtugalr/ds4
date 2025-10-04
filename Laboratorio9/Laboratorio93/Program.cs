using System;

int lad1, lad2,lad3;

Console.WriteLine("Ingresa el primer lado del triangulo");
lad1 =  Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresa el segundo lado del triangulo");
lad2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresa el tercero lado del triangulo");
lad3 = Convert.ToInt32(Console.ReadLine());

if((lad1 == lad2 || lad1 == lad3 || lad2 == lad3) && lad1 > 0 && lad2 > 0 && lad3 > 0
    && lad1 + lad2 > lad3 && lad1 + lad3 > lad2 && lad2 + lad3 > lad1)
{    
    if(lad1 == lad2 && lad1 == lad3 && lad1 >0)
    {
        Console.WriteLine("Es un triangulo Equilaero");
    }
    else if (lad1 == lad2 || lad1 == lad3 && lad1 > 0 && lad3 < lad1 + lad2)
    {
        Console.WriteLine("Es un triangulo Isosceles");
    }
    else 
    {
        Console.WriteLine("Es un triangulo Escaleno");
    }
}
else
{
    Console.WriteLine("Los datos ingresados no son validos");
}
    


Console.ReadKey();