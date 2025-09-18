// Accediendo a variable de clase o estatica en C#.
using System;

namespace Laboratorio32
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculos_matematicos calculos_matematicos = new Calculos_matematicos();


            Console.WriteLine("Introduce el radio del circulo :");
            calculos_matematicos.radio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El area del circulo con radio de {0} es {1}", calculos_matematicos.radio, calculos_matematicos.CalculoArea());

        }
    }

    public class Calculos_matematicos
    {
        //Declarando variables de instancia en clase.
        public double radio { get; set; }       
        

        public double CalculoPerimetro()
        {
            //Operacion
            
            return 3.1416 * radio * radio;
            

        }
    }
}