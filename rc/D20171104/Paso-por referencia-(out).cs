/*Por Referencia
Una variable de tipo referencia no contiene directamente los datos, 
contiene una referencia a ellos. El paso de parámetros por referencia permite 
a los miembros de funciones, métodos, propiedades, indizadores, operadores y constructores, 
cambiar el valor de los parámetros y hacer que ese cambio persista.

Para pasar un parámetro por referencia, se debe usar una de las palabras clave out. Por ejemplo:

static void Funcion2(Out int dato)
{
    // codigo...
}
*/

/*Out no requiere que se inicialice la variable antes de pasarla. 
Al utilizar un parámetro Out, la definición de método y el método 
de llamada deben utilizar explícitamente la palabra clave out.

Aunque Ref y Out se tratan de manera diferente en tiempo de ejecución, 
se tratan de la misma manera en tiempo de compilación. Por consiguiente
no se pueden sobrecargar los métodos si un método toma un argumento Ref y el otro toma un argumento Out.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//ejemplo con out:
class EjemploOut
{
    static void Funcion2(out int dato)
    {
        dato = 3;
    }
    static void Main()
    {
        int valor; // No es necesario inicializar la variable
        Funcion2(out valor); // Variable pasada por referencia
        System.Console.WriteLine("El valor es: {0}", valor); // valor a cambiado a 3
    }
}