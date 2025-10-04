using System;

int valor, pago=0;
string numTarjeta;


do
{
    Console.Write("Ingrese el valor del producto (0 para finalizar):");
    valor = Convert.ToInt32(Console.ReadLine());
    
    if (valor > 0)
    {
        Console.Write("Ingrese su metodo de pago: Efectivo (1) o Tarjeta (2) ");
        pago = Convert.ToInt32(Console.ReadLine());

        if (pago == 2)
        {
            Console.Write("Ingrese su numero de tarjeta: ");
            numTarjeta = Console.ReadLine();
            if (numTarjeta.Length == 16)
            {
                Console.WriteLine("El pago por " + valor + " ha sido cargado a su tarjeta número " + numTarjeta);
            }
            else
            {
                Console.WriteLine("Número de tarjeta inválido. Debe tener 16 dígitos.");
            }
        }
        else
        {
            Console.WriteLine("Gracias por su compra");

        }
} 

} while (valor != 0);
Console.ReadLine();