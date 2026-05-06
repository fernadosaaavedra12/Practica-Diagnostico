using System;
using System.Collections.Generic;

public class GrafoTransporte
{
    // Diccionario donde la llave es la ciudad y el valor es la lista de ciudades conectadas
    private Dictionary<string, List<string>> adyacencia;

    public GrafoTransporte()
    {
        adyacencia = new Dictionary<string, List<string>>();
    }

    public void AgregarParada(string ciudad)
    {
        if (!adyacencia.ContainsKey(ciudad))
            adyacencia[ciudad] = new List<string>();
    }

    public void AgregarRuta(string origen, string destino)
    {
        if (adyacencia.ContainsKey(origen) && adyacencia.ContainsKey(destino))
        {
            adyacencia[origen].Add(destino);
            // Si es bidireccional (ida y vuelta), descomenta la siguiente línea:
            // adyacencia[destino].Add(origen);
        }
    }

    public void MostrarRutas()
    {
        foreach (var parada in adyacencia)
        {
            Console.WriteLine($"{parada.Key} conecta con: {string.Join(", ", parada.Value)}");
        }
    }
}