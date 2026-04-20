using System;

namespace PotenciaRecursiva
{
    class Program
    {
        static void Main()
        {
            int baseNum = 3, exponente = 4;
            Console.WriteLine($"{baseNum} elevado a {exponente} es: {CalcularPotencia(baseNum, exponente)}");
        }

        static int CalcularPotencia(int b, int e)
        {
            if (e == 0) return 1;
            return b * CalcularPotencia(b, e - 1);
        }
    }
}