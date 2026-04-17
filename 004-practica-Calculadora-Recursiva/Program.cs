using System;
// Importante: No necesitamos 'using' si están en el mismo namespace
namespace PracticaRecursividad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PRUEBAS RECURSIVAS (004) ===\n");

            Console.WriteLine($"MCD(48, 18): {CalculadoraRecursiva.CalcularMCD(48, 18)}");
            Console.WriteLine($"Invertir(1234): {CalculadoraRecursiva.InvertirNumero(1234)}");
            
            Console.WriteLine("\n================================");
        }
    }
}