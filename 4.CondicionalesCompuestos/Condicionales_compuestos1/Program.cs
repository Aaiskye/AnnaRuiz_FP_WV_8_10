using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 4. Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, 
              si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona, 
              indicando que debe abonar impuestos. De lo contrario mostrar el mensaje “Persona exenta de impuestos”.
             */
            String nombreUsuario = "";
            double sueldo = 0f;
            Console.WriteLine("Ingrese el nombre:");
            nombreUsuario = Console.ReadLine();
            if (nombreUsuario == "") {
                Console.WriteLine("Vuelvase serio hermano");
                return;
            }
            Console.WriteLine("Ingrese el sueldo");
            sueldo = float.Parse(Console.ReadLine());
            if (sueldo < 0.0) Console.WriteLine("Muy gracioso...");
            else if (sueldo > 3000.0) Console.WriteLine($"El usuario {nombreUsuario} debe pagar impuestos.");
            else Console.WriteLine($"El usuario {nombreUsuario} no debe pagar impuestos.");
        }
    }
}
