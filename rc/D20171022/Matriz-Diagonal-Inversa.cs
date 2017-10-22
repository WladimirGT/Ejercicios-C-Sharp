
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

            int[,] matriz;

            Console.Write("ingrese el tamaño de la matriz:");
            int tam = int.Parse(Console.ReadLine());
            matriz = new int[tam, tam];

            for (int i = 0; i < tam; i++)
            {
                for (int j = 0; j < tam; j++)
                {
                    Random random = new Random();
                    matriz[i, j] = random.Next(10, 31);
                    Console.Write("posicion matriz [" + i + "," + j + "]: " + matriz[i, j] + "\n");

                }
            }
            int K = tam - 1;
            for (int i = 0; i < tam; i++, K--)
            {
                for (int j = 0; j < tam; j++)
                {
                    if (K == j && matriz[i, j] > 10 && matriz[i, j] < 30)
                    {
                        Console.Write("posicion matriz [" + i + "," + j + "]: " + matriz[i, j] + "\n");
                    }
                    



                }
                
            }

        }
    }
}
