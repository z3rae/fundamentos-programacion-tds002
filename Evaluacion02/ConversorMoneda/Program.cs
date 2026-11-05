using System;

class Program
{
    static void Main(string[] args)
    {
        // Tasa del día fija mediante constante
        const double TASA_USD = 60.25;

        // Entradas de usuario
        Console.Write("Ingrese el monto en pesos (DOP): ");
        double montoPesos = double.Parse(Console.ReadLine());

        // Conversión a dólares
        double montoDolares = montoPesos / TASA_USD;

        // Formato con interpolación y redondeo a 2 decimales
        Console.WriteLine("\n--- RESUMEN DE CONVERSIÓN ---");
        Console.WriteLine($"Monto original: {montoPesos:F2} DOP");
        Console.WriteLine($"Tasa de cambio aplicada: 1 USD = {TASA_USD} DOP");
        Console.WriteLine($"Equivalente en dólares: ${montoDolares:F2} USD");
    }
}