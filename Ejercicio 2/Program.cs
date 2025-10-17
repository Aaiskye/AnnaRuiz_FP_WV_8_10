using System;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* El usuario puede elegir 1=piedra, 2=papel o 3=tijera, la maquina elige un numero aleatorio en el mismo rango, se comparan y se muestra el resultado */

            Console.WriteLine("Ingrese \n 1-Piedra \n 2-Papel \n 3-Tijera");
            int jugada = Convert.ToInt16 (Console.ReadLine());

            Random rnd = new Random();
            int jugadaMaquina = rnd.Next(1,4);
            Console.WriteLine(jugadaMaquina);
           

            if (jugada == 1 || jugada == 2 || jugada == 3)
            {
                switch (jugadaMaquina)
                {
                    case 1:
                        Console.WriteLine("la maquina escogio piedra");
                        if (jugada == 1)
                        {
                            Console.WriteLine("empate");
                        }
                        else if (jugada == 2)
                        {
                            Console.WriteLine("perdiste");
                        }
                        else
                        {
                            Console.WriteLine("ganaste");
                        }
                        break;
                    case 2:
                        Console.WriteLine("la maquina escogio papel");
                        Console.WriteLine(jugada);
                        if (jugada == 1)
                        {
                            Console.WriteLine("ganaste");
                        }
                        else if (jugada ==2 )
                        {
                            Console.WriteLine("empate");
                        }
                        else 
                        {
                            Console.WriteLine("perdiste");
                        }
                        break;
                    case 3:
                        Console.WriteLine("la maquina escogio tijera");
                        if (jugada == 1)
                        {
                            Console.WriteLine("perdiste");
                        }
                        else if (jugada == 2)
                        {
                            Console.WriteLine("ganaste");
                        }
                        else
                        {
                            Console.WriteLine("empate");
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Papi, coja oficio");
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("Papi, coja oficio");
            }

                    


            




             
        }
    }
}
