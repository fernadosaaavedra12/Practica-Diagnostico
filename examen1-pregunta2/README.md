# 🚀 Algoritmo de Ordenamiento: QuickSort
> **Materia:** Estructura de Datos I  
> **Evaluación:** Primer Examen Parcial  
> **Lenguaje:** Java 17+  

--**-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
## Autor:FERNANDO HERNAN SAAVEDRA VARGAS-*-*-*-*-*-*-*
---*-*-*-*-*-*-*-*-*-*-*-*-*-*--*-*-*-*--*-*-*-*-*-*-*
-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*

## 1. 📝 Introducción
El **QuickSort** (Ordenamiento Rápido) es uno de los algoritmos de ordenación más eficientes y utilizados en la computación moderna. Fue desarrollado por Tony Hoare y se basa en la estrategia de diseño algorítmico **Divide y Vencerás**.

### ¿Cómo funciona?
El algoritmo selecciona un elemento llamado **pivote** y particiona el arreglo en dos sub-arreglos:
* Elementos menores o iguales al pivote (a la izquierda).
* Elementos mayores al pivote (a la derecha).
Luego, el proceso se repite recursivamente para cada sub-arreglo hasta que toda la lista esté ordenada.

---

## 2. 🏗️ Detalles de la Implementación
En esta solución, se ha optado por una implementación técnica robusta:
* **Selección del Pivote:** Se utiliza el **último elemento** del arreglo como pivote (esquema de partición de Lomuto).
* **Recursividad:** Se emplea una función recursiva para procesar las particiones de forma independiente.
* **Modularidad:** El código separa la lógica de `particion` de la lógica de control de `ordenar`.

### Análisis de Complejidad (Notación Big O)
| Escenario | Complejidad Temporal | Descripción |
| :--- | :--- | :--- |
| **Mejor Caso** | $O(n \log n)$ | Ocurre cuando el pivote divide el arreglo a la mitad. |
| **Caso Promedio** | $O(n \log n)$ | Es el rendimiento esperado en la mayoría de los casos. |
| **Peor Caso** | $O(n^2)$ | Ocurre si el arreglo ya está ordenado o inversamente ordenado. |

## 🛠️ Guía de Compilación y Ejecución

Siga estos pasos desde su terminal (probado en Garuda Linux):
Paso 1: Ubicación

Navegue hasta la carpeta de la pregunta:
## Bash
--------------------------------------------------------------------------
cd examen1-pregunta2/src/
--------------------------------------------------------------------------
Paso 2: Compilación

Compile el código fuente utilizando el compilador de Java (javac):
## Bash
---------------------------------------------------------------------------
javac QuickSort.java
---------------------------------------------------------------------------
Paso 3: Ejecución

Inicie el programa para verificar el ordenamiento:
## Bash
---------------------------------------------------------------------------------
java QuickSort
---------------------------------------------------------------------------------
---

## 📊 Visualización del Proceso
```text
Arreglo Inicial: [25, 10, 45, 2, 18, 30, 15]
Pivote elegido: 15

Paso 1: Partición alrededor de 15
        [10, 2, 15, 25, 45, 30, 18]

Paso 2: Recursión en sub-arreglos izquierdo [10, 2] y derecho [25, 45, 30, 18]
...
Resultado Final: [2, 10, 15, 18, 25, 30, 45] 


