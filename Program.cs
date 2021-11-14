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
            linklist.display();
            linklist.Find(30);
            linklist.InsertAfter(30,40);
            linklist.display();


        }
    }
}
