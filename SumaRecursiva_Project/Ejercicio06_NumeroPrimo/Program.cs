using System;

namespace NumeroPrimo
{
    class Program
    {
        static void Main()
        {
            int n = 17;
            Console.WriteLine($"¿Es el {n} un número primo? {EsPrimo(n, 2)}");
        }

        static bool EsPrimo(int n, int divisor)
        {
            if (n < 2) return false;
            if (divisor * divisor > n) return true;
            if (n % divisor == 0) return false;
            
            return EsPrimo(n, divisor + 1);
        }
    }
}