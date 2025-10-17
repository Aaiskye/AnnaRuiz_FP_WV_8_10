namespace Taller_Ciclos3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numerobase;
            int exponente;
            int resultado = 1;
            string texto;

            while (true)

            {
                resultado = 1;
                Console.WriteLine("ingrese el numero base");
                texto = Console.ReadLine();
                if (texto == "n")
                {
                    break;
                }

                numerobase = Convert.ToInt32(texto);
                Console.WriteLine("ingrese el exponente");
                texto = Console.ReadLine();
                if (texto == "n")
                {
                    break;
                }
                exponente = Convert.ToInt32(texto);

                for (int i = 0; i < exponente; i++)
                {
                    resultado *= numerobase;
                }
                Console.WriteLine($"el resultado de la potenciacion es {resultado}");
            }

        }
    }
}
