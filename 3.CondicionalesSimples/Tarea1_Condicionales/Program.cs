namespace Tarea1_CondicionalesSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro número");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 != numero2)
            {
                if (numero1 > numero2)
                {
                    Console.WriteLine($"El número mayor es {numero1}");
                }
                else
                {
                    Console.WriteLine($"El número mayor es {numero2}");
                }
            }
            else {
                Console.WriteLine("Ingrese números diferentes entre si");
             }



        }
    }
}
