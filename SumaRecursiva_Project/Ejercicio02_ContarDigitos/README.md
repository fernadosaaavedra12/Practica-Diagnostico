# Ejercicio 2: Contar dígitos de un número entero

## Descripción
Este programa determina cuántos dígitos componen a un número entero utilizando **recursividad**. 

## Lógica Recursiva
Para contar los dígitos, "reducimos" el número dividiéndolo entre 10 en cada llamada, lo que elimina el último dígito.
- **Caso Base:** Si el número es menor a 10, significa que solo queda un dígito. Retornamos 1.
- **Caso Recursivo:** Retornamos `1 + ContarDigitos(n / 10)`. Ese "1" representa el dígito que acabamos de "quitar".

## Método de Ejecución
1. Abre la terminal en la carpeta `Ejercicio02_ContarDigitos`.
2. Ejecuta:
   ```bash
   dotnet run