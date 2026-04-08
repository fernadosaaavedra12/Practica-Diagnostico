<div align="center">
  <h1>🚀 Práctica 3: Ordenamiento Rápido (Quick Sort)</h1>
  <p><i>Implementación en C utilizando el paradigma "Divide y Vencerás"</i></p>

  ![C](https://img.shields.io/badge/Lenguaje-C-blue.svg)
  ![Compilador](https://img.shields.io/badge/Compilador-GCC-orange.svg)
  ![Estructura](https://img.shields.io/badge/Estructura-Arreglos-success.svg)
</div>

---

**Estudiante:** Fernando Saavedra  
**Materia:** Estructura de Datos  

## 🧠 Fundamento Teórico

**QuickSort** es uno de los algoritmos de ordenamiento más eficientes en la práctica. A diferencia de métodos iterativos como *Bubble Sort*, QuickSort es recursivo y se basa en tres pasos fundamentales:

1. **Selección del Pivote:** Se elige un elemento del arreglo como punto de referencia. En esta implementación, se utiliza el **último elemento**.
2. **Partición:** Se reorganiza el arreglo de manera que todos los elementos menores al pivote queden a su izquierda, y los mayores a su derecha.
3. **Recursividad:** Se aplica el mismo proceso a las dos sub-listas creadas (izquierda y derecha) hasta que el tamaño de las sub-listas sea de 0 o 1.

### 📌 ¿Por qué este pivote?
Elegir el último elemento como pivote es la técnica de partición de *Lomuto*. Es fácil de implementar, aunque para arreglos ya ordenados puede generar el peor caso de rendimiento. Otras alternativas avanzadas incluyen usar un "pivote aleatorio" o la "mediana de tres".

---

## 🔬 Traza del Algoritmo (Paso a Paso)

Para el arreglo inicial de prueba: `[10, 80, 30, 90, 40, 50, 70]`
Pivote seleccionado: **70**

* **Paso 1:** Los menores a 70 van a la izquierda, mayores a la derecha.
  * Estado: `[10, 30, 40, 50, 70, 90, 80]`
  * *El 70 ya está en su posición final.*
* **Paso 2 (Sub-lista Izquierda):** `[10, 30, 40, 50]` (Pivote: 50)
  * Estado: `[10, 30, 40, 50]` (Sin cambios, ya está ordenada).
* **Paso 3 (Sub-lista Derecha):** `[90, 80]` (Pivote: 80)
  * Estado: `[80, 90]` (Intercambio realizado).
* **Resultado Final:** `[10, 30, 40, 50, 70, 80, 90]`

---

## 📊 Análisis de Complejidad Computacional

El rendimiento de QuickSort varía fuertemente dependiendo de la elección del pivote y el estado inicial de los datos:

| Escenario | Complejidad de Tiempo | Descripción |
| :--- | :--- | :--- |
| **Mejor Caso** | O(n log n) | El pivote divide el arreglo en dos mitades exactamente iguales. |
| **Caso Promedio** | O(n log n) | Comportamiento esperado en la mayoría de distribuciones de datos. |
| **Peor Caso** | O(n²) | Ocurre si el arreglo ya está ordenado (o al revés) y se elige el extremo como pivote. |
| **Memoria (Espacio)**| O(log n) | Costo de la pila de llamadas del sistema por la recursividad. |

**Comparativa:** Frente a algoritmos de complejidad cuadrática O(n²) como *Insertion Sort* o *Bubble Sort*, QuickSort procesa volúmenes grandes de datos en una fracción del tiempo.

---

## 🛠️ Compilación y Ejecución en Entornos Linux

Este código está optimizado para compilarse sin dependencias externas usando GCC.

1. Navega hasta el directorio del repositorio:
   ```bash
   cd ruta/a/tu/ESTRUCTURA_DE_DATOS
   Compila el código fuente:
Bash

gcc quicksort.c -o quicksort -Wall

(La bandera -Wall activa las advertencias para asegurar un código limpio).

Ejecuta el binario:
Bash

./quicksort

Salida Esperada:
Arreglo original: 10 80 30 90 40 50 70 
Arreglo ordenado con QuickSort: 10 30 40 50 70 80 90
