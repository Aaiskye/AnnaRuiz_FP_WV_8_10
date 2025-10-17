namespace _15.WhileAhorro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Realizar un algoritmo para determinar cuánto ahorrará una persona en un año, si al final de cada mes deposita cantidadesvariables de dinero; además, se quiere saber cuánto lleva ahorrado cada mes.

            double totalAhorrado = 0, ingreso = 0;

            for (int mes = 1; mes <= 12; mes++)
            {
                Console.Write("¿Cuanto dinero va a depositar este mes? [Mes " + mes + "]: ");
                ingreso = double.Parse(Console.ReadLine());

                totalAhorrado += ingreso;

                Console.WriteLine("Llevas ahorrado hasta el mes " + mes + ": " + totalAhorrado);
            }

            Console.WriteLine("\nEl ahorro total en el año es: " + totalAhorrado);
        }
    }
}
