# Ejercicio 4: Invertir un número entero

## Descripción
Este programa toma un número entero y voltea sus cifras (ej. 123 -> 321) mediante recursividad.

## Lógica Recursiva
- **Caso Base:** Si el número llega a 0, retornamos el valor acumulado.
- **Caso Recursivo:** Extraemos el último dígito (`n % 10`) y lo sumamos a un acumulador que se multiplica por 10 en cada paso para "mover" la posición decimal.

## Ejecución
```bash
dotnet run