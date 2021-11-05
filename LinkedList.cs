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
       /* internal void RemoveLast()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Node temp = head;
                Node prev = null;
                while(temp.next != null)
                {
                    prev = temp;
                    temp = temp.next;
                }
                prev.next = temp.next;
            }
        }*/
        internal void Find(int data)
        {
            if(head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Node temp = head;
                while(!temp.data.Equals(data) && temp.next != null)
                {
                    temp = temp.next;
                }
                if (!temp.data.Equals(data) && temp.next == null)
                    Console.WriteLine("element not found");
                else
                    Console.WriteLine("element is found");

                        
            }
        }
    }
}
