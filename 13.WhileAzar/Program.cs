namespace _13.WhileAzar
{
    internal class Program
    {
        static void Main(string[] args)
        /*Realizar un algoritmo que le pida al usuario ingresar por teclado números enteros al azar. Al usuario le corresponde ingresar la cantidad de números que va a introducir.  
        El algoritmo debe escribir en pantalla: 
        La cantidad de números introducidos que son mayores que 0 
        La cantidad de números introducidos menores que 0  
        La cantidad de números iguales a 0. */
        {
            int cantidad, indice = 0;
            int mayores = 0, menores = 0, ceros = 0;

            Console.WriteLine("¿Cuántos números va a introducir?");
            cantidad = int.Parse(Console.ReadLine());

            while (indice < cantidad)
            {
                Console.Write($"Ingresa el número {indice + 1}: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    mayores++;
                }
                else if (numero < 0)
                {
                    menores++;
                }
                else
                {
                    ceros++;
                }

                indice++;
            }

            Console.WriteLine("Mayores que 0: " + mayores);
            Console.WriteLine("Menores que 0: " + menores);
            Console.WriteLine("Iguales a 0: " + ceros);
        }
    }
}
