namespace Condicionales_simples1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Crear un algoritmo que permita ingresar el nombre y el sueldo de  una persona, si el sueldo supera los 3000 pesos mostrar un mensaje en pantalla con el nombre de la persona indicando que debe abonar impuestos */

           
            Console.WriteLine("Escriba su nombre");
            String nombre = Console.ReadLine();
            Console.WriteLine("Escriba su sueldo");
            int sueldo = Convert.ToInt32(Console.ReadLine());

            if (sueldo > 3000)
            {
                Console.WriteLine($"el señor/a {nombre} debe abonar impuestos");
            }
            else {
                Console.WriteLine($"El señor/a {nombre} no debe abonar impuestos");
            }


            

            
         }
    }
}
