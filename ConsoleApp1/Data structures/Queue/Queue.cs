using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.SLL;

namespace ConsoleApp1
{
    class Queue
    {
        Node front = null, back = null;

        public void PrintQueue(Queue queue)
        {
            var node = queue.front;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }

        public void Enqueue(Queue queue, int value)
        {
            var newNode = new Node(value);
            if (front == null)
            {
                queue.front = queue.back = newNode;
            }
            else
            {
                queue.back.Next = newNode;
                queue.back = newNode;
            }
        }
        public void Dequeue(Queue queue)
        {
            var node = queue.front;
            queue.front = node.Next;
        }

        internal void PrintFront(Queue queue)
        {
            Console.WriteLine($"Front is : {queue.front.Value}");
        }
        internal void PrintBack(Queue queue)
        {
            Console.WriteLine($"Back is : {queue.back.Value}");
        }
    }
}
