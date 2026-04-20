using System;

namespace SumaNaturales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suma de los primeros N números");
            Console.Write("Introduce un número entero: ");
            
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                int resultado = CalcularSuma(n);
                Console.WriteLine($"\nEl resultado de la suma hasta {n} es: {resultado}");
            }
            else
            {
                Console.WriteLine("Por favor, introduce un número válido.");
            }
        }

        /// <summary>
        /// Método recursivo para sumar números naturales.
        /// </summary>
        static int CalcularSuma(int n)
        {
            // Caso Base: Detiene la recursión
            if (n <= 1) return n;

            // Paso Recursivo: n + (n-1)
            return n + CalcularSuma(n - 1);
        }
    }
}