using System;

namespace LinkedListProblem
{
    class Program
    {
        static void Main(string[] args)
        {
           
            LinkedList linklist = new LinkedList();
            linklist.add(70);
            linklist.add(56);
            linklist.display();
            linklist.InsertAfter(70,30);
            linklist.display();
         

        }
    }
}
