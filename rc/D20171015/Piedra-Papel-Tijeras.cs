/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hola
{
    class Program
    {
        static void Main(string[] args)
        {
            int piedra = 1;
            int papel = 2;
            int tijeras = 3;
            int jugador = 0;
            int maquina = 0;
            int puntosJudador = 0;
            int puntosMaquina = 0;
            int numeroRondas = 0;
            // int opcion2;
            // int aleatorio;
            // int opcion;
            //Random azar;


            //Console.WriteLine(maquina);
            do
            {
                Console.WriteLine(" Elije una opcion : piedra = 1 , papel = 2, tijeras = 3");


                jugador = Convert.ToInt32(Console.ReadLine());

                Random random = new Random();
                maquina = random.Next(1, 4);


                if (jugador == 1)
                {
                    Console.WriteLine("jugador: piedra");
                }
                if (jugador == 2)
                {
                    Console.WriteLine("jugador: papel");
                }
                if (jugador == 3)
                {
                    Console.WriteLine("jugador: tijeras");
                }
                if (maquina == 1)
                {
                    Console.WriteLine("maquina: piedra");
                }
                if (maquina == 2)
                {
                    Console.WriteLine("maquina: papel");
                }
                if (maquina == 3)
                {
                    Console.WriteLine("maquina: tijeras");
                }
                if (jugador >= 4)
                {
                    Console.WriteLine("opcion incorrecta no gana nadie");
                }

                if (maquina == jugador)
                {
                    Console.WriteLine("empate");
                    numeroRondas--;
                }
                if (jugador == piedra && maquina == papel || jugador == tijeras && maquina == piedra || jugador == papel && maquina == tijeras)
                {
                    Console.WriteLine("gana maquina");
                    puntosMaquina++;


                }


                if (jugador == papel && maquina == piedra || jugador == piedra && maquina == tijeras || jugador == tijeras && maquina == papel)
                {
                    Console.WriteLine("gana jugador");
                    puntosJudador++;
                }
                Console.WriteLine("Puntos Jugador " + puntosJudador);
                Console.WriteLine("Puntos Maquina " + puntosMaquina);

                numeroRondas++;
                Console.WriteLine("Numero de rondas " + numeroRondas);
            } while (numeroRondas < 3);
            if (puntosJudador > puntosMaquina)
            {
                Console.WriteLine("gana la partida jugador");
            }else{
                Console.WriteLine("gana la partida la maquina ");
            }
            string espera = Console.ReadLine();
        }
    }
}

*/