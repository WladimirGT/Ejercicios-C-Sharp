/*
El ordenamiento por selección (Selection Sort en inglés ) es un algoritmo 
de ordenamiento que requiere operaciones para ordenar una lista 
de n elementos(Osea En Arreglos).

Su funcionamiento es el siguiente:

Buscar el mínimo elemento de la lísta
Intercambiarlo con el primero
Buscar el mínimo en el resto de la lista
Intercambiarlo con el segundo
 */
using System;
 
public class SeleccionDirecta
{
    public static void Main()
    {
        int[] numeros={34,56,76,87,90,1};
        int i,j,min,auxiliar;
 
        // Para todos los datos del array
        for (i=0; i<numeros.Length-1; i++)
        {
            // Busco el menor en cada pasada
            min=i;                
            for (j=i+1; j<numeros.Length; j++)
            {
                if (numeros[j] < numeros[min])             
                    min=j;
            }
 
            // Si el menor estaba descolocado, lo coloco
            if (min != i)
            {
                auxiliar=numeros[i];
                numeros[i]=numeros[min];
                numeros[min]=auxiliar;
            }
 
            // Y muestro el progreso
            foreach (int dato in numeros)
                Console.Write(dato+" ");
            Console.WriteLine();
        }
    }
}