using System;

class Program
{
    static void Main(string[] args)
    {
        // Entrada de datos
        Console.Write("Ingrese el radio del círculo: ");
        double radio = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el primer cateto del triángulo rectángulo: ");
        double catetoA = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo cateto del triángulo rectángulo: ");
        double catetoB = double.Parse(Console.ReadLine());

        // Procesos geométricos
        double areaCirculo = Math.PI * Math.Pow(radio, 2);
        double circunferencia = 2 * Math.PI * radio;
        double hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));

        // Salida con 2 decimales
        Console.WriteLine("\n========================================");
        Console.WriteLine("         RESULTADOS GEOMÉTRICOS         ");
        Console.WriteLine("========================================");
        Console.WriteLine("--- Círculo ---");
        Console.WriteLine($"Área: {areaCirculo:F2}");
        Console.WriteLine($"Circunferencia: {circunferencia:F2}");
        Console.WriteLine("\n--- Triángulo Rectángulo ---");
        Console.WriteLine($"Catetos: {catetoA:F2} y {catetoB:F2}");
        Console.WriteLine($"Hipotenusa: {hipotenusa:F2}");
        Console.WriteLine("========================================");
    }
}