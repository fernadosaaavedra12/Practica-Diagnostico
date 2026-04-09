# 📚 Práctica 4: Estructura de Datos - Pilas (Arrays)

**Estudiante:** Fernando Saavedra  
**Materia:** Estructura de Datos  
**Implementación:** Pila Estática sobre Arreglos (LIFO)

## 📋 Descripción
Esta práctica consiste en la implementación de una **Pila (Stack)** utilizando un arreglo estático en lenguaje C. La pila sigue el principio **LIFO** (*Last In, First Out*), donde el último elemento en entrar es el primero en salir.

### Operaciones Implementadas:
1. **Push:** Inserta un elemento en el tope. Controla el error de *Stack Overflow*.
2. **Pop:** Elimina y retorna el elemento del tope. Controla el *Stack Underflow*.
3. **Peek/Top:** Permite observar el elemento superior sin extraerlo.
4. **isEmpty/isFull:** Funciones booleanas para verificar el estado de la estructura.

## 📊 Análisis de Complejidad
| Operación | Complejidad de Tiempo |
| :--- | :--- |
| **Insertar (Push)** | $O(1)$ |
| **Eliminar (Pop)** | $O(1)$ |
| **Acceso (Peek)** | $O(1)$ |
| **Búsqueda** | $O(n)$ |

## 🛠️ Instrucciones de Uso
Para compilar y ejecutar en tu sistema (optimizado para GCC en entornos Linux como Garuda):

```bash
# Compilar el programa
gcc pila.c -o pila -Wall

# Ejecutar la simulación
./pila