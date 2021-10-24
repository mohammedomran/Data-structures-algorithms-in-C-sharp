using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Node
    {
        public int data { get; set; }
        public Node next { get; set; }
        public Node prev { get; set; }
        public Node(int d)
        {
            data = d;
            prev = null;
            next = null;
        }
    }
}
