using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.SLL
{
    public class Node
    {
        public Node(int value)
        {
            Value = value;
            Next = null;
        }

        public int Value;
        public Node Next;
    }
}
