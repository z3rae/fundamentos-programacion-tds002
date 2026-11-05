using System;

class Program
{
    static void Main(string[] args)
    {
        // Constante requerida
        const int ANIO_ACTUAL = 2026;

        // Solicitar y capturar los datos
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());

        Console.Write("Ingrese su estatura en metros (ej. 1.75): ");
        double estatura = double.Parse(Console.ReadLine());

        // Calcular el año de nacimiento
        int anioNacimiento = ANIO_ACTUAL - edad;

        // Mostrar la información usando interpolación de cadenas
        Console.WriteLine("\n--- Resultado ---");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad} años");
        Console.WriteLine($"Estatura: {estatura} m");
        Console.WriteLine($"Año de nacimiento estimado: {anioNacimiento} (Calculado con ANIO_ACTUAL = {ANIO_ACTUAL})");
    }
}