/*
El algoritmo de ordenamiento de burbuja bidireccional también llamado 
ordenamiento cocktail intenta mejorar el rendimiento del ordenamiento 
burbuja realizando el recorrido de comparación en ambas direcciones, 
de esta manera  se puede realizar más de un intercambio por iteración.
 */

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
    {
        static void Main(string[] args)
        {
            int n = numeros.Length;
            int izq = 1;
            int k = n;
            int aux;
            int der = n;
            do
            {
                for (int i = der; i >= izq; i--)
                {
                    if (numeros[i - 1] > numeros[i])
                    {
                        aux = numeros[i - 1];
                        numeros[i - 1] = numeros[i];
                        numeros[i] = aux;
                        k = i;
                    }
                }
                izq = k + 1;
                for (int i = izq; i <= der; i++)
                {
                    if (numeros[i - 1] > numeros[i])
                    {
                        aux = numeros[i - 1];
                        numeros[i - 1] = numeros[i];
                        numeros[i] = aux;
                        k = 1;
                    }
                }
                der = k - 1;
            }
            while (der >= izq);
            for (int i = 0; i < longitud; i++)



                Console.WriteLine(" " + numeros[i]);
        }



    }
*/

/*
Procedimiento Ordenacion_Sacudida(v:vector, tam:entero)
 Variables
   i, j, izq, der, último: tipoposicion;
   aux: tipoelemento;
 Inicio
   //Límites superior e inferior de elementos ordenados
   izq<- 2
   der <- tam
   último <- tam
 
   Repetir
     //Burbuja hacia la izquierda}
     //Los valores menores van a la izquierda
     //der va disminuyendo en 1 hasta llegar a izq
        Para i <- der hasta izq hacer
         Si v(i-1) > v(i) entonces
             aux<- v(i)
             v(i) <- v(i-1)
             v(i-1) <- aux
             último<- i
         Fin_si
     Fin_para
     
     izq <- último+1
 
     //Burbuja hacia la derecha
     //Los valores mayores van a la derecha
     Para j <- izq hasta der hacer
         Si v(j-1) > v(j) entonces
             aux<- v(j)
             v(j) <- v(j-1)
             v(j-1) <- aux
             último<- j
         Fin_si
     Fin_para
 
     der <- último-1
 
   Hasta (izq > der)
 Fin

 */