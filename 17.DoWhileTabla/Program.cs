namespace _17.DoWhileTabla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Algoritmo que genere y muestre la suma de los cinco primeros numeros enteros
            int contador = 0;
            int acumulador = 0;

            do
            {
                contador++;
                acumulador += contador;
            } while (contador < 5);

            Console.WriteLine($"La suma de los cinco primeros numeros enteros es: {acumulador}");

            //17. Algoritmo que solicita un número y genere su correspondiente tabla de multiplicar desde el 1 hasta el 10. Y así sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar. 

            string respuesta = "S";
            do
            {
                Console.WriteLine("Ingrese un número para crear su tabla de multiplicar: ");

                int numero = int.Parse(Console.ReadLine());

                for (int i = 1; i <= 10; i++)
                {
                    int resultado = numero * i;
                    Console.WriteLine($"{numero} x {i} = {resultado}");
                }
                Console.WriteLine("¿Desea crear otra tabla de multiplicar? (S/N)");
                respuesta = Console.ReadLine().ToUpper();

            } while (respuesta == "S");
        }
    }
}
