using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
namespace Taller_Ciclos1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            int numero = 0;
            double calificaciones;
            double promedio = 0;

            while (true) 
            {
                Console.WriteLine("Ingrese calificaciòn (ingrese -1 para terminar)");

                calificaciones = Convert.ToDouble (Console.ReadLine());

                if (calificaciones == -1)
                {
                    break;
                }
                
                numero++;
                promedio += calificaciones;
            }
            promedio /= numero;
            Console.WriteLine($"El promedio de las notas es {promedio}");




            



            
        }
    }
}
