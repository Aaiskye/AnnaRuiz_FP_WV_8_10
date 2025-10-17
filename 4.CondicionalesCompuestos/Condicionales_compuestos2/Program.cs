namespace _4.Condicionales_Compuestos_Ej2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostrar el siguiente mensaje: “Bienvenido a mi sitio web”. De lo contrario, mostrar el mensaje “No es apto para el contenido de este sitio web”.*/

            int edadUsuario = 0;
            Console.WriteLine("Ingrese la edad del usuario");
            edadUsuario = int.Parse(Console.ReadLine());

            if (edadUsuario <= 0) Console.WriteLine("Este sitio web no es apto para fosiles");
            else if (edadUsuario >= 18) Console.WriteLine("Bienvenido a mi sitio web");
            else Console.WriteLine("No es apto para el contenido de este sitio web");
            
        }
    }
}
