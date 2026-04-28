# 📚 Implementación de Tipo de Dato Abstracto (TAD): Cola Dinámica
> **Materia:** Estructura de Datos I  
> **Evaluación:** Primer Examen Parcial  
> **Plataforma:** .NET Core / C#  

---

## 1. 📝 Introducción y Justificación
En el ámbito de la Ingeniería de Sistemas, la gestión eficiente de flujos de datos es fundamental. Este proyecto presenta la implementación de una **Cola Dinámica**, una estructura de datos lineal que se rige por el principio **FIFO** (*First-In, First-Out*).

### ¿Por qué es necesaria esta estructura?
A diferencia de los arreglos estáticos, una cola dinámica permite un uso óptimo de la memoria RAM, creciendo o decreciendo según la necesidad del sistema en tiempo de ejecución. 

### Aplicaciones en el mundo real:
* **Sistemas Operativos:** Gestión de ráfagas de CPU y colas de impresión.
* **Redes:** Buffers de paquetes de datos en routers y switches.
* **Simulaciones:** Modelado de filas de espera en servicios bancarios o de logística.

---

## 2. 🏗️ Arquitectura y Diseño (POO)
La solución se ha diseñado bajo el paradigma de **Programación Orientada a Objetos**, garantizando el **Encapsulamiento** y la **Modularidad**.

### Componentes del Sistema:
1.  **Clase `Nodo`:** La unidad de memoria atómica. Contiene el campo `Dato` (información) y una referencia `Siguiente` (puntero lógico).
2.  **Clase `Cola`:** El administrador de la estructura. Contiene las referencias `frente` (salida) y `fin` (entrada).
3.  **Clase `Program`:** Orquestador de la aplicación y punto de entrada del sistema.

### Análisis de Complejidad Algorítmica (Notación Big O)
| Operación | Complejidad | Descripción |
| :--- | :--- | :--- |
| **Encolar (Enqueue)** | $O(1)$ | Inserción directa al final mediante el puntero `fin`. |
| **Desencolar (Dequeue)** | $O(1)$ | Extracción directa desde el puntero `frente`. |
| **Búsqueda** | $O(n)$ | Requiere recorrer la estructura linealmente. |

## 🛠️ Guía de Compilación y Ejecución (Sencilla)

Al ser un proyecto basado en .NET Core, la gestión desde la terminal de Garuda Linux (o cualquier sistema) es estándar y eficiente.
Pre-requisitos

    Tener instalado el SDK de .NET (Versión 6.0 o superior).

Paso 1: Ubicación

Navegue hasta la carpeta raíz del proyecto donde se encuentra el archivo .csproj:

## Bash
--------------------------------------------------------------------------------------------
cd examen1-pregunta1/src/
--------------------------------------------------------------------------------------------
Paso 2: Restaurar y Compilar

Este paso asegura que todas las dependencias y el entorno estén listos, traduciendo el código C# a Lenguaje Intermedio (IL):
## Bash
-----------------------------------------------------------------------------------------
dotnet build
-----------------------------------------------------------------------------------------
en caso de tener una distro como garuda linux

------------------------------------------------------------------------------------------
sudo pacman -S dotnet-sdk
-----------------------------------------------------------------------------------------

Paso 3: Ejecución

Para iniciar la simulación de la cola y ver los resultados en consola:
## Bash
----------------------------------------------------------------------------------------
dotnet run
-----------------------------------------------------------------------------------------
si en caso de no compilar 
-----------------------------------------------------------------------------------------
dotnet new console --force  
-----------------------------------------------------------------------------------------

---

## 📊 Representación Visual
```text
      [ ENTRADA: Enqueue ]                         [ SALIDA: Dequeue ]
              |                                             |
              v                                             v
        +-----------+         +-----------+         +-----------+
        |  NUEVO    | ------> |    NODO   | ------> |   FRENTE  |
        |  (FIN)    |         |   INTERM. |         |  (INICIO) |
        +-----------+         +-----------+         +-----------+
              ^                                           ^
              |___________________________________________|
                         ESTRUCTURA LIGADA (DINÁMICA)

***----------------------------------------------------------------------------------***

