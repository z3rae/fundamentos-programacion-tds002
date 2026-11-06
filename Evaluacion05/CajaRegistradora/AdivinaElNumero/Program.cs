using System;

class Program
{
    static void Main(string[] args)
    {
        // Generar número secreto entre 1 y 100[cite: 11]
        int numeroSecreto = Random.Shared.Next(1, 101);
        int intentos = 0;
        int intentoUsuario;

        Console.WriteLine("========================================");
        Console.WriteLine("          ADIVINA EL NÚMERO             ");
        Console.WriteLine("========================================");
        Console.WriteLine("He pensado en un número entre 1 y 100. ¡Intenta adivinarlo!\n");

        do
        {
            Console.Write("Ingrese su suposición: ");
            if (int.TryParse(Console.ReadLine(), out intentoUsuario))
            {
                intentos++;
                if (intentoUsuario < numeroSecreto)
                {
                    Console.WriteLine("El número secreto es MAYOR.\n");
                }
                else if (intentoUsuario > numeroSecreto)
                {
                    Console.WriteLine("El número secreto es MENOR.\n");
                }
                else
                {
                    Console.WriteLine($"\n¡Felicidades! Adivinaste el número en {intentos} intentos.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número entero válido.\n");
            }

        } while (intentoUsuario != numeroSecreto);
    }
}