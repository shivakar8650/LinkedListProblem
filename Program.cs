using System;

namespace LinkedListProblem
{
    class Program
    {
        static void Main(string[] args)
        {
           
            LinkedList linkedlist = new LinkedList();
            linkedlist.Add(70);
            linkedlist.AddFirst(30);
            linkedlist.AddFirst(56);
            Console.Write("total element present is : ");
            linkedlist.display();
          
        }
    }
}
