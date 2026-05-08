using System;
using EX_Final_Estructuras.Models;
using EX_Final_Estructuras.Structures;

namespace EX_Final_Estructuras.Services
{
    public class NetworkSimulator
    {
        private CustomQueue queue;
        private DoubleLinkedList history;
        private HashTable cache;

        public NetworkSimulator()
        {
            queue = new CustomQueue();
            history = new DoubleLinkedList();
            cache = new HashTable();
        }

        public void Simulate()
        {
            Console.WriteLine("=== SIMULADOR DE RED ===\n");

            // ENQUEUE
            for (int i = 1; i <= 5; i++)
            {
                Packet packet = new Packet(
                    i,
                    $"192.168.0.{i}",
                    $"10.0.0.{i}",
                    i * 100
                );

                queue.Enqueue(packet);

                Console.WriteLine($"Paquete encolado: {packet}");
            }

            Console.WriteLine("\n=== PROCESANDO PAQUETES ===");

            // DEQUEUE
            while (!queue.IsEmpty())
            {
                Packet current = queue.Dequeue();

                Console.WriteLine($"\nProcesando paquete {current.Id}");

                history.Add(current.SourceIP);

                Console.WriteLine($"IP añadida al historial: {current.SourceIP}");

                cache.AddIP(current.SourceIP);

                Console.WriteLine($"IP añadida a caché segura");
            }

            history.PrintForward();
            history.PrintBackward();

            Console.WriteLine("\n=== BÚSQUEDA O(1) ===");

            string searchIP = "192.168.0.3";

            if (cache.SearchIP(searchIP))
            {
                Console.WriteLine($"IP encontrada en caché: {searchIP}");
            }

            cache.ExplainCollision();

            Console.WriteLine("\n=== LIMPIEZA DE SEGURIDAD ===");

            string removeIP = "192.168.0.2";

            cache.RemoveIP(removeIP);

            history.Remove(removeIP);

            Console.WriteLine($"IP eliminada: {removeIP}");

            history.PrintForward();
        }
    }
}