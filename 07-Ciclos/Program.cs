using System;

class Program
{
    static void Main(string[] args)
    {
        int numero = 0;

        // 1. Pedir un número entre 1 y 12 y validarlo con do-while
        do
        {
            Console.Write("Ingrese un número entero entre 1 y 12: ");
        } while (!int.TryParse(Console.ReadLine(), out numero) || numero < 1 || numero > 12);

        Console.WriteLine($"\n========================================");
        Console.WriteLine($"      TABLA DE MULTIPLICAR DEL {numero}      ");
        Console.WriteLine($"========================================");

        int contador = 1;
        int sumaAcumulada = 0; // Acumulador para la suma de los resultados

        // 2. Mostrar la tabla del 1 al 12 con while
        while (contador <= 12)
        {
            int resultado = numero * contador;
            Console.WriteLine($"{numero} x {contador} = {resultado}");

            // Acumular el resultado[cite: 13]
            sumaAcumulada += resultado;
            contador++;
        }

        // 3. Mostrar al final la suma de todos los resultados[cite: 13]
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"Suma total de los resultados: {sumaAcumulada}[cite: 13]");
        Console.WriteLine($"========================================");
    }
}