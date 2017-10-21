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

            for (int filaA = 0; filaA < 3; filaA++)
            {
                for (int columnaA = 0; columnaA < 3; columnaA++)
                {
                    Random random = new Random();
                    int randomNumber = random.Next(1, 10);
                    matrizA[filaA, columnaA] = randomNumber;
                    Console.Write("posicion [" + filaA + "," + columnaA + "]: " + randomNumber);
                    Console.Write("\n");//salto de linea
                }
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("Numeros matrizB");

            for (int filaB = 0; filaB < 3; filaB++)
            {
                for (int columnaB = 0; columnaB < 3; columnaB++)
                {
                    Random random = new Random();
                    int randomNumber = random.Next(1, 10);
                    matrizB[filaB, columnaB] = randomNumber;
                    Console.Write("posicion [" + filaB + "," + columnaB + "]: " + randomNumber);
                    Console.Write("\n");//salto de linea
                }
            }

            //suma de matrizA y matrizB
            Console.WriteLine("--------------------------");
            Console.WriteLine("suma: matrizA + matrizB");

            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    matrizR[fila, columna] = matrizA[fila, columna] + matrizB[fila, columna];
                    Console.Write("posicion [" + fila + "," + columna + "]: " + matrizR[fila, columna]);
                    Console.Write("\n");//salto de linea
                }
            }
        }
    }
}