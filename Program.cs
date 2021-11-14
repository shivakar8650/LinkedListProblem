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
            linklist.add(40);
            linklist.add(70);
            linklist.display();
            linklist.Find(40);
            linklist.Remove(40);
            linklist.display();
            linklist.Size();
        }
    }
}
