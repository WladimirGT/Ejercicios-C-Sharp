/*
** Mediante el uso de un bucle for, se puede ejecutar una instrucción o un bloque de instrucciones repetidamente hasta que una expresión
   especificada se evalúa como false. Este tipo de bucle es útil para recorrer en iteración matrices y para otras aplicaciones
   en las que se sabe de antemano cuántas veces se quiere recorrer en iteración el bucle. .**

for (expresion)
        {
            //codigo
	        //declaracion
        }

*/
//** Desarrollar un programa que muestre la tabla de multiplicar de un numero ingresado por el teclado del 1 al 15 **
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace EstructuraRepetitivaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string linea;
            Console.Write("Ingrese multiplicador: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            for(int i=1; i<=15; i++ ) {              
                    Console.Write(i+" x "+n+" = "+i*n+"\n");               
            }            
            Console.ReadKey();
        }
    }
}
