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
            int i, j;
            int[,] matriz = new int[4, 4] { { 1, 2, 3, 4 }, { 12, 13, 14, 5 }, { 11, 16, 15, 6 }, { 10, 9, 8, 7 } };
            //int tam = matriz[4, 4];
            for (i = 0; i < 1; i++)
            {
                for (j = 0; j < 4; j++)
                {

                    Console.Write("posicion matriz [" + i + "," + j + "]: " + matriz[i, j] + "\n");
                }


            }
            for (i = 1; i < 3; i++)
            {
                for (j = 3; j < 4; j++)
                {

                    Console.Write("posicion matriz [" + i + "," + j + "]: " + matriz[i, j] + "\n");
                }
            }

            for (i = 3; i >= 3; i--)
            {
                for ( j = 3; j >= 0; j--)
                {
                    Console.Write("posicion matriz [" + i + "," + j + "]: " + matriz[i, j] + "\n");
                }
            }
            for (i = 2; i >= 1; i--)
            {
                for ( j = 0; j >= 0; j--)
                {

                    Console.Write("posicion matriz [" + i + "," + j + "]: " + matriz[i, j] + "\n");
                }
            }
        }
    }

}