using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio40
{
    class Program
    {
        // 40. Solicite el ingreso de una frase al usuario y presente cada palabra en una linea por separado
        static void Main(string[] args)
        {
            Console.WriteLine( "Ingrese una frase");
            string frase = Console.ReadLine();
            string[] Palabras = frase.Split();
            Console.WriteLine("-------------------------------------------");
            foreach (var palabra in Palabras )
            {
                Console.WriteLine(palabra);
            }
            Console.ReadLine();
        }
    }
}
