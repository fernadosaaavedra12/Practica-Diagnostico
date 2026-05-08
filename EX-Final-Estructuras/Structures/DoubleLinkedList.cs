using System;
using EX_Final_Estructuras.Models;

namespace EX_Final_Estructuras.Structures
{
    public class DoubleLinkedList
    {
        private HistoryNode head;
        private HistoryNode tail;
        private int count;

        public DoubleLinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public void Add(string ip)
        {
            HistoryNode newNode = new HistoryNode(ip);

            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Previous = tail;
                tail = newNode;
            }

            count++;

            if (count > 100)
            {
                RemoveOldest();
            }
        }

        private void RemoveOldest()
        {
            if (head != null)
            {
                head = head.Next;

                if (head != null)
                    head.Previous = null;

                count--;
            }
        }

        public void Remove(string ip)
        {
            HistoryNode current = head;

            while (current != null)
            {
                if (current.IP == ip)
                {
                    if (current.Previous != null)
                        current.Previous.Next = current.Next;
                    else
                        head = current.Next;

                    if (current.Next != null)
                        current.Next.Previous = current.Previous;
                    else
                        tail = current.Previous;

                    count--;
                    return;
                }

                current = current.Next;
            }
        }

        public void PrintForward()
        {
            Console.WriteLine("\nHistorial (Antiguo -> Reciente)");

            HistoryNode current = head;

            while (current != null)
            {
                Console.WriteLine(current.IP);
                current = current.Next;
            }
        }

        public void PrintBackward()
        {
            Console.WriteLine("\nHistorial (Reciente -> Antiguo)");

            HistoryNode current = tail;

            while (current != null)
            {
                Console.WriteLine(current.IP);
                current = current.Previous;
            }
        }
    }
}