# 🧮 Calculadora Recursiva Profesional
> **Práctica #04** - Implementación de Algoritmos Recursivos en C#
> **Rama:** `FernandoSaavedra/ED-p6-recursividad`

---

## 👤 Información del Autor
* **Nombre:** Fernando Saavedra
* **Carrera:** Ingeniería en Sistemas
* **Materia:** Estructura de Datos I
* **Entorno:** .NET 10 (Garuda Linux)

---

## 🎯 Objetivo
Desarrollar una biblioteca de funciones matemáticas utilizando exclusivamente **recursividad**, aplicando conceptos de caso base, caso recursivo y gestión de la pila de llamadas (*Stack*).

---

## 🧩 Ejercicios Implementados

### 1. Suma de N Naturales
Calcula la sumatoria acumulada desde 1 hasta N.
* **Lógica:** $f(n) = n + f(n-1)$

### 2. Contador de Dígitos
Determina la cantidad de cifras de un número mediante reducción decimal.
* **Lógica:** División sucesiva entre 10 hasta alcanzar el caso base ($n < 10$).

### 3. Máximo Común Divisor (Euclides)
Implementación del algoritmo clásico de Euclides para encontrar el divisor común más grande.
* **Lógica:** $MCD(a, b) = MCD(b, a \mod b)$

### 4. Inversión de Números
Invierte el orden de los dígitos de un entero utilizando recursión de cola (*Tail Recursion*) con un acumulador.

### 5. Potencia Exponencial
Calcula $base^{exponente}$ mediante multiplicaciones sucesivas, optimizando el uso de memoria.

### 6. Verificación de Números Primos
Test de primalidad incremental que busca divisores de forma recursiva hasta la raíz cuadrada del número.

---

## 🛠️ Instrucciones de Uso

### Compilación y Ejecución
Asegúrese de estar en la carpeta del proyecto y ejecute:

```bash
# Restaurar dependencias y crear archivo de proyecto si es necesario
dotnet new console --force

# Compilar el proyecto
dotnet build

# Ejecutar las pruebas hardcodeadas
dotnet run