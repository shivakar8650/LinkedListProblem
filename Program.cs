using System;

namespace LinkedListProblem
{
    class Program
    {
        static void Main(string[] args)
        {
           
            LinkedList linkedlist = new LinkedList();
            linkedlist.add(56);
            linkedlist.add(30);
            linkedlist.add(40);
            linkedlist.add(70);
            Console.Write("before Sorting :");
            linkedlist.display();
            linkedlist.Sort();
            Console.Write("after Sorting :");
            linkedlist.display();
           

        }
    }
}
