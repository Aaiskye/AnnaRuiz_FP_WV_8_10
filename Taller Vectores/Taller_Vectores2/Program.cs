namespace Taller_Vectores2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <char> caracteres = new List <char> ();
            char c;

            Console.WriteLine("ingrese caracteres uno por uno, ingrese . para finalizar");

            do
            {
                Console.WriteLine("Caracter: ");
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (c != '.') ;
                {
                    caracteres.Add(c);
                }
            }

            while (c != '.');

            Console.WriteLine("los catacteres ingresados fueron:");
                foreach (char ch in caracteres)
            {
                Console.Write(ch + " ");
            }
            Console.WriteLine("en orden inverso sería:");
            for (int i = caracteres.Count - 1; i >= 0; i--)
            {
                Console.Write(caracteres[i] + " ");
            }
        }
    }
}
