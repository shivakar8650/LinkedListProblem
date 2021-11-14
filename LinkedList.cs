using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProblem
{
    public class LinkedList
    {
        internal Node head;

        internal void  add(int data)
        {
            Node node = new Node(data);
            if(head == null)
            {
               head = node;
            }
            else
            { Node temp = head;
                  while(temp.next != null)
                {
                   temp = temp.next;
                }
                temp.next = node;
            }
            
            Console.WriteLine("added :" + node.data);
        }

        internal void display()
        {
            if (head == null)
            {
                Console.WriteLine("Linked is empty");

            }
            else
            {
                Console.Write("total element presents are: ");
                Node temp = head;
                while (temp != null)
                {
                
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine(" ");
            }
        }
 
        internal void RemoveLast()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Console.WriteLine("last element is removed ");
                Node temp = head;
                Node prev = null;
                while(temp.next != null)
                {
                   prev = temp;
                   temp = temp.next;
                }
                if (prev == null)
                {
                    head = null;
                }
                else
                prev.next = null;
                
            }
        }
    }
}
