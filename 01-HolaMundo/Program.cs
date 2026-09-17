/*
 * Nombre: Angel Ogando
 * Fecha: 16 de septiembre de 2026
 * Descripción: Programa de consola en C# que muestra una tarjeta de presentación con marco decorativo.
 */

using System;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicialización del borde superior del marco con '='
            Console.WriteLine("========================================================================");
            Console.WriteLine("|                                                                      |");

            // Impresión de datos personales y frase descriptiva usando '*'
            Console.WriteLine("|  * Nombre:    Angel Ogando                                           |");
            Console.WriteLine("|  * Matrícula: 2026-0763                                              |");
            Console.WriteLine("|  * Carrera:   Tecnología en Desarrollo de Software                   |");
            Console.WriteLine("|  * Frase:     \"Apasionado por la tecnología y el código estructurado\" |");

            // Cierre visual del marco de la tarjeta
            Console.WriteLine("|                                                                      |");
            Console.WriteLine("========================================================================");
        }
    }
}
