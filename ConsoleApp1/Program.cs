using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {

            var list = new DoubleLinkedList();
            list.InsertLast(list, 7);
            list.InsertLast(list, 9);
            list.InsertLast(list, 11);
            list.PrintList(list);
            list.DeleteNode(list, 7);
            Console.WriteLine("after deleting");
            list.PrintList(list);

        }
    }
}
