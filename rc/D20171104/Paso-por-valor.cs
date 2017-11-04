/*Por Valor
Una variable de tipo de valor contiene directamente los datos, 
a diferencia de una variable de tipo de referencia, que contiene 
una referencia a los datos. Por lo tanto, pasar una variable de tipo 
de valor a un método significa pasar una copia de la variable al método.
Cualquier cambio en el parámetro que se produzca dentro del método no 
afectará a los datos originales almacenados en la variable.
*/
//ejemplo muestra como trabajar pasando parámetros por valor:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//ejemplo con out:
class EjemploVal
{
    static void Funcion3(int dato)
    {
        dato = 10;
    }
    static void Main()
    {
        int valor = 0; // Variable inicializada en 0
        Funcion3(valor); // Variable pasada por valor
        System.Console.WriteLine("El valor es: {0}", valor); // valor sigue siendo 0
    }
}
/*Como pueden observar, la variable valor es inicializada en cero. 
Cuando se invoca a la Funcion3, el contenido de valor se copia en 
el parámetro dato, el cual se cambia dentro del método. Sin embargo, 
en Main, el valor de la variable valor es el mismo, antes y después 
de llamar al método Funcion3, es decir, el cambio que se produce dentro 
del método sólo afecta a la variable local dato. */