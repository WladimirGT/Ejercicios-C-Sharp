using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MayorMenorLista
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int contador = 0;
            string[,] matriz = new string[8, 8]  {
             {"CASAS", "ARBOL", "MAR", "IMAN", "NIDO", "OSO", "CUBO", "RATON"},
             {"CASAS", "ARBOL", "MAR", "IMAN", "NIDO", "OSO", "CUBO", "RATON"},
             {"CASAS", "ARBOL", "MAR", "IMAN", "NIDO", "OSO", "CUBO", "RATON"},
             {"CASAS", "ARBOL", "MAR", "IMAN", "NIDO", "OSO", "CUBO", "RATON"},
             {"CASAS", "ARBOL", "MAR", "IMAN", "NIDO", "OSO", "CUBO", "RATON"},
             {"CASAS", "ARBOL", "MAR", "IMAN", "NIDO", "OSO", "CUBO", "RATON"},
             {"CASAS", "ARBOL", "MAR", "IMAN", "NIDO", "OSO", "CUBO", "RATON"},
             {"CASAS", "ARBOL", "MAR", "IMAN", "NIDO", "OSO", "CUBO", "RATON"}};

             string p1 = "OSO";

            {
                //de izquierda a derecha(2)
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (p1 == matriz[i, j])
                        {                           
                            contador++;
                        }
                    }
                }
                Console.WriteLine(contador);
            }
        }
    }
}

