using System;

namespace Taller_Ciclos4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dias = 1;
            int tiempo;
            int suma = 0;
            int promedio =0;
            bool min15 = false;

            for (dias = 1; dias < 11; dias++)
            {
                Console.WriteLine($"Ingrese el tiempo de la {dias} vuelta");
                tiempo = Convert.ToInt32(Console.ReadLine());

                if (tiempo > 20)
                {
                    Console.WriteLine("No es apto para la prueba");
                    break;
                }
                suma += tiempo;
                promedio = (suma / 10);

                if (tiempo < 15) min15 = true;


            }
                Console.WriteLine($"Su tiempo promedio es {promedio}");

                if (promedio > 18)
                {
                    Console.WriteLine("No es apto para la prueba");
                }
            if (min15 == false)
            {
                Console.WriteLine("No es apto para la prueba");
            }
            else
            {
                Console.WriteLine("Usted tiene al menos un tiempo menor de 15 minutos");
            }
             
           
            


        }
    }
}
