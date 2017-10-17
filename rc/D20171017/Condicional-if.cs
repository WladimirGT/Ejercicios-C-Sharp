/*
La instrucción if se compone de:
if(<condición>)
{
    instrucciones...
}
else
{
     instrucciones...
}
*/


using System;

namespace Ejercicios_C_Sharp
{
    class Program
    {



        static void Main(string[] args)
        {
            int num = 11;


            if (num == 10)

            {

                Console.WriteLine("El número es igual a 10");

            }

            else if (num == 5)

            {

                Console.WriteLine("El número es igual que 5");

            }

            else if (num > 15)

            {

                Console.WriteLine("El número es mayor que 15");

            }

            else

            {

                Console.WriteLine("El número no es 10 ni igual que 5");

            }



        }
    }
}
