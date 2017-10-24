using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MayorMenorLista
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
                    matriz[i, j] = random.Next(1, 100);
                    Console.Write("posicion matriz [" + i + "," + j + "]: " + matriz[i, j] + "\n");
                }
            }

            int mayor = matriz[0, 0];
            int menor = matriz[0, 0];
            for (int i = 0; i < tam; i++)
            {
                for (int j = 0; j < tam; j++)
                {
                    if (matriz[i, j] > mayor)
                    {
                        mayor = matriz[i, j];
                    }
                    else if (matriz[i, j] < menor)
                    {
                        menor = matriz[i, j];
                    }
                }
            }
            Console.WriteLine("el numero menor es: " + menor);
            Console.WriteLine("el numero mayor es: " + mayor);
        }
    }
}