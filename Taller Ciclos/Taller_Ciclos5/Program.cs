namespace Taller_Ciclos5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int encuesta= 0;
            int afavor= 0;
            int encontra= 0;
            int noresponde=0;
            int personas = 0;
            while (true) {
                Console.WriteLine("¿Que opina sobre el servicio militar obligatorio para las mujeres? Escriba 1-A favor 2-En contra 3-No responde 4-Terminar encuesta");
                encuesta = Convert.ToInt32(Console.ReadLine());

                if (encuesta == 1)
                {
                    afavor += 1;
                }
                else if (encuesta == 2)
                {
                    encontra += 1;
                }
                else if (encuesta == 3)
                {
                    noresponde += 1;
                }
                else
                {
                    break;
                }
                personas++;
            }

            double porcentaje1 = ((afavor / (Convert.ToDouble(personas)) * 100.0));
            double porcentaje2 = ((encontra / (Convert.ToDouble(personas)) * 100.0));
            double porcentaje3 = ((noresponde / (Convert.ToDouble(personas)) * 100.0));

            Console.WriteLine($"El numero de personas a favor es {porcentaje1} %");
            Console.WriteLine($"El numero de personas en contra es {porcentaje2} %");
            Console.WriteLine($"El numero de personas que no responde es {porcentaje3} %");



        }
    }
}
