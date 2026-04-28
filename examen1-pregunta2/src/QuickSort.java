import java.util.Arrays;

public class QuickSort {

    public static void main(String[] args) {
        int[] arreglo = {25, 10, 45, 2, 18, 30, 15};
        System.out.println("Arreglo original: " + Arrays.toString(arreglo));

        ordenar(arreglo, 0, arreglo.length - 1);

        System.out.println("Arreglo ordenado: " + Arrays.toString(arreglo));
    }

    public static void ordenar(int[] arr, int bajo, int alto) {
        if (bajo < alto) {
            // Obtener el índice de partición
            int indiceParticion = particion(arr, bajo, alto);

            // Ordenar recursivamente los elementos antes y después de la partición
            ordenar(arr, bajo, indiceParticion - 1);
            ordenar(arr, indiceParticion + 1, alto);
        }
    }

    private static int particion(int[] arr, int bajo, int alto) {
        // Seleccionamos el último elemento como pivote
        int pivote = arr[alto];
        int i = (bajo - 1); // Índice del elemento más pequeño

        for (int j = bajo; j < alto; j++) {
            // Si el elemento actual es menor o igual al pivote
            if (arr[j] <= pivote) {
                i++;
                // Intercambio
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        // Intercambio del pivote con el elemento en i+1
        int temp = arr[i + 1];
        arr[i + 1] = arr[alto];
        arr[alto] = temp;

        return i + 1;
    }
}
