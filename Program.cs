﻿using System;

namespace LinkedListProblem
{
    class Program
    {
        static void Main(string[] args)
        {
           
            LinkedList linkedlist = new LinkedList();
            linkedlist.add(70);
            linkedlist.add(56);
            linkedlist.display();
            linkedlist.InsertAfter(70,30);
            linkedlist.display();
         

        }
    }
}
