namespace ParcialArreglos_AnnaRuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] ventas = new int[5, 7];
            int entradaNumero = -1;
            string entradaTexto = "";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese las ventas de la Tienda {i + 1}");
                for (int j = 0; j < 7; j++)
                {
                    entradaNumero = -1;
                    while (entradaNumero < 0)
                    {
                        Console.WriteLine($"Ingrese las ventas del dia {j + 1}");
                        entradaTexto = Console.ReadLine();
                        if (!int.TryParse(entradaTexto, out entradaNumero))
                        {
                            Console.WriteLine("Por favor ingrese solo numeros");
                            entradaNumero = -1;
                        }
                        else
                        {
                            entradaNumero = Convert.ToInt32(entradaTexto);
                        }
                    }
                    ventas[i, j] = entradaNumero;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write($" {ventas[i, j]}");
                }
                Console.WriteLine("");
            }

            double[] promedioSemanal = new double[5];

            for (int i = 0; i < 5; i++)
            {
                promedioSemanal[i] = 0;
                for (int j = 0; j < 7; j++)
                {
                    promedioSemanal[i] += ventas[i, j];
                }
                promedioSemanal[i] /= 7.0;
                Console.WriteLine($"El promedio del almacen {i + 1} es: {promedioSemanal[i]}");
            }

            double[] promedioDia = new double[7];
            for (int i = 0; i < 7; i++)
            {
                promedioDia[i] = 0;
                for (int j = 0; j < 5; j++)
                {
                    promedioDia[i] += ventas[j, i];
                }
                promedioDia[i] /= 5.0;
                Console.WriteLine($"El promedio del dia {i + 1} es: {promedioDia[i]}");
            }
            int minimo  = 0, maximo = 0, almacenMinimo = 0, almacenMaximo=0, diaMaximo = 0, diaMinimo= 0;

            maximo = 0;
            minimo = ventas[0, 0];
            for ( int i = 0;i < 5;i++)
            {
                for (int j = 0; j < 7; j++) {
                    if (ventas[i, j] > maximo)
                    {
                        maximo = ventas[i, j];
                        almacenMaximo = i;
                        diaMaximo = j;

                    }
                    if (ventas[i, j] < minimo) { 
                    
                        minimo = ventas[i, j];
                        almacenMinimo = i;
                        diaMinimo = j;
                    }
                }
            }
            Console.WriteLine($"El maximo de ventas se registró en el dia {diaMaximo +1}, en el almacen {almacenMaximo + 1}");
            Console.WriteLine($"El maximo de ventas se registró en el dia {diaMinimo + 1}, en el almacen {almacenMinimo + 1}");

            double diaMayor = 0;
            double semanaMayor = 0;
            for (int i = 0; i < promedioSemanal.Length; i++) {
                if (promedioSemanal[i] > semanaMayor) {
                    semanaMayor = i;
                }
            }
            for (int i = 0; i < promedioDia.Length; i++)
            {
                if (promedioDia[i] > diaMayor)
                {
                    diaMayor = i;
                }
            }
            Console.WriteLine($"El almacen con mayor ventas {semanaMayor + 1}");
            Console.WriteLine($"El dia con mayor ventas {diaMayor + 1}");
        }
    }
}
