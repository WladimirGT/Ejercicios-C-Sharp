/*
** La instrucción do ejecuta una instrucción o un bloque de instrucciones repetidamente hasta que una expresión especificada se evalúa como false. 
El cuerpo del bucle debe incluirse entre llaves, {}, a menos que conste de una sola instrucción. En ese caso, las llaves son opcionales. **

	do
    {
	//codigo
	//en algún momento poner condicion = false;
	// o si no será un buecle infinito

	}while(condicion==true);	 

	//La unica diferencia entre while y do-while,
	//es que en while la condicion debe ser verdadera para entrar
	//en el bucle. Por ejemplo si cuando llega al while y condicion es falso,
	//el programa salta todo el while. O sea no entra.
	//En cambio en el do-while, el programa entra al menos una vez, y al final
	//inspecciona la condicion

*/

/* 
using System;

namespace Ejercicios_C_Sharp
{
    class Program
    {



        static void Main(string[] args)
        {

            
            {
                int x = 1;
                do
                {
                    Console.WriteLine(x);    //**En el ejemplo siguiente, las instrucciones de bucle do-while se ejecutan 
                    x++;                     //siempre que la variable x sea menor que 5**.
                } while (x < 5);
            }
        
        
            //Output:
            //0
            //1
           //2
           //3
           //4
        

    }
}
}
*/