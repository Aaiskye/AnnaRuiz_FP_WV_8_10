using System.Security.Cryptography;

namespace Ejercicios1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verificar si un numero es primo


            /*Console.WriteLine("Escriba un número");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero <= 0)
            {
                Console.WriteLine("no es primo");
            }
            else if (numero % 2 == 0 && numero !=2)
            {
                Console.WriteLine("no es primo"); 
            }
            else if (numero % 3 == 0 && numero != 3)
            {
                Console.WriteLine(" no es primo");
            }
            else if (numero % 5 == 0 && numero != 5)
            {
                Console.WriteLine(" no es primo");
            }
            else if (numero % 7 == 0 && numero != 7)
            {
                Console.WriteLine(" no es primo");
            }
            else {
                Console.WriteLine("es primo");
            }
            }*/

            /* Simulador de cajero automático, generar un saldo aleatorio preguntar si desea retirar o consultar, si retira verificar que tenga saldo suficiente, si no mostrar error, si consulta mostrar saldo actual. */

            Random rnd = new Random();
            int saldo = rnd.Next();

            Console.WriteLine("¿desea retirar o consultar? \n 0-retirar \n 1-consultar");
            bool accion = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));

            if (accion == true)
            {
                Console.WriteLine($"Su saldo es {saldo}");
            }
            else
            {
                Console.WriteLine($"¿Cuanto desea retirar? Saldo= {saldo}");
                int retiro = Convert.ToInt32(Console.ReadLine());
                if (saldo >= retiro)
                {
                    Console.WriteLine("Retiro en proceso");
                }
                else
                {
                    Console.WriteLine("No tiene saldo suficiente");
                }
            }
        }



     




        }
}
