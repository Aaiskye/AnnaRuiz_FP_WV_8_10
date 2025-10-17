using System.ComponentModel.Design;

namespace Taller_Vectores3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int [20];
            Random rnd = new Random();
            int busqueda = 0;
            int posicion = -1;

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = rnd.Next(1, 51);
            }
            Console.WriteLine("ingrese el numero que desea buscar: ");
            busqueda = Convert.ToInt32 (Console.ReadLine());

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == busqueda)
                {
                    posicion = i;
                    break;
                }
            }
            if (posicion != -1)
            {
                for (int i = 0; i < numeros.Length; i++)
                {
                    if (numeros[i] == busqueda)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(numeros[i]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(numeros[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("-1 no se encontro el numero");
            }
            
                

             


        }

    }
}
