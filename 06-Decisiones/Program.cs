using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("       EVALUACIÓN 06: DECISIONES        ");
        Console.WriteLine("========================================");
        
        // --- PARTE 1: CALIFICACIÓN ---
        Console.WriteLine("\n--- 1. Sistema de Calificación ---");
        Console.Write("Ingrese una nota (0-100): ");
        string entradaNota = Console.ReadLine();

        // Validar con int.TryParse y un if
        if (int.TryParse(entradaNota, out int nota) && nota >= 0 && nota <= 100)
        {
            // if - else if - else para determinar la letra
            if (nota >= 90)
            {
                Console.WriteLine($"Calificación: A (Nota: {nota})");
            }
            else if (nota >= 80)
            {
                Console.WriteLine($"Calificación: B (Nota: {nota})[cite: 11]");
            }
            else if (nota >= 70)
            {
                Console.WriteLine($"Calificación: C (Nota: {nota})[cite: 11]");
            }
            else
            {
                Console.WriteLine($"Calificación: F (Nota: {nota})[cite: 11]");
            }
        }
        else
        {
            Console.WriteLine("Error: Debe ingresar un número entero válido entre 0 y 100[cite: 11].");
        }

        // --- PARTE 2: CALCULADORA ---
        Console.WriteLine("\n--- 2. Calculadora con Switch ---");
        Console.Write("Ingrese el primer número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Seleccione una operación:");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.Write("Opción (1-4): ");
        int opcion = int.Parse(Console.ReadLine());

        // Resolver con switch[cite: 11]
        switch (opcion)
        {
            case 1:
                Console.WriteLine($"Resultado: {num1} + {num2} = {num1 + num2}");
                break;
            case 2:
                Console.WriteLine($"Resultado: {num1} - {num2} = {num1 - num2}");
                break;
            case 3:
                Console.WriteLine($"Resultado: {num1} * {num2} = {num1 * num2}");
                break;
            case 4:
                // Validar división entre 0[cite: 11]
                if (num2 == 0)
                {
                    Console.WriteLine("Error: No se puede dividir entre cero[cite: 11].");
                }
                else
                {
                    Console.WriteLine($"Resultado: {num1} / {num2} = {num1 / num2}");
                }
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
        Console.WriteLine("========================================");
    }
}