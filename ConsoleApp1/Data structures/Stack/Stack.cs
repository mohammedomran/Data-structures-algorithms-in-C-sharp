using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.SLL;

namespace ConsoleApp1
{
    class Stack
    {
        Node top;
        public void PrintStack(Stack stack)
        {
            var node = stack.top;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }

        public void Push(Stack stack, int TopValue)
        {
            Node top = new Node(TopValue);
            top.Next = stack.top;
            stack.top = top;
        }

        public void Pop(Stack stack)
        {
            var node = stack.top;
            stack.top = node.Next;
        }

        public void GetTop(Stack stack)
        {
            Console.WriteLine(stack.top.Value);
        }

    }
}
