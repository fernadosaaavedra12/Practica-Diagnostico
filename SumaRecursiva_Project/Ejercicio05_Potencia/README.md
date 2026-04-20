# Ejercicio 5: Potencia Recursiva

## Descripción
Cálculo de la potencia de un número sin utilizar operadores directos (`^` o `**`) ni librerías como `Math.Pow`.

## Lógica Recursiva
Elevar un número $a$ a la potencia $n$ es lo mismo que multiplicar $a$ por sí mismo $n$ veces ($a \times a^{n-1}$).
- **Caso Base:** Si el exponente es 0, el resultado es 1.
- **Caso Recursivo:** La base multiplicada por la función llamada con `exponente - 1`.

## Ejecución
```bash
dotnet run