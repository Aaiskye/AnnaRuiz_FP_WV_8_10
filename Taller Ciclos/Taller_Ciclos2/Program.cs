namespace Taller_Ciclos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int divisor;

            Console.WriteLine("ingrese un numero");
            numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < numero; i++) 
            {
                if (numero % i == 0)
                {
                    Console.WriteLine($"{i} es divisor de {numero}");
                }
                }

              


        }
    }
}
