/*
Este método consiste en ir comparando cada par de elementos del array e ir moviendo
 el mayor elemento hasta la última posición, comenzando desde la posición cero. 
 Una vez acomodado el mayor elemento, prosigue a encontrar y acomodar el segundo más 
 grande comparando de nuevo los elementos desde el inicio de la lista, y así sigue hasta 
 ordenar todos los elementos del arreglo.
 */

 /*
using System;
class Program
{
    static void Main(string[] args)
    {
        // Arreglo de ejemplo con 10 valores
        int[] Valores = new int[10] { 10, 5, 35, 11, 3, 9, 15, 2, 12, 1 };
        int Auxiliar = 0;

        // Se hace un recorrido desde el segundo elemento hasta el ultimo
        for (int i = 1; i < Valores.Length; i++)
        {
            for (int j = 0; j < Valores.Length - i; j++)
            {


                if (Valores[j] > Valores[j + 1])
                {
                    Auxiliar = Valores[j];
                    Valores[j] = Valores[j + 1];
                    Valores[j + 1] = Auxiliar;
                }
            }
        }

        for (int i = 0; i < Valores.Length; i++)
        {
            Console.WriteLine(Valores[i]);
        }
        Console.ReadLine();

    }

}
*/