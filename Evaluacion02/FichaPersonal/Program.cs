using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar datos personales al usuario
        Console.Write("Ingrese su nombre: ");
        string nombreUsuario = Console.ReadLine();

        Console.Write("Ingrese su edad: ");
        int edadUsuario = int.Parse(Console.ReadLine());

        Console.Write("Ingrese su estatura en metros (ej. 1.75): ");
        double estaturaUsuario = double.Parse(Console.ReadLine());

        Console.Write("¿Trabaja actualmente? (true/false): ");
        bool trabajaUsuario = bool.Parse(Console.ReadLine());

        // Cálculo del año en que cumplirá 30 años
        const int ANIO_ACTUAL = 2026;
        int anioCumpleTreinta = ANIO_ACTUAL + (30 - edadUsuario);

        // Mostrar la ficha técnica con interpolación
        Console.WriteLine("\n==================================");
        Console.WriteLine("          FICHA PERSONAL          ");
        Console.WriteLine("==================================");
        Console.WriteLine($"Nombre: {nombreUsuario}");
        Console.WriteLine($"Edad: {edadUsuario} años");
        Console.WriteLine($"Estatura: {estaturaUsuario} m");
        Console.WriteLine($"¿Trabaja?: {(trabajaUsuario ? "Sí" : "No")}");
        Console.WriteLine($"Año en que cumplirá 30 años: {anioCumpleTreinta}");
        Console.WriteLine("==================================");
    }
}