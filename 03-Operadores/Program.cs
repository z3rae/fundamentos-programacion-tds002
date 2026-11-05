using System;

class Program
{
    static void Main(string[] args)
    {
        // Leer dos números enteros del usuario
        Console.Write("Ingrese el primer número entero: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número entero: ");
        int num2 = int.Parse(Console.ReadLine());

        // Operaciones aritméticas y lógicas
        int suma = num1 + num2;
        int resta = num1 - num2;
        int producto = num1 * num2;
        
        // Conversión a double para obtener la división real con decimales
        double divisionReal = (double)num1 / num2;
        int divisionEntera = num1 / num2;
        int residuo = num1 % num2;
        bool esPar = (num1 % 2 == 0);

        // Mostrar resultados usando interpolación
        Console.WriteLine("\n--- RESULTADOS DE OPERADORES ---");
        Console.WriteLine($"Suma: {num1} + {num2} = {suma}");
        Console.WriteLine($"Resta: {num1} - {num2} = {resta}");
        Console.WriteLine($"Producto: {num1} * {num2} = {producto}");
        Console.WriteLine($"División real: {num1} / {num2} = {divisionReal}");
        Console.WriteLine($"División entera: {num1} / {num2} = {divisionEntera}");
        Console.WriteLine($"Residuo (módulo): {num1} % {num2} = {residuo}");
        Console.WriteLine($"¿El primer número ({num1}) es par?: {esPar}");
    }
}

/*
 ==========================================
 PRUEBA DE ESCRITORIO (x = 10, y = 3)
 ==========================================
 Entradas:
 - num1 (x) = 10
 - num2 (y) = 3

 Procesos y Salidas evaluadas:
 1. Suma: 10 + 3 = 13
 2. Resta: 10 - 3 = 7
 3. Producto: 10 * 3 = 30
 4. División real: 10 / 3 = 3.3333333333333335
 5. División entera: 10 / 3 = 3
 6. Residuo: 10 % 3 = 1
 7. ¿El primero es par?: 10 % 2 == 0 -> true
*/
