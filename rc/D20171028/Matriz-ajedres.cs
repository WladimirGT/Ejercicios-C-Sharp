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
            int i, j, contador = 0;
            char[,] tablero = new char[8, 8];
            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 8; j++)
                {
                    tablero[i, j] = '0';
                }
            }
            Console.WriteLine("posicion de columna");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("posicion de fila");
            j = int.Parse(Console.ReadLine());
            tablero[i, j] = 'c';


            do
            {
                Console.WriteLine("ingrese opcion");
                int juego = int.Parse(Console.ReadLine());
                switch (juego)
                {
                    case 1:
                        Console.WriteLine("Case 1: arriba derecha");
                        if (i > 1 && j < 7)
                        {
                            tablero[i - 2, j + 1] = 'c';
                            tablero[i, j] = 'x';
                            i = i - 2;
                            j = j + 1;

                            contador++;
                        }

                        else
                        {
                            Console.WriteLine("esta fuera del rango");
                        }

                        break;
                    case 2:
                        Console.WriteLine("Case 2: arriba izquierda");
                        if (i > 1 && j > 0)
                        {
                            tablero[i - 2, j - 1] = 'c';
                            tablero[i, j] = 'x';
                            i = i - 2;
                            j = j - 1;

                            contador++;
                        }
                        else
                        {
                            Console.WriteLine("esta fuera del rango");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Case 2: abajo derecha");
                        if (i < 6 && j < 7)
                        {
                            tablero[i + 2, j + 1] = 'c';
                            tablero[i, j] = 'x';
                            i = i + 2;
                            j = j + 1;

                            contador++;
                        }
                        else
                        {
                            Console.WriteLine("esta fuera del rango");
                        }

                        break;
                    case 4:
                        Console.WriteLine("Case 2: abajo izquierda");
                        if (i < 6 && j > 0)
                        {
                            tablero[i + 2, j - 1] = 'c';
                            tablero[i, j] = 'x';
                            i = i + 2;
                            j = j - 1;

                            contador++;
                        }
                        else
                        {
                            Console.WriteLine("esta fuera del rango");
                        }
                        break;
                }
            } while (contador < 3);
            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 8; j++)
                {
                    Console.Write("posicion matriz [" + i + "," + j + "]: " + tablero[i, j] + "\n");
                }
            }
        }
    }
}

