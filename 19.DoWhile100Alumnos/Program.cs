namespace _19.DoWhile100Alumnos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //19.En un grupo de 100 alumnos, se desea saber cuántos de los estudiantes son hombres y cuántos son mujeres, además se desea saber cuántos son mayores de edad y cuántos no. 
            int edad = 0;
            char genero = ' ';
            int mayorEdad = 0;
            int menorEdad = 0;
            int estudiantesMasculinos = 0, estudiantesFemeninas = 0;
            int indiceEstudiante = 0;

            do
            {
                Console.WriteLine($"Estudiante número {indiceEstudiante + 1}, ingrese su edad: ");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine("¿Con cuál genero se identifica? (M - Masculino, F - Femenino): ");
                genero = char.Parse(Console.ReadLine().ToUpper());

                if (edad >= 18)
                {
                    mayorEdad++;
                }
                else
                {
                    menorEdad++;
                }
                if (genero == 'M')
                {
                    estudiantesMasculinos++;
                }
                else if (genero == 'F')
                {
                    estudiantesFemeninas++;
                }
                else
                {
                    Console.WriteLine("Género no válido. Por favor ingrese 'M' para masculino o 'F' para femenino.");
                }
                indiceEstudiante++;
            } while (indiceEstudiante < 100);
            Console.WriteLine($"Resultados de la encuesta:");
            Console.WriteLine($"Cantidad de estudiantes mayores de edad: {mayorEdad}");
            Console.WriteLine($"Cantidad de estudiantes menores de edad: {menorEdad}");
            Console.WriteLine($"Cantidad de estudiantes que se identifican como hombres: {estudiantesMasculinos}");
            Console.WriteLine($"Cantidad de estudiantes que se identifican como mujeres: {estudiantesFemeninas}");
        }
    }
}
