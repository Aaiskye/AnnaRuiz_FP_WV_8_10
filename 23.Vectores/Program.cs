namespace _23.Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vectores
            int[] numeros = new int[5];

            string[] nombres = new string[4];

            //Asignar valores a las posiciones
            numeros[0] = 20;
            numeros[1] = 15;
            numeros[2] = 30;
            numeros[3] = 5;
            numeros[4] = 45;

            int[] numeros1 = new int[] {5, 12, 4, 7, 9};
            int[] numeros2 = { 5, 12, 4, 7, 9 };

            //Yo puedo recorrer el vector para llenarlo de datos o para recuperar los datos
            char[] caracteres = new char[4];
            string[] posiciones = new string[] { "primer", "segundo", "tercer", "cuarto" };
            for (int i = 0; i < caracteres.Length; i++)
            {
                Console.WriteLine($"Ingrese el {posiciones[i]} caracter");
                caracteres[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine($"El caracter en su tercera posición es el dato: {caracteres[2]}");

            for (int i = 0; i < caracteres.Length; i++)
            { 
                Console.Write(caracteres[i] + " | ");
            }
            Console.WriteLine();
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"Ingrese el {posiciones[i]} nombre");
                nombres[i] = Convert.ToString(Console.ReadLine());
            }
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"El nombre en la posición {i} es: {nombres[i]}");
            }
        }
    }
}
