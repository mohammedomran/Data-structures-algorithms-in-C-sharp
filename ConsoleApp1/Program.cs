using ConsoleApp1.DLL;
using ConsoleApp1.SLL;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {

            /*var list = new SinglyLinkedList();
            list.InsertLast(list, 7);
            list.InsertLast(list, 9);
            list.InsertLast(list, 11);
            list.DeleteNode(list, 4);
            list.PrintList(list);*/

            /*var list = new DoubleLinkedList();
            list.InsertLast(list, 7);
            list.InsertLast(list, 9);
            list.InsertLast(list, 11);
            list.DeleteNode(list, 4);
            list.PrintList(list);*/

            /*var stack = new Stack();
            stack.Push(stack, 1);
            stack.Push(stack, 2);
            stack.Push(stack, 3);
            stack.PrintStack(stack);
            stack.Pop(stack);
            stack.PrintStack(stack);*/

            /*var queue = new Queue();
            queue.Enqueue(queue, 1);
            queue.Enqueue(queue, 2);
            queue.Enqueue(queue, 3);
            queue.PrintQueue(queue);
            queue.PrintFront(queue);
            queue.PrintBack(queue);
            queue.Dequeue(queue);
            queue.PrintQueue(queue);*/

            int[] arr = new int[] { 1, 11, 4, 5, 21, 30, 15, 2, 3 };
            int item = 5;
            Console.WriteLine(BinarySearch(arr, item));
            
            static int BinarySearch(int[] arr, int key)
            {
                int minNum = 0;
                int maxNum = arr.Length - 1;

                while (minNum <= maxNum)
                {
                    int mid = (minNum + maxNum) / 2;
                    if (key == arr[mid])
                    {
                        return ++mid;
                    }
                    else if (key < arr[mid])
                    {
                        maxNum = mid - 1;
                    }
                    else
                    {
                        minNum = mid + 1;
                    }
                }
                return -1;
            }

        }
    }
}
