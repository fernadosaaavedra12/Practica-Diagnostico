using System;
using ED_ListasRecursivas.Logica;

namespace ED_ListasRecursivas
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaSimple miLista = new ListaSimple();
            Nodo cabeza = null;

            Console.WriteLine("--- PRÁCTICA: LISTAS RECURSIVAS ---");

            // Probando Inserción Recursiva
            cabeza = miLista.InsertarAlFinal(cabeza, 10);
            cabeza = miLista.InsertarAlFinal(cabeza, 20);
            cabeza = miLista.InsertarAlFinal(cabeza, 30);

            // Probando Mostrar Recursivo
            Console.WriteLine("Contenido de la lista:");
            miLista.Mostrar(cabeza);
        }
    }
}