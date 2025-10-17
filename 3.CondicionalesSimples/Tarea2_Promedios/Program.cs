using System;
using System.ComponentModel.Design;

namespace Tarea2_Promedios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realziar un algoritmo que permita solicita 3 calificaciones y calcular el promedio, si el promedio se ubica en los siguientes rangos escribir los mensajes correspondientes. Considrara la situación en la que el promedio generado no este contemplado en los rangos establecidos y mostrar mensaje de error 9.5 a 10 excelente, 8.5 a 9 muy bien, 7.5 a 8.4 bien*/

            Console.WriteLine("Ingrese la primera nota");
            Double nota1 = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota");
            Double nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la tercera nota");
            Double nota3 = Convert.ToDouble(Console.ReadLine());

            Double promedio = ((nota1+nota2+nota3)/3);

            if ((9.5 <= promedio) && (promedio <= 10))
            {
                Console.WriteLine($"El promedio {promedio} es Excelente");
            }
            else if ((8.5 <= promedio) && (promedio <= 9.4))
            {
                Console.WriteLine($"El promedio {promedio} esta Muy bien");
            }
            else if ((7.5 <= promedio) && (promedio <= 8.4))
            {
                Console.WriteLine($"El promedio {promedio} esta bien");
            }
            else if (promedio < 7.4 && promedio >0)
            {
                Console.WriteLine("El promedio esta muy bajo, a estudiar vago!!!");
            }
            else
            {
                Console.WriteLine("Hay un error, escriba bien las notas, use punto para diferenciar los decimales");
            }









        }
    }
}
