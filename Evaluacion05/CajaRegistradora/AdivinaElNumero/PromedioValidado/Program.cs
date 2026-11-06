using System;

class Program
{
    static void Main(string[] args)
    {
        double sumaNotas = 0;
        int contadorNotas = 0;
        double notaMayor = double.MinValue;
        double notaMenor = double.MaxValue;
        double nota;

        Console.WriteLine("========================================");
        Console.WriteLine("          PROMEDIO VALIDADO             ");
        Console.WriteLine("========================================");
        Console.WriteLine("Ingrese notas válidas de 0 a 100. Digite -1 para terminar y ver resultados.\n");

        do
        {
            bool entradaValida = false;
            do
            {
                Console.Write("Ingrese una nota (0-100 o -1 para salir): ");
                if (double.TryParse(Console.ReadLine(), out nota))
                {
                    // Validar rango o condición de salida (-1)[cite: 11]
                    if (nota == -1 || (nota >= 0 && nota <= 100))
                    {
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Nota fuera de rango. Debe ser entre 0 y 100.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Ingrese un número válido.");
                }
            } while (!entradaValida);

            if (nota != -1)
            {
                sumaNotas += nota;
                contadorNotas++;

                if (nota > notaMayor)
                {
                    notaMayor = nota;
                }
                if (nota < notaMenor)
                {
                    notaMenor = nota;
                }
            }

        } while (nota != -1);

        Console.WriteLine("\n========================================");
        Console.WriteLine("          RESULTADOS FINALES            ");
        Console.WriteLine("========================================");
        if (contadorNotas > 0)
        {
            double promedio = sumaNotas / contadorNotas;
            Console.WriteLine($"Total de notas ingresadas: {contadorNotas}");
            Console.WriteLine($"Promedio general: {promedio:F2}");
            Console.WriteLine($"Nota mayor: {notaMayor:F2}");
            Console.WriteLine($"Nota menor: {notaMenor:F2}");
        }
        else
        {
            Console.WriteLine("No se ingresaron notas para promediar.");
        }
        Console.WriteLine("========================================");
    }
}