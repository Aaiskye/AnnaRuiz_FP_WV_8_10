namespace ParcialCiclos_AnnaRuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ventas;
            double anual = 0;
            int previoMax=0;
            int previoMin=999999999;
            int mes = 1;
            double promedioVentas;
            int mejorMes = 0;
            int peorMes = 0;

            for (mes = 1; mes < 13; mes++)
            {
                Console.WriteLine($"Ingrese las ventas realizadas en el mes {mes}");
                ventas = Convert.ToInt32(Console.ReadLine());
                if (ventas > previoMax)
                {
                    previoMax = ventas;
                }
                if (ventas < previoMin)
                {
                    previoMin = ventas;
                }
                if (ventas==previoMax)
                {
                    mejorMes = mes;
                }
                if (ventas == previoMin)
                {
                    peorMes = mes;
                }
                anual += ventas;
            }
            promedioVentas = (anual / 12);
            Console.WriteLine($"El mes con mas ventas fue el mes {mejorMes} con {previoMax} ventas");
            Console.WriteLine($"El mes con menos ventas fue el mes {peorMes} con {previoMin} ventas");
            if (promedioVentas > 500) 
            {
                Console.WriteLine($"El promedio de ventas fue {promedioVentas}. Se aprobo la meta.");
            }
            else
            {
                Console.WriteLine($"El promedio de ventas fue {promedioVentas}. La meta de ventas no se cumplio");
            }
        }
    }
}
