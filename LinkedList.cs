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
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine(" ");
            }
        }
      
   
        internal void Find(int data)
        {
            if(head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Node temp = head;
                while(temp != null && !temp.data.Equals(data))
                {
                    temp = temp.next;
                }
                if ( temp != null)
                    Console.WriteLine(data+" element is found");
                else
                   Console.WriteLine("element not found");


            }
        }
    }
}
