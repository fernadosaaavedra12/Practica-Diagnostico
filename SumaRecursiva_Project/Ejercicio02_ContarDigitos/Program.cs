using System;

namespace ContarDigitos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Contador de Dígitos Recursivo ---");
            Console.Write("Introduce un número entero: ");
            
            // Usamos Math.Abs por si el usuario introduce un número negativo
            if (long.TryParse(Console.ReadLine(), out long n))
            {
                long numeroAbsoluto = Math.Abs(n);
                int totalDigitos = ContarDigitosRecursivo(numeroAbsoluto);
                Console.WriteLine($"El número {n} tiene {totalDigitos} dígitos.");
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingresa un número entero.");
            }
        }

        /// <summary>
        /// Método que cuenta dígitos dividiendo el número entre 10 sucesivamente.
        /// </summary>
        static int ContarDigitosRecursivo(long n)
        {
            // Caso Base: Si el número tiene un solo dígito
            if (n < 10)
            {
                return 1;
            }

            // Paso Recursivo: 1 (el dígito actual) + el resto de dígitos
            return 1 + ContarDigitosRecursivo(n / 10);
        }
    }
}