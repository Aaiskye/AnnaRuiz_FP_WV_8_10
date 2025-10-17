namespace _18.DoWhileSaldoCuenta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //18.Algoritmo que le pida a un grupo de usuarios su nombre, número de cuenta y saldo; para cada usuario se debe hacer lo siguiente: Si el saldo es mayor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “Es apto para el crédito” Si el saldo es menor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “No es apto para el crédito” El algoritmo debe permitir preguntar la información de usuarios, hasta que se le indique que ya no se desea preguntar más. Además, el algoritmo debe permitir mostrar el número de usuarios a los que se le pregunto por la información, y debe mostrar el promedio de los saldos.
            int usuarios = 0;
            double sumaSaldos = 0, saldoCuenta = 0;
            string continuar = "", nombreUsuario = "", cuentaNumero = "";

            do
            {

                Console.Write("Ingrese nombre del usuario: ");
                nombreUsuario = Console.ReadLine();

                Console.Write("Ingrese número de cuenta: ");
                cuentaNumero = Console.ReadLine();

                Console.Write("Ingrese saldo: ");
                saldoCuenta = Convert.ToDouble(Console.ReadLine());


                usuarios++;
                sumaSaldos += saldoCuenta;


                if (saldoCuenta > 3000000)
                {
                    Console.WriteLine($"Usuario: {nombreUsuario}, Cuenta: {cuentaNumero}, Saldo: {saldoCuenta} : Es apto para el crédito.");
                }
                else
                {
                    Console.WriteLine($"Usuario: {nombreUsuario}, Cuenta: {cuentaNumero}, Saldo: {saldoCuenta} : No es apto para el crédito.");
                }


                Console.Write("¿Desea ingresar otro usuario? (S/N): ");
                continuar = Console.ReadLine();

            } while (continuar.ToUpper() == "S");


            Console.WriteLine($"\nUsuarios encuestados: {usuarios}");
            Console.WriteLine($"Promedio de saldos: {sumaSaldos / usuarios}");
        }
    }
}
