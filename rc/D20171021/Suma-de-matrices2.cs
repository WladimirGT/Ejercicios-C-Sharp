/*
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

            int[,] matrizA;
            int[,] matrizB;
            int[,] matrizR;

            matrizA = new int[10, 10];
            matrizB = new int[10, 10];
            matrizR = new int[10, 10];


            Console.WriteLine("Numeros matrizA");

            for (int columna = 0; columna < 3; columna++)
            {
                for (int fila = 0; fila < 3; fila++)
                {
                    Random random = new Random();
                    matrizA[columna, fila] = random.Next(1, 10);
                    Console.Write("posicion matrizA [" + columna + "," + fila + "]: " + matrizA[columna, fila] + "\n");

                    matrizB[columna, fila] = random.Next(1, 10);
                    Console.Write("posicion matrizB [" + columna + "," + fila + "]: " + matrizB[columna, fila] + "\n");

                    matrizR[columna, fila] = matrizA[columna, fila] + matrizB[columna, fila];
                    Console.Write("posicion matrizC [" + columna + "," + fila + "]: " + matrizR[columna, fila] + "\n");


                }
            }





        }
    }
}
*/