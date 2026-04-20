using System;

namespace ED_ListasRecursivas.Logica
{
    public class ListaSimple
    {
        // a. Mostrar los elementos de la lista con recursividad
        public void Mostrar(Nodo actual)
        {
            if (actual == null)
            {
                Console.WriteLine("null");
                return;
            }

            Console.Write($"{actual.Valor} -> ");
            Mostrar(actual.Siguiente);
        }

        // b. Insertar al final con recursividad
        public Nodo InsertarAlFinal(Nodo actual, int nuevoValor)
        {
            // Caso base: si el nodo es nulo, creamos el nuevo nodo aquí
            if (actual == null)
            {
                return new Nodo(nuevoValor);
            }

            // Paso recursivo: avanzamos al siguiente nodo
            actual.Siguiente = InsertarAlFinal(actual.Siguiente, nuevoValor);
            
            return actual;
        }
    }
}