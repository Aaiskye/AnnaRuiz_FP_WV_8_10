using System.Security.Cryptography;
using System.Text;

namespace _6.CondicionalesMultiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            6.Tiendas La Avenida desea desarrollar un programa que permita ingresar por teclado el monto de compra y el día de la semana, para saber: 
            Si el día es martes o jueves, se realizará un descuento del 15 % por la compra.  
            Si el día es lunes o miércoles, se realizará un descuento del 10 % por la compra. 
            Si el día es viernes o sábado, se realizará un descuento del 20 % por la compra. 
            Si es domingo no se realiza descuento.
            Visualizar el día, el descuento y el total a pagar por la compra. 
            */

            float valorCompra = 0;
            float descuento = 0;
            char dia = ' ';

            Console.WriteLine("Ingrese el valor de compra");
            valorCompra = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el dia de la semana: l:Lunes, m:Martes, x:Miercoles, j:Jueves, v:Viernes, s:Sabado, d:Domingo");
            dia = Convert.ToChar(Console.ReadLine());
            switch (dia)
            {
                case 'l':
                    descuento = valorCompra * 0.1f;
                    Console.WriteLine($"Hoy es Lunes, descuento de {descuento}, valor total de la compra: {valorCompra - descuento}");
                    break;

                case 'm':
                    descuento = valorCompra * 0.15f;
                    Console.WriteLine($"Hoy es Martes, descuento de {descuento}, valor total de la compra: {valorCompra - descuento}");
                    break;

                case 'w':
                    descuento = valorCompra * 0.1f;
                    Console.WriteLine($"Hoy es Miercoles, descuento de {descuento}, valor total de la compra: {valorCompra - descuento}");
                    break;

                case 'j':
                    descuento = valorCompra * 0.15f;
                    Console.WriteLine($"Hoy es Jueves, descuento de {descuento}, valor total de la compra: {valorCompra - descuento}");
                    break;

                case 'v':
                    descuento = valorCompra * 0.2f;
                    Console.WriteLine($"Hoy es Viernes, descuento de {descuento}, valor total de la compra: {valorCompra - descuento}");
                    break;

                case 's':
                    descuento = valorCompra * 0.2f;
                    Console.WriteLine($"Hoy es Sabado, descuento de {descuento}, valor total de la compra: {valorCompra - descuento}");
                    break;

                case 'd':
                    descuento = valorCompra * 0f;
                    Console.WriteLine($"Hoy es Domingo, descuento de {descuento}, valor total de la compra: {valorCompra - descuento}");
                    break;

                default:
                    Console.WriteLine("Debe ingresar un dia de la semana valido");
                    break;
            }

            /*Diseñar un algoritmo que permita crear una calculadora básica capaz de realizar operaciones aritméticas entre dos números ingresados por el usuario.Las operaciones disponibles serán: suma, resta, multiplicación y división, las cuales se ejecutarán según la opción seleccionada por el usuario.*/
            double numeroUno = 0.0;
                    
            double numeroDos = 0.0;
            int operacion = 0;
            double resultado =0.0;

            Console.WriteLine("Ingrese el primer numero");
            numeroUno = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            numeroDos = Double.Parse(Console.ReadLine());
            Console.WriteLine($"Ingrese el numero de la operacion aritmetica:\n" +
                $"1. Suma\n" +
                $"2. Resta\n"+
                $"3. Multiplicación\n" +
                $"4. División\n");
            operacion = int.Parse(Console.ReadLine());
            switch (operacion)
            {
                case 1:
                    resultado = numeroUno + numeroDos;
                    Console.WriteLine($"El resultado de la operacion es {resultado}");
                    break;
                case 2:
                    resultado = numeroUno - numeroDos;
                    Console.WriteLine($"El resultado de la operacion es {resultado}");
                    break;
                case 3:
                    resultado = numeroUno * numeroDos;
                    Console.WriteLine($"El resultado de la operacion es {resultado}");
                    break;
                case 4:
                    if (numeroDos != 0)
                    {
                        resultado = numeroUno / numeroDos;
                        Console.WriteLine($"El resultado de la operacion es {resultado}");
                    }
                    else Console.WriteLine("No es valida la división por cero");
                        break;
                default:
                    Console.WriteLine("Operacion no valida");
                    break;
            }

            //Diseñar un algoritmo que solicite al usuario un número del 1 al 12, correspondiente a un mes del año(1 para enero, 2 para febrero, etc.). El algoritmo debe mostrar en pantalla el nombre del mes seleccionado y la cantidad de días que contiene. 
            int mes = 0;

            Console.WriteLine("Ingrese un número del 1 al 12");
            mes = Convert.ToInt32(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine($"Mes: Enero, tiene 31 días");
                    break;
                case 2:
                    Console.WriteLine($"Mes: Febrero, tiene 28 días");
                    break;
                case 3:
                    Console.WriteLine($"Mes: Marzo, tiene 31 días");
                    break;
                case 4:
                    Console.WriteLine($"Mes: Abril, tiene 30 días");
                    break;
                case 5:
                    Console.WriteLine($"Mes: Mayo, tiene 31 días");
                    break;
                case 6:
                    Console.WriteLine($"Mes: Junio, tiene 30 días");
                    break;
                case 7:
                    Console.WriteLine($"Mes: Julio, tiene 31 días");
                    break;
                case 8:
                    Console.WriteLine($"Mes: Agosto, tiene 31 días");
                    break;
                case 9:
                    Console.WriteLine($"Mes: Septiembre, tiene 30 días");
                    break;
                case 10:
                    Console.WriteLine($"Mes: Octubre, tiene 31 días");
                    break;
                case 11:
                    Console.WriteLine($"Mes: Noviembre, tiene 30 días");
                    break;
                case 12:
                    Console.WriteLine($"Mes: Diciembre, tiene 31 días");
                    break;
                default:
                    Console.WriteLine("Ingresa un mes válido :(");
                    break;

            }


        }
        
    }
}
