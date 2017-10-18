/*
La instrucción return termina la ejecución del método en el que aparece y devuelve el control al método de llamada. 
También puede devolver un valor opcional.
Si el método es del tipo void, la instrucción return se puede omitir.
** Devuelve un valor.**
*/

/*
Ejemplo

En el siguiente ejemplo, el método A() devuelve la variable Area como un valor de tipo double.
*/

/*
using System;
class ReturnTest
{
    static double CalculateArea(int r)
    {
        double area = r * r * Math.PI;
        return area;
    }

    static void Main()
    {
        int radius = 5;
        double result = CalculateArea(radius);
        Console.WriteLine("The area is {0:0.00}", result);

        // Keep the console open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
// Output: The area is 78.54
*/

/*int suma(){

int a,b,c;
a=1;
b=2;
c=a+b;

return c;
}

entonces en tu main, al llamar la funcion suma(), te devolvera 3, que es el valor c, 
si pones "return b", te devuelve b, y asi sucesivamente. 
 */