using System;

namespace LinkedListProblem
{
    class Program
    {
        static void Main(string[] args)
        {
           
            LinkedList linklist = new LinkedList();
            linklist.add(56);
            linklist.add(30);
            linklist.add(70);
            Console.Write("total element present is : ");
            linklist.display();
            linklist.Find(30);
           


        }
    }
}
