#include <stdio.h>

// Función para mostrar el arreglo en cada paso del ordenamiento
void mostrarPasos(int arr[], int n, int i, int clave) {
    printf("Paso %d [Insertando %d]: ", i, clave);
    for (int k = 0; k < n; k++) {
        printf("%d ", arr[k]);
    }
    printf("\n");
}
// Función de ordenamiento por inserción
void insertionSort(int arr[], int n) {
    // Recorremos el arreglo desde el segundo elemento
    int i, clave, j;
    for (i = 1; i < n; i++) {
        clave = arr[i];
        j = i - 1;
// Mover los elementos del arreglo que son mayores que la clave a una posición adelante
        while (j >= 0 && arr[j] > clave) {
            arr[j + 1] = arr[j];
            j = j - 1;
        }
        arr[j + 1] = clave;
        mostrarPasos(arr, n, i, clave);
    }
}
//función principal
int main() {
    int datos[] = {15, 3, 9, 1, 12, 8, 5, 20, 7, 4};
    int n = sizeof(datos) / sizeof(datos[0]);

    printf("--- ORDENAMIENTO POR INSERCIÓN ---\n");
    insertionSort(datos, n);
    
    printf("\nArreglo Final Ordenado: ");
    for(int i=0; i<n; i++) printf("%d ", datos[i]);
    printf("\n");

    return 0;
}
// El código implementa el algoritmo de ordenamiento por inserción en C. La función `insertionSort` recorre el arreglo y ordena los elementos, mientras que la función `mostrarPasos` muestra el estado del arreglo después de cada inserción. En la función `main`, se define un arreglo de datos, se llama a la función de ordenamiento y se muestra el arreglo final ordenado.