# Práctica: Listas Enlazadas Simples con Enfoque Recursivo

## 1. Introducción Teórica
En las estructuras de datos dinámicas, una **Lista Enlazada** es una colección de nodos donde cada elemento apunta al siguiente. A diferencia de un Array (estático), la lista no ocupa un bloque de memoria contiguo, lo que permite un crecimiento flexible.

### ¿Por qué usar Recursividad en Listas?
La recursividad es una alternativa natural para manejar listas porque una lista enlazada tiene una **estructura recursiva**: 
> "Una lista es un nodo seguido de otra lista más pequeña (o un vacío)".

Al usar recursividad, eliminamos la necesidad de usar bucles explícitos (`while` o `for`) y dejamos que la **Pila de Llamadas (Stack)** gestione el recorrido.

---

## 2. Análisis de Métodos Implementados

### A. Recorrido y Visualización (Mostrar)
Para mostrar los elementos, aplicamos una estrategia de **Pre-orden**:
1. **Caso Base:** Si el nodo actual es `null`, la recursión se detiene.
2. **Acción:** Se procesa (imprime) el dato del nodo actual.
3. **Paso Recursivo:** Se realiza una nueva llamada enviando el puntero `Siguiente`.

### B. Inserción al Final (Recursiva)
Insertar al final de forma recursiva es más eficiente a nivel de legibilidad que el método iterativo. La lógica sigue este flujo:
- Se busca el "final de la cadena" delegando la tarea al siguiente nodo.
- Cuando se alcanza el `null`, se instancia el nuevo `Nodo`.
- Al retornar de la recursión, los punteros `Siguiente` se actualizan automáticamente para conectar el nuevo eslabón a la cadena existente.

---

## 3. Ejecución y Pruebas

Para validar el funcionamiento en este entorno (Garuda Linux), se debe compilar y ejecutar el proyecto mediante el SDK de .NET:

### Comandos de Consola:
```bash
# Navegar a la carpeta del proyecto
cd ED-ListasRecursivas

# Compilar y ejecutar
dotnet run