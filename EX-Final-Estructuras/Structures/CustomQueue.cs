using System.Collections.Generic;
using EX_Final_Estructuras.Models;

namespace EX_Final_Estructuras.Structures
{
    public class CustomQueue
    {
        private Queue<Packet> queue;

        public CustomQueue()
        {
            queue = new Queue<Packet>();
        }

        public void Enqueue(Packet packet)
        {
            queue.Enqueue(packet);
        }

        public Packet Dequeue()
        {
            return queue.Count > 0 ? queue.Dequeue() : null;
        }

        public bool IsEmpty()
        {
            return queue.Count == 0;
        }
    }
}