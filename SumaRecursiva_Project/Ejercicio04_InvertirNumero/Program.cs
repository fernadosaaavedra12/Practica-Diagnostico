using System;

namespace InvertirNumero
{
    class Program
    {
        static void Main()
        {
            int numero = 12345;
            Console.WriteLine($"Número original: {numero}");
            Console.WriteLine($"Número invertido: {Invertir(numero, 0)}");
        }

        static int Invertir(int n, int acumulado)
        {
            if (n == 0) return acumulado;
            
            int ultimoDigito = n % 10;
            int nuevoAcumulado = (acumulado * 10) + ultimoDigito;
            
            return Invertir(n / 10, nuevoAcumulado);
        }
    }
}