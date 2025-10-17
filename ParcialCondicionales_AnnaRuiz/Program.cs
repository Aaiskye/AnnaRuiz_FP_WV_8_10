namespace ParcialCondicionales_AnnaRuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombreEmpleado;
            int añosTrabajo;
            double calificacionActual;
            double calificacionAnterior;
            double promedio;
            double aumentoSalarial;
            double valorAumento;

            Console.WriteLine("Por favor escriba su nombre");
            nombreEmpleado = Console.ReadLine();
            Console.WriteLine("¿Cuantos años lleva trabajando con la empresa?");
            añosTrabajo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su calificaciòn de este año");
            calificacionActual = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la calificación del año anterior");
            calificacionAnterior = Convert.ToDouble(Console.ReadLine());

            switch (calificacionActual)
            {
                case (0.0):
                    promedio = ((calificacionActual + calificacionAnterior) / 2);
                    Console.WriteLine($"{nombreEmpleado} Su calificación promedio es {promedio}");

                    if (añosTrabajo < 1)
                    {
                        aumentoSalarial = 0;
                        Console.WriteLine($"Su porcentaje de aumento salarial es {aumentoSalarial} %");
                        valorAumento = (2500000 * (aumentoSalarial / 100));
                        Console.WriteLine($"El valor de su aumento es {valorAumento}pesos");
                    }
                    else if (añosTrabajo > 5)
                    {
                        aumentoSalarial = 30;
                        Console.WriteLine($"Su porcentaje de aumento salarial es {aumentoSalarial} %");
                        valorAumento = (2500000 * (aumentoSalarial / 100));
                        Console.WriteLine($"El valor de su aumento es {valorAumento}pesos");
                    }
                    else 
                    {
                        if (promedio < 0.4)
                        {
                            aumentoSalarial = 5;
                            Console.WriteLine($"Su porcentaje de aumento salarial es {aumentoSalarial} %");
                            valorAumento = (2500000 * (aumentoSalarial / 100));
                            Console.WriteLine($"El valor de su aumento es {valorAumento}pesos");
                        }
                        else if (promedio < 0.6)
                        {
                            aumentoSalarial = 10;
                            Console.WriteLine($"Su porcentaje de aumento salarial es {aumentoSalarial} %");
                            valorAumento = (2500000 * (aumentoSalarial / 100));
                            Console.WriteLine($"El valor de su aumento es {valorAumento}pesos");
                        }
                        else if (promedio <= 1.0)
                        {
                            aumentoSalarial = 20;
                            Console.WriteLine($"Su porcentaje de aumento salarial es {aumentoSalarial} %");
                            valorAumento = (2500000 * (aumentoSalarial / 100));
                            Console.WriteLine($"El valor de su aumento es {valorAumento}pesos");
                        }

                    }
                    break;
                case (0.4):
                    promedio = ((calificacionActual + calificacionAnterior) / 2);
                    Console.WriteLine($"{nombreEmpleado} Su calificación promedio es {promedio}");

                    if (añosTrabajo < 1)
                    {
                        aumentoSalarial = 0;
                        Console.WriteLine($"Su porcentaje de aumento salarial es {aumentoSalarial} %");
                        valorAumento = (2500000 * (aumentoSalarial / 100));
                        Console.WriteLine($"El valor de su aumento es {valorAumento}pesos");
                    }
                    else if (añosTrabajo > 5)
                    {
                        aumentoSalarial = 30;
                        Console.WriteLine($"Su porcentaje de aumento salarial es {aumentoSalarial} %");
                        valorAumento = (2500000 * (aumentoSalarial / 100));
                        Console.WriteLine($"El valor de su aumento es {valorAumento}pesos");
                    }
                    else 
                    {
                        if (promedio < 0.4)
                        {
                            aumentoSalarial = 5;
                            Console.WriteLine($"Su porcentaje de aumento salarial es {aumentoSalarial} %");
                            valorAumento = (2500000 * (aumentoSalarial / 100));
                            Console.WriteLine($"El valor de su aumento es {valorAumento}pesos");
                        }
                        else if (promedio < 0.6)
                        {
                            aumentoSalarial = 10;
                            Console.WriteLine($"Su porcentaje de aumento salarial es {aumentoSalarial} %");
                            valorAumento = (2500000 * (aumentoSalarial / 100));
                            Console.WriteLine($"El valor de su aumento es {valorAumento}pesos");
                        }
                        else if (promedio <= 1.0)
                        {
                            aumentoSalarial = 20;
                            Console.WriteLine($"Su porcentaje de aumento salarial es {aumentoSalarial} %");
                            valorAumento = (2500000 * (aumentoSalarial / 100));
                            Console.WriteLine($"El valor de su aumento es {valorAumento}pesos");
                        }

                    }
                    break;
                case (0.6):
                    promedio = ((calificacionActual + calificacionAnterior) / 2);
                    Console.WriteLine($"{nombreEmpleado} Su calificación promedio es {promedio}");

                    if (añosTrabajo < 1)
                    {
                        aumentoSalarial = 0;
                        Console.WriteLine($"Su porcentaje de aumento salarial es {aumentoSalarial} %");
                        valorAumento = (2500000 * (aumentoSalarial / 100));
                        Console.WriteLine($"El valor de su aumento es {valorAumento}pesos");
                    }
                    else if (añosTrabajo > 5)
                    {
                        aumentoSalarial = 30;
                        Console.WriteLine($"Su porcentaje de aumento salarial es {aumentoSalarial} %");
                        valorAumento = (2500000 * (aumentoSalarial / 100));
                        Console.WriteLine($"El valor de su aumento es {valorAumento}pesos");
                    }
                    else 
                    {
                        if (promedio < 0.4)
                        {
                            aumentoSalarial = 5;
                            Console.WriteLine($"Su porcentaje de aumento salarial es {aumentoSalarial} %");
                            valorAumento = (2500000 * (aumentoSalarial / 100));
                            Console.WriteLine($"El valor de su aumento es {valorAumento}pesos");
                        }
                        else if (promedio < 0.6)
                        {
                            aumentoSalarial = 10;
                            Console.WriteLine($"Su porcentaje de aumento salarial es {aumentoSalarial} %");
                            valorAumento = (2500000 * (aumentoSalarial / 100));
                            Console.WriteLine($"El valor de su aumento es {valorAumento}pesos");
                        }
                        else if (promedio <= 1.0)
                        {
                            aumentoSalarial = 20;
                            Console.WriteLine($"Su porcentaje de aumento salarial es {aumentoSalarial} %");
                            valorAumento = (2500000 * (aumentoSalarial / 100));
                            Console.WriteLine($"El valor de su aumento es {valorAumento}pesos");
                        }

                    }
                    break;
                case (1.0):
                    promedio = ((calificacionActual + calificacionAnterior) / 2);
                    Console.WriteLine($"{nombreEmpleado} Su calificación promedio es {promedio}");

                    if (añosTrabajo < 1)
                    {
                        aumentoSalarial = 0;
                        Console.WriteLine($"Su porcentaje de aumento salarial es {aumentoSalarial} %");
                        valorAumento = (2500000 * (aumentoSalarial / 100));
                        Console.WriteLine($"El valor de su aumento es {valorAumento}pesos");
                    }
                    else if (añosTrabajo > 5)
                    {
                        aumentoSalarial = 30;
                        Console.WriteLine($"Su porcentaje de aumento salarial es {aumentoSalarial} %");
                        valorAumento = (2500000 * (aumentoSalarial / 100));
                        Console.WriteLine($"El valor de su aumento es {valorAumento}pesos");
                    }
                    else 
                    {
                        if (promedio < 0.4)
                        {
                            aumentoSalarial = 5;
                            Console.WriteLine($"Su porcentaje de aumento salarial es {aumentoSalarial} %");
                            valorAumento = (2500000 * (aumentoSalarial / 100));
                            Console.WriteLine($"El valor de su aumento es {valorAumento}pesos");
                        }
                        else if (promedio < 0.6)
                        {
                            aumentoSalarial = 10;
                            Console.WriteLine($"Su porcentaje de aumento salarial es {aumentoSalarial} %");
                            valorAumento = (2500000 * (aumentoSalarial / 100));
                            Console.WriteLine($"El valor de su aumento es {valorAumento}pesos");
                        }
                        else if (promedio <= 1.0)
                        {
                            aumentoSalarial = 20;
                            Console.WriteLine($"Su porcentaje de aumento salarial es {aumentoSalarial} %");
                            valorAumento = (2500000 * (aumentoSalarial / 100));
                            Console.WriteLine($"El valor de su aumento es {valorAumento}pesos");
                        }

                    }
                    break;
                default:
                    Console.WriteLine("Hay un error en la calificación actual ingresada, recuerde usar punto para los decimales");
                    break;
            }

        }
    }
}
