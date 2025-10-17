namespace Taller_Ciclos8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int placa;
            int amarillo = 0;
            int rosa = 0;
            int roja = 0;   
            int verde = 0;
            int azul = 0;
            int autos = -1;
            while (true)
            {
                Console.WriteLine("Ingrese el último digito de la placa del carro, para terminar ingrese -1");
                placa = Convert.ToInt32(Console.ReadLine());
                autos += 1;
                if (placa == 1 || placa == 2)
                {
                    amarillo += 1;
                }
                else if (placa == 3 || placa == 4)
                {
                    rosa += 1;
                }
                else if (placa == 5 || placa == 6)
                {
                    roja += 1;
                }
                else if (placa == 7 || placa == 8)
                {
                    verde += 1;
                }
                else if (placa == 0 || placa == 9)
                {
                    azul += 1;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($" A medellin entraron {autos} carros, de estos {amarillo} tienen calcomania amarilla, {rosa} tienen la calcomania color rosa, {roja} tiene  calcomania roja, {verde} tienen calcomania verde y {azul} tienen calcomania azul.");

                




            }
    }
}
