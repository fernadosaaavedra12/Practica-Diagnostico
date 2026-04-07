#include <stdio.h>

// Función para intercambiar dos elementos
void intercambiar(int* a, int* b) {
    int t = *a;
    *a = *b;
    *b = t;
}

// Función de partición: coloca el pivote en su lugar
int particion(int arr[], int bajo, int alto) {
    int pivote = arr[alto]; 
    int i = (bajo - 1); 

    for (int j = bajo; j <= alto - 1; j++) {
        if (arr[j] < pivote) {
            i++;
            intercambiar(&arr[i], &arr[j]);
        }
    }
    intercambiar(&arr[i + 1], &arr[alto]);
    return (i + 1);
}

// Función principal de QuickSort
void quickSort(int arr[], int bajo, int alto) {
    if (bajo < alto) {
        int pi = particion(arr, bajo, alto);
        
        // Ordenar elementos antes y después de la partición
        quickSort(arr, bajo, pi - 1);
        quickSort(arr, pi + 1, alto);
    }
}

void imprimirArreglo(int arr[], int n) {
    for (int i = 0; i < n; i++) printf("%d ", arr[i]);
    printf("\n");
}

int main() {
    int datos[] = {10, 80, 30, 90, 40, 50, 70};
    int n = sizeof(datos) / sizeof(datos[0]);

    printf("Arreglo original: ");
    imprimirArreglo(datos, n);

    quickSort(datos, 0, n - 1);

    printf("Arreglo ordenado con QuickSort: ");
    imprimirArreglo(datos, n);
    return 0;
}
