namespace _16.WhileAdivinarNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 101);
            int intento = -1;
            int acumulador = 0;
            Console.WriteLine("Estoy pensando un número entre 1 y 100. ¿Cuál es?: ");
            while (intento != numeroAleatorio)
            {
                acumulador++;
                intento = int.Parse(Console.ReadLine());
                if (intento < numeroAleatorio)
                {
                    Console.WriteLine("Demasiado bajo.");
                }
                else if (intento > numeroAleatorio)
                {
                    Console.WriteLine("Demasiado alto.");
                }
                else
                {
                    Console.WriteLine($"¡Correcto!, te tomo {acumulador} intentos.");
                }
            }
        }
    }
}
