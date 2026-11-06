using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("           MENÚ PRINCIPAL               ");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Mostrar tablas de multiplicar (1 al 10)");
            Console.WriteLine("2. Dibujar triángulo de asteriscos");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                opcion = -1; // Opción inválida por defecto
            }

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\n--- Tablas de Multiplicar (1 al 10) ---");
                    // Ciclos anidados con formato de columnas alineadas {valor,4}
                    for (int i = 1; i <= 10; i++)
                    {
                        for (int j = 1; j <= 10; j++)
                        {
                            int resultado = i * j;
                            Console.Write($"{resultado,4}");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 2:
                    Console.WriteLine("\n--- Triángulo de Asteriscos ---");
                    Console.Write("Ingrese el número de filas (N): ");
                    if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                    {
                        // Ciclos para dibujar el triángulo de N filas[cite: 11]
                        for (int i = 1; i <= n; i++)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Por favor, ingrese un número entero válido mayor a 0.");
                    }
                    break;

                case 0:
                    Console.WriteLine("\nSaliendo del programa. ¡Hasta luego!");
                    break;

                default:
                    Console.WriteLine("\nOpción no válida. Intente de nuevo.");
                    break;
            }

            if (opcion != 0)
            {
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 0); // Menú con do-while[cite: 11]
    }
}