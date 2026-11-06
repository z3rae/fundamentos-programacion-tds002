using System;

class Program
{
    static void Main(string[] args)
    {
        const double TASA_ITBIS = 0.18;
        double subtotal = 0;
        int cantidadProductos = 0;
        double precio;

        Console.WriteLine("========================================");
        Console.WriteLine("         CAJA REGISTRADORA              ");
        Console.WriteLine("========================================");
        Console.WriteLine("Ingrese los precios de los productos. Digite 0 para finalizar.\n");

        // Ciclo do-while para leer precios hasta que sea 0
        do
        {
            Console.Write("Ingrese el precio del producto (0 para terminar): ");
            if (double.TryParse(Console.ReadLine(), out precio) && precio >= 0)
            {
                if (precio > 0)
                {
                    subtotal += precio;
                    cantidadProductos++;
                }
            }
            else
            {
                Console.WriteLine("Error: Ingrese un precio válido.");
            }
        } while (precio != 0);

        double itbis = subtotal * TASA_ITBIS;
        double total = subtotal + itbis;

        // Mostrar resultados con formato {valor:N2}
        Console.WriteLine("\n========================================");
        Console.WriteLine("           FACTURA / RESUMEN            ");
        Console.WriteLine("========================================");
        Console.WriteLine($"Cantidad de productos: {cantidadProductos}");
        Console.WriteLine($"Subtotal:     RD${subtotal,12:N2}");
        Console.WriteLine($"ITBIS (18%):  RD${itbis,12:N2}");
        Console.WriteLine($"Total a Pagar:RD${total,12:N2}");
        Console.WriteLine("========================================");
    }
}