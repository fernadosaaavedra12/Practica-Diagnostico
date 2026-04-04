#include <stdio.h>
#include <stdlib.h>

// Definición de la estructura del Nodo
struct Nodo {
    int dato;
    struct Nodo* siguiente;
};

// Función para crear un nuevo nodo en memoria dinámica
struct Nodo* crearNodo(int valor) {
    struct Nodo* nuevo = (struct Nodo*)malloc(sizeof(struct Nodo));
    nuevo->dato = valor;
    nuevo->siguiente = NULL;
    return nuevo;
}

// Función para insertar al final de la lista
void insertarAlFinal(struct Nodo** cabeza, int valor) {
    struct Nodo* nuevo = crearNodo(valor);
    
    if (*cabeza == NULL) {
        *cabeza = nuevo;
    } else {
        struct Nodo* temporal = *cabeza;
        while (temporal->siguiente != NULL) {
            temporal = temporal->siguiente;
        }
        temporal->siguiente = nuevo;
    }
    printf("✅ Nodo [%d] insertado.\n", valor);
}

// Función para imprimir la lista
void mostrarLista(struct Nodo* cabeza) {
    printf("\n--- ESTADO DE LA LISTA ENLAZADA ---\n");
    struct Nodo* temporal = cabeza;
    while (temporal != NULL) {
        printf("[%d] -> ", temporal->dato);
        temporal = temporal->siguiente;
    }
    printf("NULL\n");
}

int main() {
    struct Nodo* miLista = NULL; // Lista vacía al inicio

    insertarAlFinal(&miLista, 10);
    insertarAlFinal(&miLista, 20);
    insertarAlFinal(&miLista, 30);
    insertarAlFinal(&miLista, 40);

    mostrarLista(miLista);

    return 0;
}