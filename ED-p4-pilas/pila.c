#include <stdio.h>
// Implementación de una pila (stack) utilizando un arreglo en C
#define MAX 5
// Definición de la estructura de la pila
typedef struct {
    int datos[MAX];
    int tope;
} Pila;
// Funciones para operar la pila
void inicializar(Pila *p) {
    p->tope = -1;
}
// Función para verificar si la pila está llena
int estaLlena(Pila *p) {
    return p->tope == MAX - 1;
}

// Función para verificar si la pila está vacía
int estaVacia(Pila *p) {
    return p->tope == -1;
}
// Función para agregar un elemento a la pila
void push(Pila *p, int valor) {
    if (estaLlena(p)) {
        printf("Error: Pila llena (Stack Overflow)\n");
    } else {
        p->datos[++(p->tope)] = valor;
        printf("Push: %d\n", valor);
    }
}
// Función para sacar un elemento de la pila
int pop(Pila *p) {
    if (estaVacia(p)) {
        printf("Error: Pila vacia (Stack Underflow)\n");
        return -1;
    }
    return p->datos[(p->tope)--];
}
// Función para mostrar el contenido de la pila
void mostrar(Pila p) {
    if (estaVacia(&p)) {
        printf("Pila vacia.\n");
        return;
    }
// Mostrar los elementos desde el fondo hasta el tope
    printf("Contenido de la pila: ");
    for (int i = 0; i <= p.tope; i++) printf("[%d] ", p.datos[i]);
    printf("\n");
}
// Función principal para probar la implementación de la pila
int main() {
    Pila miPila;
    inicializar(&miPila);
// Agregar elementos a la pila
    push(&miPila, 10);
    push(&miPila, 20);
    push(&miPila, 30);
    mostrar(miPila);
// Sacar elementos de la pila
    printf("Sacando: %d\n", pop(&miPila));
    mostrar(miPila);

    return 0;

}