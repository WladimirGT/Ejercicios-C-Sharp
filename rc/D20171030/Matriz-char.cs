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
            char[,] matriz = new char[8, 8]  {
            {'C', 'A', 'M', 'I', 'N', 'O', 'C', 'C'},
            {'A', 'O', 'N', 'O', 'N', 'A', 'A', 'A'},
            {'O', 'O', 'O', 'N', 'I', 'O', 'M', 'M'},
            {'N', 'N', 'N', 'I', 'M', 'N', 'I', 'I'},
            {'I', 'I', 'I', 'M', 'A', 'I', 'N', 'N'},
            {'M', 'M', 'C', 'A', 'M', 'I', 'O', 'O'},
            {'A', 'O', 'N', 'I', 'M', 'A', 'C', 'C'},
            {'C', 'A', 'M', 'I', 'N', 'O', 'A', 'C'}};

            char p1 = 'C';
            char p2 = 'A';
            char p3 = 'M';
            char p4 = 'I';
            char p5 = 'N';
            char p6 = 'O';

            {
                //de izquierda a derecha(2)
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (p1 == matriz[i, j] && p2 == matriz[i, j + 1] && p3 == matriz[i, j + 2] && p4 == matriz[i, j + 3] && p5 == matriz[i, j + 4] && p6 == matriz[i, j + 5])
                        {                           
                            contador++;
                        }

                    }
                }
                //de derecha a izquierda (1)
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 7; j > 5; j--)
                    {
                        
                        if (p1 == matriz[i, j] && p2 == matriz[i, j - 1] && p3 == matriz[i, j - 2] && p4 == matriz[i, j - 3] && p5 == matriz[i, j - 4] && p6 == matriz[i, j - 5])
                        {
                            contador++;
                        }
                    }
                }
                //de arriba abajo(2)
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 1; j++)
                    {
                       
                        if (p1 == matriz[i, j] && p2 == matriz[i + 1, j] && p3 == matriz[i + 2, j] && p4 == matriz[i + 3, j] && p5 == matriz[i + 4, j] && p6 == matriz[i + 5, j])
                        {
                            contador++;
                        }
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 1; j < 2; j++)
                    {
                        if (p1 == matriz[i, j] && p2 == matriz[i + 1, j] && p3 == matriz[i + 2, j] && p4 == matriz[i + 3, j] && p5 == matriz[i + 4, j] && p6 == matriz[i + 5, j])
                        {
                            contador++;
                        }
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 2; j < 3; j++)
                    {
                        if (p1 == matriz[i, j] && p2 == matriz[i + 1, j] && p3 == matriz[i + 2, j] && p4 == matriz[i + 3, j] && p5 == matriz[i + 4, j] && p6 == matriz[i + 5, j])
                        {
                            contador++;
                        }
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 3; j < 4; j++)
                    {
                        if (p1 == matriz[i, j] && p2 == matriz[i + 1, j] && p3 == matriz[i + 2, j] && p4 == matriz[i + 3, j] && p5 == matriz[i + 4, j] && p6 == matriz[i + 5, j])
                        {
                            contador++;
                        }
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 4; j < 5; j++)
                    {
                        if (p1 == matriz[i, j] && p2 == matriz[i + 1, j] && p3 == matriz[i + 2, j] && p4 == matriz[i + 3, j] && p5 == matriz[i + 4, j] && p6 == matriz[i + 5, j])
                        {
                            contador++;
                        }
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 5; j < 6; j++)
                    {
                        if (p1 == matriz[i, j] && p2 == matriz[i + 1, j] && p3 == matriz[i + 2, j] && p4 == matriz[i + 3, j] && p5 == matriz[i + 4, j] && p6 == matriz[i + 5, j])
                        {
                            contador++;
                        }
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 6; j < 7; j++)
                    {
                        if (p1 == matriz[i, j] && p2 == matriz[i + 1, j] && p3 == matriz[i + 2, j] && p4 == matriz[i + 3, j] && p5 == matriz[i + 4, j] && p6 == matriz[i + 5, j])
                        {
                            contador++;
                        }
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 7; j < 8; j++)
                    {
                        if (p1 == matriz[i, j] && p2 == matriz[i + 1, j] && p3 == matriz[i + 2, j] && p4 == matriz[i + 3, j] && p5 == matriz[i + 4, j] && p6 == matriz[i + 5, j])
                        {
                            contador++;
                        }
                    }
                }
                //de abajo arriba(1)
                for (int i = 7; i > 3; i--)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        if (p1 == matriz[i, j] && p2 == matriz[i - 1, j] && p3 == matriz[i - 2, j] && p4 == matriz[i - 3, j] && p5 == matriz[i - 4, j] && p6 == matriz[i - 5, j])
                        {
                            contador++;
                        }
                    }
                }    
                for (int i = 7; i > 3; i--)
                {
                    for (int j = 1; j < 2; j++)
                    {
                        if (p1 == matriz[i, j] && p2 == matriz[i - 1, j] && p3 == matriz[i - 2, j] && p4 == matriz[i - 3, j] && p5 == matriz[i - 4, j] && p6 == matriz[i - 5, j])
                        {
                            contador++;
                        }
                    }
                }
                for (int i = 7; i > 3; i--)
                {
                    for (int j = 2; j < 3; j++)
                    {
                        if (p1 == matriz[i, j] && p2 == matriz[i - 1, j] && p3 == matriz[i - 2, j] && p4 == matriz[i - 3, j] && p5 == matriz[i - 4, j] && p6 == matriz[i - 5, j])
                        {
                            contador++;
                        }
                    }
                }
                for (int i = 7; i > 3; i--)
                {
                    for (int j = 3; j < 4; j++)
                    {
                        if (p1 == matriz[i, j] && p2 == matriz[i - 1, j] && p3 == matriz[i - 2, j] && p4 == matriz[i - 3, j] && p5 == matriz[i - 4, j] && p6 == matriz[i - 5, j])
                        {
                            contador++;
                        }
                    }
                }
                for (int i = 7; i > 3; i--)
                {
                    for (int j = 4; j < 5; j++)
                    {
                        if (p1 == matriz[i, j] && p2 == matriz[i - 1, j] && p3 == matriz[i - 2, j] && p4 == matriz[i - 3, j] && p5 == matriz[i - 4, j] && p6 == matriz[i - 5, j])
                        {
                            contador++;
                        }
                    }
                }
                for (int i = 7; i > 3; i--)
                {
                    for (int j = 5; j < 6; j++)
                    {
                        if (p1 == matriz[i, j] && p2 == matriz[i - 1, j] && p3 == matriz[i - 2, j] && p4 == matriz[i - 3, j] && p5 == matriz[i - 4, j] && p6 == matriz[i - 5, j])
                        {
                            contador++;
                        }
                    }
                }
                for (int i = 7; i > 3; i--)
                {
                    for (int j = 6; j < 7; j++)
                    {
                        if (p1 == matriz[i, j] && p2 == matriz[i - 1, j] && p3 == matriz[i - 2, j] && p4 == matriz[i - 3, j] && p5 == matriz[i - 4, j] && p6 == matriz[i - 5, j])
                        {
                            contador++;
                        }
                    }
                }
                for (int i = 7; i > 3; i--)
                {
                    for (int j = 7; j < 8; j++)
                    {
                        if (p1 == matriz[i, j] && p2 == matriz[i - 1, j] && p3 == matriz[i - 2, j] && p4 == matriz[i - 3, j] && p5 == matriz[i - 4, j] && p6 == matriz[i - 5, j])
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

