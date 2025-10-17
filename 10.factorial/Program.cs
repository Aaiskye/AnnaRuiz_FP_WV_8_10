namespace _10.factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10.Crear un algoritmo que permita calcular la factorial de un número dado por el usuario. (5! = 1 * 2 * 3 * 4 * 5)
            Console.WriteLine("Programa para el calculo de factoriales");
            Console.WriteLine("Ingrese un número");
            int numero = int.Parse(Console.ReadLine());
            int factorial = 1;
            int contador = 1;

            while (contador <= numero)
            {
                factorial *= contador;
                Console.WriteLine($"Contador: {contador} - Factorial:{factorial}");
                contador++;
            }
            Console.WriteLine($"El factorial de {numero} es: {factorial}");
        }
    }
}
