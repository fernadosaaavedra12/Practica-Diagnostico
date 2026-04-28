# logica.py
import readline
import random
from ahorcado.palabras import LISTA_PALABRAS
from arte import FASES

class JuegoAhorcado:
    def __init__(self):
        # Elegir una palabra al azar
        self.palabra = random.choice(list(LISTA_PALABRAS.keys()))
        self.pista = LISTA_PALABRAS[self.palabra]
        self.letras_adivinadas = set()
        self.intentos_restantes = 6
        self.pista_usada = False

    def mostrar_estado(self):
        # Imprimir el dibujo correspondiente a los intentos restantes
        print(FASES[6 - self.intentos_restantes])
        
        # Mostrar las letras adivinadas o guiones bajos
        estado_palabra = [letra if letra in self.letras_adivinadas else "_" for letra in self.palabra]
        print(f"\nPalabra: {' '.join(estado_palabra)}")
        print(f"Intentos restantes: {self.intentos_restantes}")
        
        if self.pista_usada:
            print(f"Pista: {self.pista}")

    def jugar(self):
        print("\n" + "="*30)
        print(" ¡BIENVENIDO AL AHORCADO! ")
        print("="*30)
        
        while self.intentos_restantes > 0:
            self.mostrar_estado()
            
            # Verificar si ya ganó
            if all(letra in self.letras_adivinadas for letra in self.palabra):
                print(f"\n¡Felicidades! Has ganado. La palabra era: {self.palabra.upper()}")
                return

            opcion = input("\nIngresa una letra (o escribe 'PISTA' para usar tu única pista): ").lower()

            if opcion == 'pista':
                if not self.pista_usada:
                    self.pista_usada = True
                    print("\n*** Has activado tu pista ***")
                else:
                    print("\n[!] Ya usaste tu pista en esta partida.")
                continue

            # Validar que sea una sola letra
            if len(opcion) != 1 or not opcion.isalpha():
                print("\n[!] Por favor, ingresa solo una letra válida.")
                continue

            if opcion in self.letras_adivinadas:
                print(f"\n[!] Ya intentaste con la letra '{opcion}'. Intenta con otra.")
                continue

            self.letras_adivinadas.add(opcion)

            if opcion not in self.palabra:
                self.intentos_restantes -= 1
                print(f"\n[X] ¡Incorrecto! La letra '{opcion}' no está en la palabra.")
            else:
                print(f"\n[V] ¡Bien hecho! La letra '{opcion}' sí está.")

        # Si sale del bucle while, significa que se quedó sin intentos (perdió)
        self.mostrar_estado()
        print("\n¡FIN DEL JUEGO! Te han ahorcado.")
        print(f"La palabra correcta era: {self.palabra.upper()}")