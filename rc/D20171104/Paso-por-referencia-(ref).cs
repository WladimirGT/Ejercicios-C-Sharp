/*Por Referencia
Una variable de tipo referencia no contiene directamente los datos, 
contiene una referencia a ellos. El paso de parámetros por referencia permite 
a los miembros de funciones, métodos, propiedades, indizadores, operadores y constructores, 
cambiar el valor de los parámetros y hacer que ese cambio persista.

Para pasar un parámetro por referencia, se debe usar una de las palabras clave Ref u Out. Por ejemplo:

static void Funcion1(Ref int dato)
{
    // codigo...
}
.
static void Funcion2(Out int dato)
{
    // codigo...
}
*/

/*Para pasar un argumento a un parámetro Ref, primero debe inicializarse. 
Esto es diferente de Out, cuyo argumento no tiene que inicializarse explícitamente antes de pasarlo.

Aunque Ref y Out se tratan de manera diferente en tiempo de ejecución, 
se tratan de la misma manera en tiempo de compilación. Por consiguiente
no se pueden sobrecargar los métodos si un método toma un argumento Ref y el otro toma un argumento Out.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//ejemplo con ref:
class EjemploRef
{
    static void Funcion1(ref int dato)
    {
        dato = 3;
    }
    static void Main()
    {
        int valor = 0; // Es necesario inicializar la variable
        Funcion1(ref valor); // Variable pasada por referencia
        System.Console.WriteLine("El valor es: {0}", valor); // valor a cambiado a 3
    }
}


