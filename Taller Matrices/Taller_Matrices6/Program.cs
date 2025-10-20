namespace Taller_Matrices6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Crear una aplicación en C# que permita realizar las siguientes acciones:
                - Crear una matriz de n filas por m columnas
                - Llenar la matriz con números aleatorios del 1 al 3 (investigar la función random en C#)
                - Mostrar la matriz generada
                - Mostrar por pantalla cuantas veces fue ingresado el número 1, el número 2, y el número 3, y cuál de los tres números fue repetido más veces. 
             */
            Console.Write("Ingrese el número de filas: ");
            int filas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de columnas: ");
            int columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];
            Random random = new Random();
            int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz[i, j] = random.Next(1, 4);
                }
            }

            Console.WriteLine("Matriz");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"{matriz[i, j]} ");

                    if (matriz[i, j] == 1)
                        numero1++;
                    else if (matriz[i, j] == 2)
                        numero2++;
                    else if (matriz[i, j] == 3)
                        numero3++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"Número 1 fue ingresado: {numero1} veces");
            Console.WriteLine($"Número 2 fue ingresado: {numero2} veces");
            Console.WriteLine($"Número 3 fue ingresado: {numero3} veces");

            int maximo = 0;
            String repetido = "";
            if (numero1 > numero2)
            {
                maximo = numero1;
                repetido = "1";
            }
            else
            {
                maximo = numero2;
                repetido = "2";
            }

            if (numero3 > maximo)
            {
                maximo = numero3;
                repetido = "3";
            }
            Console.WriteLine();
            Console.WriteLine($"El número más repetido es: {repetido}");

        }
    }
}
