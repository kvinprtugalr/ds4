using System;

class Program
{
    static void Main()
    {
        Aleatorio ale = new Aleatorio();

        int num = ale.GenerarNumero(1, 100);
        Console.WriteLine("Número aleatorio: " + num);

        int[] arr = ale.GenerarArreglo(5, 1, 50);
        Console.WriteLine("Arreglo aleatorio: " + string.Join(", ", arr));

        Console.ReadKey();
    }
}