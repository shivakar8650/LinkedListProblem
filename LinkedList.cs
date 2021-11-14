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
                while (temp!= null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine(" ");
            }
        }
     
    
        internal void RemoveFirst(int data)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Console.WriteLine("performed remmove operaion");
                head = head.next;
             }
        }
    }
}
