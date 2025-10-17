namespace Condicionales_simples2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18 años se debe mostrar el mensaje "Bienvenido a mi sitio web"*/

            Console.WriteLine("Ingrese su edad");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Bienvenido a mi sitio web");
            }
            else
            {
                Console.WriteLine("Se requiere +18 para ingresar al sitio web");
            }
        }
    }
}
