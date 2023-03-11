using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11DeMarzoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una palabra: ");
            string palabra = Console.ReadLine();

            if (EsPalindromo(palabra))
            {
                Console.WriteLine($"{palabra} es un palíndromo");
            }
            else
            {
                Console.WriteLine($"{palabra} no es un palíndromo");
            }

            bool EsPalindromo(string palabraa)
            {
                palabra = palabra.ToLower();

                int longitud = palabra.Length;
                for (int i = 0; i < longitud / 2; i++)
                {
                    if (palabra[i] != palabra[longitud - i - 1])
                    {
                        return false;
                    }
                }
                return true;

            }
            Console.ReadLine();
        }
    }
}
