﻿namespace Taller_Matrices5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Desarrollar un programa e C# que: 
                - Le pida al usuario ingresar por teclado el número de filas y columnas de una matriz de enteros 
                - Cargue los datos de la matriz ingresándolos por teclado  
                - Muestre la matriz ingresada 
                - Luego convierta cada fila de la matriz en una columna, es decir la fila 1 pasaría a ser ahora la columna 1. 
                - Mostrar la nueva matriz 
            */

            Console.Write("Ingrese el número de filas: ");
            int filas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de columnas: ");
            int columnas = int.Parse(Console.ReadLine());

            int[,] matrizOriginal = new int[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Ingrese el número en la posición [{i}, {j}]: ");
                    matrizOriginal[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Matriz original:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"{matrizOriginal[i, j]} ");
                }
                Console.WriteLine();
            }

            int[,] matrizModificada = new int[columnas, filas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matrizModificada[j, i] = matrizOriginal[i, j];
                }
            }

            Console.WriteLine("Matriz modificada:");
            for (int i = 0; i < columnas; i++)
            {
                for (int j = 0; j < filas; j++)
                {
                    Console.Write($"{matrizModificada[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
