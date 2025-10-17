namespace _14.WhilePares
{
    internal class Program
    {
        static void Main(string[] args)
        /* Escribir un algoritmo que cuente cuántos números pares hay en un rango de números del 1 al número n.*/
        {
            Console.WriteLine("Ingrese el número final 'n': ");
            int n = int.Parse(Console.ReadLine());
            int indice = 1;
            int pares = 0;

            while (indice <= n)
            {
                if (indice % 2 == 0)
                {
                    pares++;
                }
                indice++;
            }
            Console.WriteLine("La cantidad de números pares entre 1 y " + n + " son: " + pares);
        }
    }
}
