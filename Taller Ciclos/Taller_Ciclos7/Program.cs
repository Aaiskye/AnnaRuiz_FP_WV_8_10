namespace Taller_Ciclos7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int personas = 0;
            int niños = 0;
            int jovenes =0;
            int adultos = 0;
            int viejos = 0;
            double promedioN =0;
            double promedioJ = 0;
            double promedioA = 0;
            double promedioV = 0;
            int edad;
            double peso;

            for (personas = 0; personas < 12; personas++)
            {
                Console.WriteLine("Escriba su edad");
                edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escriba su peso");
                peso = Convert.ToInt32(Console.ReadLine());

                if (edad <= 13)
                {
                    niños += 1;
                    promedioN += peso;
                }
                else if (edad >= 14 && edad <= 30)
                {
                    jovenes += 1;
                    promedioJ += peso;
                }
                else if (edad >= 31 && edad <= 60)
                {
                    adultos += 1;
                    promedioA += peso;
                }
                else
                {
                    viejos += 1;
                    promedioV += peso;
                }
            }
            promedioN /= niños;
            promedioJ /= jovenes;
            promedioA /= adultos;
            promedioV /= viejos;

            Console.WriteLine($"Hay {niños} niños y el promedio de su peso es {promedioN}");
            Console.WriteLine($"Hay {jovenes} jovenes y el promedio de su peso es {promedioJ}");
            Console.WriteLine($"Hay {adultos} adultos y el promedio de su peso es {promedioA}");
            Console.WriteLine($"Hay {viejos} viejos y el promedio de su peso es {promedioV}");

        }

    }
}
