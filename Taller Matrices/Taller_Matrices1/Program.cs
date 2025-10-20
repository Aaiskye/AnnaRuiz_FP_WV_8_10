namespace Taller_Matrices1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por pantalla la suma de los elementos de cada columna.

            int[,] matriz = new int[10, 20];
            Random numero = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    matriz[i, j] = numero.Next(1,10);
                    Console.Write($"{matriz[i, j]} | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int j = 0; j < 20; j++)
            {
                int sumaColumna = 0;
                for (int i = 0; i < 10; i++)
                {
                    sumaColumna = sumaColumna + matriz[i, j];
                }
                Console.WriteLine($"Columna {j}: {sumaColumna}");
            }

        }
    }
}
