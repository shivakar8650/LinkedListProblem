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
       /* internal void append(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                head = node;
                head.next = temp;


                Console.WriteLine("append :" + node.data);
            }
        }*/
      /*  internal void InsertAfter(int  specifiedNodeData,int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node searchedNode = head;
                
                while (!searchedNode.data.Equals(specifiedNodeData))
                {   
                    searchedNode = searchedNode.next;
                }
                Node tempNode = searchedNode.next;
                searchedNode.next = node;
                searchedNode.next= tempNode;
            }
        }*/
        internal void RemoveFirst(int data)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
               
                head = head.next;

            }
        }
    }
}
