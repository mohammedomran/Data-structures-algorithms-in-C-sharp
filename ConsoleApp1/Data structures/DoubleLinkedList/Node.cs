using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DLL
{
    public class Node
    {
        public Node(int value)
        {
            Value = value;
            Next = null;
            Prev = null;
        }
        public int Value { get; set; }
        public Node Next { get; set; }
        public Node Prev { get; set; }
    }
}
