using System;

namespace AlgoritmoEuclides
{
    class Program
    {
        static void Main()
        {
            int num1 = 48, num2 = 18;
            Console.WriteLine($"Calculando MCD de {num1} y {num2}...");
            Console.WriteLine($"Resultado: {CalcularMCD(num1, num2)}");
        }

        static int CalcularMCD(int a, int b)
        {
            if (b == 0) return a;
            return CalcularMCD(b, a % b);
        }
    }
}