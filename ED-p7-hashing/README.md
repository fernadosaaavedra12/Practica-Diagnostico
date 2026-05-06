# 🚍 FleetControl: Módulo de Búsqueda y Hashing (Tarea 7)

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![Linux](https://img.shields.io/badge/Linux-FCC624?style=for-the-badge&logo=linux&logoColor=black)
![Status](https://img.shields.io/badge/Status-Completado-success?style=for-the-badge)

> **Práctica de Estructuras de Datos:** Implementación de una Tabla Hash desde cero con manejo de colisiones por encadenamiento, aplicada a la optimización de búsquedas en logística de transporte de la flota "FleetControl".

## 📑 Tabla de Contenidos
- [Arquitectura del Sistema](#-arquitectura-del-sistema)
- [Análisis de Complejidad](#-análisis-de-complejidad)
- [Estructura del Proyecto](#-estructura-del-proyecto)
- [Instrucciones de Despliegue](#-instrucciones-de-despliegue)
- [Casos de Prueba](#-casos-de-prueba)

## 🏗️ Arquitectura del Sistema

El núcleo de este módulo reemplaza las búsquedas lineales tradicionales por un acceso a memoria altamente optimizado utilizando **Hashing**.

### Motor de Hashing
Se desarrolló un motor personalizado basado en el **Método de la División**. Convierte identificadores alfanuméricos (Placas) en índices enteros dentro del arreglo:
$$Indice = |Key.GetHashCode()| \pmod{Capacidad_{Tabla}}$$

### Manejo de Colisiones (Chaining)
Para garantizar la integridad del 100% de los datos, se implementó el patrón de **Encadenamiento** utilizando `LinkedList<T>` nativas de C#. Cada posición de la tabla funciona como un *bucket* dinámico.

## 📊 Análisis de Complejidad (Big O)
El rendimiento teórico del módulo implementado se resume a continuación:

| Operación | Caso Promedio | Peor Caso |
| :--- | :---: | :---: |
| **Inserción** | $O(1)$ | $O(n)$ |
| **Búsqueda** | $O(1)$ | $O(n)$ |
| **Espacio** | $O(n)$ | $O(n)$ |

## 📂 Estructura del Proyecto
```text
ESTRUCTURA_DE_DATOS/
└── ED-p7-hashing/
    ├── Bus.cs           # Entidad principal de FleetControl
    ├── TablaHash.cs     # Core de la tabla y enrutamiento
    ├── Program.cs       # Punto de entrada principal
    └── README.md
```

## ⚙️ Instrucciones de Despliegue

### Requisitos Previos
*   **SDK de .NET**: Compatible con entornos Linux (Kali/Garuda) y Windows.
*   **Git CLI**: Para la gestión de ramas y repositorios.

### Instalación y Ejecución

1. **Clonar el repositorio**  
   Usa el siguiente comando para clonar específicamente la rama de esta tarea:
   ```bash
   git clone -b FernandoSaavedra/ED-p7-hashing [https://github.com/fernadosaaavedra12/ESTRUCTURA_DE_DATOS.git](https://github.com/fernadosaaavedra12/ESTRUCTURA_DE_DATOS.git)
2. **compilar y ejecutar**

    Entra en la carpeta del proyecto y lanza la aplicación:
    
    Bash

   ## dotnet run