# Práctica 2: Estructuras de Datos Lineales - Listas Enlazadas

**Estudiante:** Fernando Saavedra  
**Materia:** Estructura de Datos  
**Lenguaje:** C  
**Entorno:** Garuda Linux (GCC Compiler)

## 📝 Descripción
Esta práctica consiste en la implementación de una **Lista Enlazada Simple**. A diferencia de los arreglos estáticos, esta estructura utiliza asignación dinámica de memoria para permitir que la lista crezca o se encoja durante la ejecución del programa.

## 🛠️ Conceptos Implementados
* **Nodos:** Estructuras que contienen un valor entero y un puntero al siguiente elemento.
* **Memoria Dinámica:** Uso de `malloc()` para reservar espacio en el Heap.
* **Punteros de Punteros:** Manejo de la dirección de la cabeza de la lista para inserciones eficientes.



## 🚀 Instrucciones de Ejecución
1. Abrir la terminal en la carpeta del proyecto.
2. Compilar el código fuente:
   ```bash
   gcc lista_enlazada.c -o lista