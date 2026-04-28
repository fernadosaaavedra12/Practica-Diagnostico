# 🚀 Algoritmos y Criptografía - Guía de Estudio
---

## 📊 1. Algoritmos de Ordenamiento

### 🔹 Métodos Básicos
| Algoritmo | Uso Ideal | Ventajas | Desventajas |
| :--- | :--- | :--- | :--- |
| **Bubble Sort** | Fines académicos | Fácil de programar | Rendimiento desastroso $O(n^2)$ |
| **Selection Sort** | Memoria con escritura costosa | Pocos intercambios físicos | Lento $O(n^2)$ para datos grandes |
| **Insertion Sort** | Arreglos casi ordenados | Eficiencia brutal $O(n)$ | Ineficiente si el orden es inverso |

### 🔹 Métodos Avanzados
* **Quicksort (Divide y Vencerás):**
    * **Mecánica:** Selección de un pivote y partición recursiva.
    * **Uso:** Estándar de la industria, bases de datos y sistemas escalables.
    * **Complejidad:** Promedio de $O(n \log n)$.

---

## 🔍 2. Algoritmos de Búsqueda
*Localización de datos en una estructura.*

1. **Búsqueda Lineal (Secuencial):**
   - **Contexto:** Listas pequeñas o desordenadas.
   - **Complejidad:** $O(n)$.
   - **Ejemplo:** Buscar una carta en un mazo mezclado.

2. **Búsqueda Binaria:**
   - **Contexto:** Bases de datos masivas.
   - **Regla Estricta:** Requiere que los datos estén **previamente ordenados**.
   - **Complejidad:** $O(\log n)$ (Rendimiento extremo).

---

## 🔐 3. Criptografía y Cifrado
*Protección de la privacidad y seguridad de los datos.*

### 🛡️ Hashing (Unidireccional)
- **Uso:** Almacenamiento seguro de contraseñas.
- **Característica:** Es de "solo ida", lo que previene la recuperación del texto original.

### 🔑 Cifrado Simétrico (AES)
- **Mecánica:** Una misma llave para cifrar y descifrar.
- **Uso:** Protección de discos duros y archivos pesados por su alta velocidad.

### 🌐 Cifrado Asimétrico (RSA)
- **Mecánica:** Par de llaves (Llave Pública + Llave Privada).
- **Uso:** Conexiones seguras mediante **HTTPS**.
- **Nota:** Matemáticamente pesado pero esencial para redes inseguras.

---

> *"Los datos cuentan historias. Nosotros aprendemos a leerlas."*

---
