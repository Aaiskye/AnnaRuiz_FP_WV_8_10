namespace _1.InicioVisualStudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaracion e inicializaciòn de variables
            string nombre = "anna";
            const string iva = "19%";
            string segundoNombre = "Katherine";
            string apellidos = "Ruiz Ruales";

            nombre = "Anna";
            //iva = "20%; no puede cambiar el valor por ser una constante

            Console.WriteLine($"Bienvenido al curso de programación \n {nombre} {segundoNombre} {apellidos}" +" "+ iva);
            Console.ReadKey();

        }
    }
}
