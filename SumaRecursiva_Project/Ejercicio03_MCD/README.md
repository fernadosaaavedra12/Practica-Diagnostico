# Ejercicio 3: Máximo Común Divisor (MCD)

## Descripción
Cálculo del MCD de dos números enteros utilizando el **Algoritmo de Euclides**.

## Lógica del Algoritmo
El algoritmo se basa en que el MCD de dos números no cambia si el número mayor se reemplaza por el residuo de la división del mayor entre el menor.
- **Caso Base:** Cuando el segundo número (`b`) es 0, el resultado es el primer número (`a`).
- **Caso Recursivo:** Se llama a la función intercambiando los valores: el nuevo `a` es `b`, y el nuevo `b` es el residuo (`a % b`).

## Ejecución
```bash
dotnet run