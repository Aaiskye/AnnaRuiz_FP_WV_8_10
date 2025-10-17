namespace Taller_Vectores4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vector = 0;

            do
            {
                Console.WriteLine("cuantos numeros desea ingresar? (debe ser un numero impar diferente de 1) ");
                vector = Convert.ToInt32(Console.ReadLine());

            } while (vector % 2 == 0 || vector == 1);
         
            int eleccion = 0;
            Random rnd = new Random();
            Console.WriteLine("ingrese un numero entero");
            eleccion = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[vector];

            numeros[(vector/2)] = eleccion;
            Console.WriteLine(vector / 2);

            for (int i = 0; i < (numeros.Length / 2); i++)
            {
                numeros[i] = rnd.Next(1,eleccion);
            }
            for (int i = (vector / 2) + 2; i < numeros.Length; i++)
            {
                numeros[i] = eleccion + i;
            }
            for (int i = 0; i < numeros.Length; i++) 
            {
               Console.Write (numeros[i] + " ");
            }



        }
    }
}
