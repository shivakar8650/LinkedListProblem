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
            linkedlist.add(70);
            linkedlist.display();
            linkedlist.RemoveLast();
            linkedlist.display();


        }
    }
}
