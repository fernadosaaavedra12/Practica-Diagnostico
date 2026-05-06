using System;
using System.Collections.Generic;

public class TablaHashBuses
{
    private int tamano;
    private LinkedList<KeyValuePair<string, Bus>>[] tabla;

    public TablaHashBuses(int tamano)
    {
        this.tamano = tamano;
        tabla = new LinkedList<KeyValuePair<string, Bus>>[tamano];
        for (int i = 0; i < tamano; i++)
        {
            tabla[i] = new LinkedList<KeyValuePair<string, Bus>>();
        }
    }

    // Función Hash: Método de la división
    private int ObtenerIndice(string llave)
    {
        int hash = Math.Abs(llave.GetHashCode());
        return hash % tamano;
    }

    public void Insertar(string placa, Bus datos)
    {
        int indice = ObtenerIndice(placa);
        foreach (var item in tabla[indice])
        {
            if (item.Key == placa)
            {
                // Si la placa ya existe, podrías lanzar una excepción o actualizar
                return;
            }
        }
        tabla[indice].AddLast(new KeyValuePair<string, Bus>(placa, datos));
    }

    public Bus Buscar(string placa)
    {
        int indice = ObtenerIndice(placa);
        foreach (var item in tabla[indice])
        {
            if (item.Key == placa) return item.Value;
        }
        return null;
    }
}