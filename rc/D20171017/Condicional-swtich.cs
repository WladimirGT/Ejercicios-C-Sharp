/*    
** switch es una instrucción de selección que elige una sola sección switch para ejecutarla desde una lista de candidatos 
    en función de una coincidencia de patrones con la expresión de coincidencia.  **
   
    switch (caseSwitch)
      {
          case 1:
              Console.WriteLine("Case 1"); //código que queremos ejecutar en caso de que caseSwitch sea igual a 1.
              break;                       //Esta instruccion hace que salgamos del switch.
          case 2:
              Console.WriteLine("Case 2"); //código que queremos ejecutar en caso de que caseSwitch sea igual a 2.
              break;                       //Esta instruccion hace que salgamos del switch.
          default:
              Console.WriteLine("Default case"); //codigo que querramos hacer en caso de que el "caseSwitch" sea
                                                   distintos a los anteriores casos.
              break;                                                    
      }

*/


using System;

public enum Color { Red, Green, Blue }

public class Example
{
    public static void Main()
    {
        Color c = (Color)(new Random()).Next(0, 3);
        switch (c)
        {
            case Color.Red:
                Console.WriteLine("The color is red");
                break;
            case Color.Green:
                Console.WriteLine("The color is green");
                break;
            case Color.Blue:
                Console.WriteLine("The color is blue");
                break;
            default:
                Console.WriteLine("The color is unknown.");
                break;
        }
    }
}