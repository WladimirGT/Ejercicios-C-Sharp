 /*El foreach nos servirá para recorrer un listados de tipo de datos (int, double, string, etc.) 
   o un listados de listado de objetos (entiéndase como objeto una clase creada previamente con 
   sus respectivas variables y propiedades). 
   Al recorrer mediante el foreach, no necesitamos validar cuantos elementos componen nuestro arreglo, 
   la instrucción funcionará hasta que lea el último elemento del arreglo o hasta que nosotros mediante 
   una validación interrumpamos el flujo del ciclo. 

   */
/* 
 foreach (‘Tipo’  Nombre in Listado)
{
                // Instrucciones.
}
*/

 /*‘Tipo’:
Se refiere al tipo de dato que va ligado al listado de objetos que queremos recorrer. Ejemplo:
·         Si el listado es de string, el valor en ‘Tipo’ será string.
·         Si el listado es de int, el valor en ‘Tipo’ será int.
·         Si el listado es de una clase Persona, el valor en ‘Tipo’ será ‘Persona’.
‘Nombre’:
Se refiere a cómo vamos a identificar el valor que obtendremos del listado.
‘Listado’:
Se refiere al listado de tipo de datos u de objetos que vamos a recorrer.
*/

/*
using System;

class Program
{
    static void Main()
    {
        string[] pets = { "dog", "cat", "bird" };

        // ... Loop with the foreach keyword.
        foreach (string value in pets)
        {
            Console.WriteLine(value);
        }
    }
}
*/

 /*¿Cómo romper el clico dentro del foreach?
Para romper el ciclo dentro de la instrucción podemos usar la instrucción.
* break;  // Solo romperá el ciclo y seguirá con las demás instrucciones fuera del foreach que lo genero.
* throw; // Para lanzar una excepción que se irá hasta el catch que hayas programado. Las demás instrucciones.
            que hayas programado en el try ya no se ejecutarán, solo las que estén en catch.
* return; // Esta instrucción romperá todo el ciclo impidiendo que continúen las demás instrucciones y devolviendo
             el control a la función principal o finalizando el programa. Si tienes más instrucciones fuera del código 
             foreach estas ya no se ejecutarán.
*/             