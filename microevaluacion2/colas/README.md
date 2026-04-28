# 📚 Estructura de Datos I: Implementación de Colas (FIFO)
**Microevaluación #02 - Programación Orientada a Objetos**

---

## 👤 Información del Estudiante
* **Autor:** Fernando Saavedra
* **Carrera:** Ingeniería en Sistemas
* **Materia:** Estructura de Datos I
* **Lenguaje:** Java 17+
* **Entorno:** Garuda Linux / VS Code

---

## 🎯 Objetivo y Propósito
El propósito de esta práctica es implementar una **Cola Dinámica** aplicando los pilares de la Programación Orientada a Objetos (POO). Una cola es una estructura lineal donde el primer elemento en ser insertado es el primero en ser retirado, siguiendo el principio **FIFO** (*First-In, First-Out*).

### ¿Por qué usar Colas?
Son fundamentales en computación para:
1. **Planificación de Procesos:** Gestión de hilos en el Sistema Operativo.
2. **Transferencia de Datos:** Buffers de red y colas de impresión.
3. **Sincronización:** Manejo de eventos en interfaces gráficas.

---

## 📊 Arquitectura y Diseño (POO)
La solución se divide en tres componentes principales para garantizar el desacoplamiento:

1. **Clase `Nodo`:** Representa la entidad básica (el dato y el enlace).
2. **Clase `Cola`:** Contiene la lógica de negocio y los punteros `frente` y `fin`.
3. **Clase `Main`:** Actúa como controlador para las pruebas de funcionalidad.

🚀 Guía de Ejecución (Terminal)

Desde la raíz de tu repositorio personal:

1. **Entrar al directorio del proyecto:**
   ```bash
   cd microevaluacion2/colas/
   
    ```compilar
   javac src/*.java -d bin/

   ```Ejecutar
   java -cp bin Main

### Representación Visual de la Estructura
```text
      [ ENTRADA: Enqueue ]                         [ SALIDA: Dequeue ]
              |                                             |
              v                                             v
        +-----------+         +-----------+         +-----------+
        |   NUEVO   | ------> |    NODO   | ------> |   FRENTE  |
        |   (FIN)   |         |   INTERM. |         |  (INICIO) |
        +-----------+         +-----------+         +-----------+



