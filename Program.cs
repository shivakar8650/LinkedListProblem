﻿using System;

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
            Console.Write("total element present is : ");
            linkedlist.display();
            linkedlist.RemoveLast();
            Console.Write("total element present after remove : ");
            linkedlist.display();


        }
    }
}
