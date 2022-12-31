using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.SLL
{
    public class SinglyLinkedList
    {
            public Node Head { get; set; }

            public void PrintList(SinglyLinkedList list)
            {
                var node = list.Head;
                while (node != null)
                {
                    Console.WriteLine(node.Value);
                    node = node.Next;
                }
            }
            public void InsertFirst(SinglyLinkedList list, int nodeValue)
            {
                var newNode = new Node(nodeValue);
                newNode.Next = list.Head;
                list.Head = newNode;
            }
            public void InsertLast(SinglyLinkedList list, int nodeValue)
            {
                var newNode = new Node(nodeValue);
                if (list.Head == null)
                {
                    list.Head = newNode;
                }
                else
                {
                    var tail = GetLastNode(list);
                    tail.Next = newNode;
                }
            }
            public void DeleteNode(SinglyLinkedList list, int nodeDataToBeDeleted)
            {
                var node = list.Head;
                Node prev = list.Head;
                if (node != null && node.Value == nodeDataToBeDeleted)
                {
                    list.Head = node.Next;
                }

                while (node != null && node.Value != nodeDataToBeDeleted)
                {
                    prev = node;
                    node = node.Next;
                }
                
                if (node == null)
                {
                    Console.WriteLine("Nothing to be deleted");
                    return;
                }
                prev.Next = node.Next;

            }
            public Node GetLastNode(SinglyLinkedList list)
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
