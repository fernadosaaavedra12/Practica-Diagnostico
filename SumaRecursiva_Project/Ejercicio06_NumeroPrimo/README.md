# Ejercicio 6: Verificar Número Primo

## Descripción
Función recursiva que determina si un número es primo (solo divisible por 1 y por sí mismo).

## Lógica Recursiva
Intentamos dividir el número `n` por un divisor que empieza en 2 e incrementa.
- **Caso Base 1:** Si `n` es menor a 2, no es primo.
- **Caso Base 2:** Si el cuadrado del divisor es mayor a `n`, es primo (no se encontraron divisores).
- **Caso Base 3:** Si `n` es divisible por el divisor actual, no es primo.
- **Caso Recursivo:** Intentar con `divisor + 1`.

## Ejecución
```bash
dotnet run