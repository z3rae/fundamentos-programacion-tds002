using System;

class Program
{
    static void Main(string[] args)
    {
        // Constantes de deducciones de ley
        const double TASA_AFP = 0.0287; // 2.87%
        const double TASA_SFS = 0.0304; // 3.04%

        // Entrada de datos
        Console.Write("Ingrese el nombre del empleado: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese las horas trabajadas: ");
        double horasTrabajadas = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el pago por hora: ");
        double pagoPorHora = double.Parse(Console.ReadLine());

        // Procesos
        double salarioBruto = horasTrabajadas * pagoPorHora;
        double montoAfp = salarioBruto * TASA_AFP;
        double montoSfs = salarioBruto * TASA_SFS;
        double salarioNeto = salarioBruto - montoAfp - montoSfs;

        // Salida con nombre en MAYÚSCULAS y formato :N2
        Console.WriteLine("\n==================================");
        Console.WriteLine("          NÓMINA DE PAGO          ");
        Console.WriteLine("==================================");
        Console.WriteLine($"Empleado: {nombre.ToUpper()}");
        Console.WriteLine($"Salario Bruto: RD${salarioBruto:N2}");
        Console.WriteLine($"Descuento AFP (2.87%): RD${montoAfp:N2}");
        Console.WriteLine($"Descuento SFS (3.04%): RD${montoSfs:N2}");
        Console.WriteLine($"Salario Neto: RD${salarioNeto:N2}");
        Console.WriteLine("==================================");
    }
}