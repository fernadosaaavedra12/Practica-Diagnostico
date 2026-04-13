using System;

namespace ExamenParcial
{
    public class Nodo
    {
        // Propiedades automáticas de C#
        public int Dato { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(int dato)
        {
            this.Dato = dato;
            this.Siguiente = null;
        }
    }
}