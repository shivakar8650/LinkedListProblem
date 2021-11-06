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
              Node prev = null;
                  while(temp.next != null)
                {
                  if ((temp.data).CompareTo(data) > 0)
                    {
                        Node tempNode = prev.next;
                        prev.next = node;
                        prev.next.next = tempNode;
                        break;
                    }
                    prev = temp;
                    temp = temp.next;
                }
                if ((temp.data).CompareTo(data) > 0 && temp.next==null && prev != null)
                {
                    node.next = temp;
                   
                        prev.next = node;
                }
                else if ((temp.data).CompareTo(data) > 0 && temp.next == null && prev == null)
                {
                    node.next = head;
                    head.next = node;
                   
                }
                else
                {
                    temp.next = node;
                }

            }
            
            Console.WriteLine("added :" + node.data);
        }
/*
        Node<T> searchedNode = head;
                    //Contain Data of previous Node
                    //while ( Comparer<T>.Default.Compare(temp.data,data) !=0 )
                    while (!searchedNode.data.Equals(specifiedNodeData))
                    {
                        searchedNode = searchedNode.next;
                    }
    Node<T> tempNode = searchedNode.next;
    searchedNode.next = node;
                    searchedNode.next.next = tempNode;*/
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
