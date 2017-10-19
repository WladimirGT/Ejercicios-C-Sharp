/*
El método de inserción directa es el que generalmente utilizan los jugadores de cartas 
cuando ordenan éstas, de ahí que también se conozca con el nombre de método de la baraja.

La idea central de este algoritmo consiste en insertar un elemento del arreglo en la parte 
izquierda del mismo, que ya se encuentra ordenada.Este proceso se repite desde el segundo 
hasta el n-esimo elemento. 
*/

/*
Ejemplo:

Se desean ordenarse las siguientes clave del arreglo A: 15, 67, 08, 16, 44, 27, 12, 35

Primera pasada
A[2] < A[1] 67 < 15 No hay intercambio

A: 15, 67, 08, 16, 44, 27, 12, 35

Segunda pasada
A[3] < A[2] 08 < 67 Si hay intercambio
A[2] < A[1] 08 < 15 Si hay

A: 15, 08, 67, 16, 44, 27, 12, 35

Tercera pasada 
A[4] < A[3] 08 < 15 Si hay intercambio
A[3] < A[2] 08 < 15 Si hay intercambio

A= 08, 15, 67, 16, 44, 27, 12, 35

Hasta la séptima pasada el arreglo queda ordenado:   08, 12, 15, 16, 27, 35, 44, 67
*/
using System;

public class SeleccionDirecta
{
    public static void Main()
    {
        int[] numeros = { 2, 5, 1, 6, 4, 3 };
        int i, j, min, auxiliar;

        // Para todos los datos del array
        for (i = 0; i < numeros.Length - 1; i++)
        {
            // Busco el menor en cada pasada
            min = i;
            for (j = i + 1; j < numeros.Length; j++)
            {
                if (numeros[j] < numeros[min])
                    min = j;
            }

            // Si el menor estaba descolocado, lo coloco
            if (min != i)
            {
                auxiliar = numeros[i];
                numeros[i] = numeros[min];
                numeros[min] = auxiliar;
            }

            // Y muestro el progreso
            foreach (int dato in numeros)
                Console.Write(dato + " ");
            Console.WriteLine();
        }
    }
}