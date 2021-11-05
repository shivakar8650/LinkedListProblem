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
                while (temp.next != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.Write(temp.data + " ");
                Console.WriteLine(" ");
            }
        }


        internal void Remove(int data)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Node temp = head;
                Node prev = null;
                while (!temp.data.Equals(data))  
                {
                    prev = temp;
                    temp = temp.next;
                }
                prev.next = temp.next;
            }
        }
        internal void FindSize()
        {
            if(head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                int count = 1;
                Node temp = head;
                while( temp.next != null)
                {
                    temp = temp.next;
                    count++;
                }
                Console.WriteLine("the size of list is " + count);
            }
        }
    }
}
