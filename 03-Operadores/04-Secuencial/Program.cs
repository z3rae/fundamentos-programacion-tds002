using System;

class Program
{
    static void Main(string[] args)
    {
        // Constante de conversión de libras a kilogramos
        const double KG_POR_LIBRA = 0.453592;

        // Entradas de datos del usuario
        Console.Write("Ingrese el peso en libras (lb): ");
        double pesoLibras = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la temperatura en Fahrenheit (°F): ");
        double tempFahrenheit = double.Parse(Console.ReadLine());

        // Procesamiento y cálculos secuenciales
        double pesoKilogramos = pesoLibras * KG_POR_LIBRA;
        double tempCelsius = (tempFahrenheit - 32) * 5 / 9;

        // Mostrar resultados redondeados a 2 decimales
        Console.WriteLine("\n--- RESULTADOS DE LA CONVERSIÓN ---");
        Console.WriteLine($"Peso: {pesoLibras:F2} lb equivalen a {pesoKilogramos:F2} kg");
        Console.WriteLine($"Temperatura: {tempFahrenheit:F2} °F equivalen a {tempCelsius:F2} °C");
    }
}