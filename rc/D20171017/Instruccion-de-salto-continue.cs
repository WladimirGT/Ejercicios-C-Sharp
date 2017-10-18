/*
La instrucción continue transfiere el control a la siguiente iteración 
de la instrucción envolvente while, do, for o foreach en la que aparece. 
*/

/*
En este ejemplo se inicializa un contador para contar del 1 al 10. 
Si se usa la instrucción continue junto con la expresión (i < 9), se omiten las 
instrucciones comprendidas entre continue y el final del cuerpo de for. 
*/

/* 
using System;

class ContinueTest
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i < 9)
            {
                continue;
            }
            Console.WriteLine(i);
        }

        // Keep the console open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
*/

/*
Output:
9
10
*/