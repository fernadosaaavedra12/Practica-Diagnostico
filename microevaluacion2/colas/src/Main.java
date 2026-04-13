public class Main {
    public static void main(String[] args) {
        Cola fila = new Cola();

        fila.encolar(10);
        fila.encolar(20);
        fila.encolar(30);

        System.out.println("Desencolando: " + fila.desencolar()); // Sale el 10
        System.out.println("¿Está vacía?: " + fila.estaVacia());
    }
}