using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio81
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Trabajador p = new Trabajador("Josan", 22, "77588260-Z", 100000);
            Console.WriteLine("Nombre=" + p.Nombre);
            Console.WriteLine("Edad=" + p.Edad);
            Console.WriteLine("NIF=" + p.Nif);
            Console.WriteLine("Sueldo=" + p.Sueldo);
            Console.ReadKey();

        }
        
    }
}
