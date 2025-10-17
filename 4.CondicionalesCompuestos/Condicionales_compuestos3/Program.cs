using System.Net;

namespace _4.Condicionales_Compuestos_Ej3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear un algoritmo que permita ingresar dos números, si el primer número es mayor al segundo número informar su suma y diferencia, en caso contrario informar el producto y la división del primer número respecto al segundo número.
             * */
            Double numeroUno = 0, numeroDos = 0;
            Console.WriteLine("Ingrese el primer número");
            numeroUno = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            numeroDos = Double.Parse(Console.ReadLine());
            if (numeroUno > numeroDos)
            {
                Console.WriteLine($"Suma: {numeroUno + numeroDos}. Resta: {numeroUno - numeroDos}");
            }
            else
            {
                Console.WriteLine($"Producto: {numeroUno * numeroDos}. División: {numeroDos - numeroUno}");
            }
        }
    }
}
