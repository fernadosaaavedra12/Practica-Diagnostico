using System;
using System.Collections.Generic;

namespace EX_Final_Estructuras.Structures
{
    public class HashTable
    {
        private Dictionary<string, bool> safeIPs;

        public HashTable()
        {
            safeIPs = new Dictionary<string, bool>();
        }

        public void AddIP(string ip)
        {
            if (!safeIPs.ContainsKey(ip))
            {
                safeIPs[ip] = true;
            }
        }

        public bool SearchIP(string ip)
        {
            return safeIPs.ContainsKey(ip);
        }

        public void RemoveIP(string ip)
        {
            if (safeIPs.ContainsKey(ip))
            {
                safeIPs.Remove(ip);
            }
        }

        public void ExplainCollision()
        {
            Console.WriteLine("\n[INFO]");
            Console.WriteLine("Dictionary en C# maneja colisiones internamente");
            Console.WriteLine("utilizando hashing y buckets.");
        }
    }
}