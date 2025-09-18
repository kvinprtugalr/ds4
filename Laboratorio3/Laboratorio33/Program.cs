// Accediendo a variable de clase o estatica en C#.
using System;

namespace Laboratorio33
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculos_matematicos calculos_matematicos = new Calculos_matematicos();


            Console.WriteLine("Introduce la base del rectangulo :");
            calculos_matematicos.baser = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce la altura del rectangulo:");
            calculos_matematicos.alturar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El perimetro del rectangulo con base de {0} y altura de {1} es {2}", calculos_matematicos.baser, calculos_matematicos.alturar, calculos_matematicos.CalculoPerimetro());

        }
    }

    public class Calculos_matematicos
    {
        //Declarando variables de instancia en clase.
        public double baser { get; set; }
        public double alturar { get; set; }


        public double CalculoPerimetro()
        {
            //Operacion

            return 2 * (baser + alturar);


        }
    }
}
