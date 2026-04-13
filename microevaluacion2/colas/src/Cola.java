public class Cola {
    private Nodo frente;
    private Nodo fin;

    public Cola() {
        this.frente = null;
        this.fin = null;
    }

    // Método para insertar (Encolar)
    public void encolar(int dato) {
        Nodo nuevoNodo = new Nodo(dato);
        if (this.fin == null) {
            this.frente = nuevoNodo;
            this.fin = nuevoNodo;
            return;
        }
        this.fin.siguiente = nuevoNodo;
        this.fin = nuevoNodo;
    }

    // Método para eliminar (Desencolar)
    public int desencolar() {
        if (this.frente == null) {
            System.out.println("La cola está vacía");
            return -1;
        }
        int dato = this.frente.dato;
        this.frente = this.frente.siguiente;

        if (this.frente == null) {
            this.fin = null;
        }
        return dato;
    }

    public boolean estaVacia() {
        return frente == null;
    }
}