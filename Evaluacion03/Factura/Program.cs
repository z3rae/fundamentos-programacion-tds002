using System;

class Program
{
    static void Main(string[] args)
    {
        // Constante de impuestos
        const double TASA_ITBIS = 0.18; // 18%

        // Entrada de datos
        Console.Write("Ingrese el nombre del producto: ");
        string producto = Console.ReadLine();

        Console.Write("Ingrese la cantidad: ");
        int cantidad = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el precio unitario: ");
        double precioUnitario = double.Parse(Console.ReadLine());

        // Procesos
        double subtotal = cantidad * precioUnitario;
        double itbis = subtotal * TASA_ITBIS;
        double total = subtotal + itbis;

        // Salida con columnas alineadas usando interpolación
        Console.WriteLine("\n========================================");
        Console.WriteLine("                FACTURA                 ");
        Console.WriteLine("========================================");
        Console.WriteLine($"Producto: {producto}");
        Console.WriteLine($"Cantidad: {cantidad}");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"{"Subtotal:",-20} RD${subtotal,12:N2}");
        Console.WriteLine($"{"ITBIS (18%):",-20} RD${itbis,12:N2}");
        Console.WriteLine($"{"Total a Pagar:",-20} RD${total,12:N2}");
        Console.WriteLine("========================================");
    }
}