namespace Taller_Ciclos6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int datos = 0;
            int numeros;
            int positivos = 0;
            int negativos = 0;
            int ceros = 0;
            int sumaP = 0;
            int sumaN = 0;

            for (datos = 0; datos < 10; datos++)
            {
                Console.WriteLine("Escriba un número");
                numeros = Convert.ToInt32(Console.ReadLine());

                if (numeros >= 1)
                {
                    positivos += 1;
                    sumaP += numeros;
                }
                else if (numeros <= -1)
                {
                    negativos += 1;
                    sumaN += numeros;
                }
                else
                {
                    ceros += 1;
                }
            }
            Console.WriteLine($"Hay {positivos} números positivos y su suma es {sumaP}");
            Console.WriteLine($"Hay {negativos} números negativos y su suma es {sumaN}");
            Console.WriteLine($"Hay {ceros} numeros iguales a  0");
        }
    }
}
