// Accediendo a variable de clase o estatica en C#.
using System;

namespace Laboratorio31
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculos_matematicos calculos_matematicos = new Calculos_matematicos();
            
                        
            Console.WriteLine("Introduce el primer numero :");
            calculos_matematicos.primernum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el segundo numero: ");
            calculos_matematicos.segundonum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El resultado de la operacion (a+b)*(a-b) de {0} y {1} es {2}", calculos_matematicos.primernum, calculos_matematicos.segundonum, calculos_matematicos.Calcular());

        }
    }

        public class Calculos_matematicos
    {
        //Declarando variables de instancia en clase.
        public int primernum { get; set; }
        public int segundonum { get; set; }
              
        public int Calcular()
        {
            //Operacion
            return (primernum + segundonum) * (primernum - segundonum);
           
        }
    }   
}

