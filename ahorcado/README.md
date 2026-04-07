# Practica-Diagnostico
 Crear un juego por consola Tresn en raya o Ahorcado
# 🧗‍♂️ Juego del Ahorcado 

Un clásico juego del Ahorcado desarrollado en Python, diseñado para ejecutarse directamente en la terminal. Esta evaluacion diagnostico destaca por tener una arquitectura modular, lo que facilita su lectura, mantenimiento y futuras expansiones.

## 📋 Descripción

El objetivo del juego es adivinar una palabra oculta letra por letra antes de que se dibuje por completo la figura del ahorcado. Está pensado para jugarse en solitario contra la computadora, la cual selecciona una palabra al azar de una base de datos interna.

## 🎯 Reglas del Juego

1. **Intentos:** El jugador tiene un máximo de **6 intentos** equivocados. Cada error añade una parte al dibujo del ahorcado.
2. **Victoria:** El jugador gana si logra adivinar todas las letras de la palabra antes de agotar sus intentos.
3. **Derrota:** El jugador pierde si el contador de intentos llega a cero (el ahorcado se dibuja por completo).
4. **Sistema de Pistas:** El jugador tiene derecho a solicitar **una (1) sola pista** por partida escribiendo la palabra `pista` cuando se le pida ingresar una letra.
5. **Entradas válidas:** Solo se permite ingresar una letra a la vez (de la 'A' a la 'Z'). No se penaliza por ingresar caracteres no válidos o letras ya intentadas, simplemente se pide intentar de nuevo.

## 🗂️ Estructura del Proyecto

El código está dividido en 4 módulos principales para mantener una estructura limpia y profesional:

* `main.py`: Es el punto de entrada del programa. Su única función es inicializar y arrancar el juego.
* `logica.py`: Contiene la clase `JuegoAhorcado`, que actúa como el "cerebro". Maneja los turnos, la validación de letras, los intentos restantes y las condiciones de victoria o derrota.
* `arte.py`: Almacena las representaciones visuales (Arte ASCII) de las diferentes fases del ahorcado que se imprimen en la terminal.
* `palabras.py`: Funciona como la base de datos del juego. Contiene un diccionario con las palabras posibles y su respectiva pista asociada.

## 🚀 Cómo ejecutarlo

### Requisitos previos
* Tener **Python 3** instalado en tu sistema.

### Instrucciones
1. Abre tu terminal.
2. Navega hasta el directorio donde se encuentran los archivos del juego:
   ```bash
   cd ruta/a/tu/carpeta/ahorcado
