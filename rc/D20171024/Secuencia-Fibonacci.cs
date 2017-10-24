
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hola
{
    class Program
    {

        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 1;
            int tam;

            Console.Write("ingrese hasta donde quiere la secuencia fibonacci: ");
            tam = int.Parse(Console.ReadLine());

            for (int i = 0; i < tam; i++)
            {
                a = b;
                b = c;
                c = a + b;
                Console.WriteLine(a);
            }
        }
    }
}