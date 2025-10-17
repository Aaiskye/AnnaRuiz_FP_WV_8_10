namespace Taller_Vectores1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[15];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("ingrese un numero entero");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            int max = numeros[0];
            int min = numeros[0];

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > max)
                    max = numeros[i];
                if (numeros[i] < min)
                    min = numeros[i];
            }
            Console.WriteLine("los numeros ingresados son:");
            foreach (int i in numeros)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine($"el mayor numero es {max}");
            Console.WriteLine($"el menor numero es {min}");
        }

                 


        
    }
}
