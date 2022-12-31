using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DLL
{
    public class DoubleLinkedList
    {
        public Node Head { get; set; }

        public void PrintList(DoubleLinkedList list)
        {
            var node = list.Head;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
        public void InsertFirst(DoubleLinkedList list, int nodeValue)
        {
            var newNode = new Node(nodeValue);
            if (list.Head != null)
            {
                newNode.Next = list.Head;
                list.Head.Prev = newNode;
            }
            list.Head = newNode;
        }
        public void InsertLast(DoubleLinkedList list, int nodeValue)
        {
            var newNode = new Node(nodeValue);
            if (list.Head == null)
            {
                list.Head = newNode;
            }
            else {
                var tail = GetLastNode(list);

                tail.Next = newNode;
                newNode.Prev = tail;
            }
        }
        public void DeleteNode(DoubleLinkedList list, int nodeDataToBeDeleted)
        {
            var node = list.Head;
            if (node != null && node.Value == nodeDataToBeDeleted)
            {
                list.Head = node.Next;
                list.Head.Prev = null;
            }

            while (node != null && node.Value != nodeDataToBeDeleted)
                node = node.Next;

            if (node == null)
            {
                Console.WriteLine("Nothing to be deleted");
                return;
            }
            if (node.Prev != null)
            {
                node.Prev.Next = node.Next;
            }
            if (node.Next != null)
            {
                node.Next.Prev = node.Prev;
            }

        }
        public Node GetLastNode(DoubleLinkedList list)
        {
            var node = list.Head;
            while (node.Next != null)
            {
                node = node.Next;
            }
            return node;
        }
    }
}
