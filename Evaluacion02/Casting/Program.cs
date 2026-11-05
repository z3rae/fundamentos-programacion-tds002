using System;

class Program
{
    static void Main(string[] args)
    {
        // Capturar número con decimales de entrada
        Console.Write("Ingrese un número con decimales (ej. 45.89): ");
        double numeroDecimal = double.Parse(Console.ReadLine());

        // 1. Casting explícito (conversión manual forzada truncando los decimales)
        int parteEntera = (int)numeroDecimal;

        // 2. Casting implícito (conversión automática e inofensiva de un entero a double)
        int numeroEnteroBase = 25;
        double numeroDoubleImplicito = numeroEnteroBase;

        // Presentación de resultados
        Console.WriteLine("\n--- DEMOSTRACIÓN DE CASTING ---");
        Console.WriteLine($"Número original (double): {numeroDecimal}");
        Console.WriteLine($"Casting explícito a (int): {parteEntera}");
        Console.WriteLine($"Casting implícito (int {numeroEnteroBase} -> double): {numeroDoubleImplicito:F1}");
    }
}