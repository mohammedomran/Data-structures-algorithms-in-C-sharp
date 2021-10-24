using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class DoubleLinkedList
    {
        public Node head { get; set; }

        public void InsertFirst(DoubleLinkedList list, int data)
        {
            var newNode = new Node(data);
            newNode.next = list.head;
            newNode.prev = null;

            if (list.head != null)
                list.head.prev = newNode;

            list.head = newNode;
        }
        public void InsertLast(DoubleLinkedList list, int data)
        {
            var newNode = new Node(data);

            if (list.head == null)
            {
                newNode.prev = null;
                list.head = newNode;
                return;
            }

            Node lastNode = GetLastNode(list);
            lastNode.next = newNode;
            newNode.prev = lastNode;

        }

        public void DeleteNode(DoubleLinkedList list, int nodeData)
        {
            var node = list.head;
            if(node != null && node.data == nodeData)
            {
                list.head = node.next;
                list.head.prev = null;
            }
            while (node != null && node.data != nodeData)
                node = node.next;

            if (node == null)
            {
                return;
            }
            if (node.next != null)
            {
                node.next.prev = node.prev;
            }
            if (node.prev != null)
            {
                node.prev.next = node.next;
            }
        }

        private Node GetLastNode(DoubleLinkedList list)
        {
            Node node = list.head;
            while(node.next != null)
            {
                node = node.next;
            }
            return node;
        }

        public void PrintList(DoubleLinkedList list)
        {
            Node node = list.head;
            
                while (node != null)
                {
                    Console.WriteLine(node.data);
                    node = node.next;
                }
            
        }
    }
}
