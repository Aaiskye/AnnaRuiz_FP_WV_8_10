namespace _24.Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[100];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = 10;
            }
            Console.WriteLine("Los 100 numeros son: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"El numero en la posición {i} es : {numeros[i]}");
            }
        }
    }
}
