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
            {
                Node temp = head;
                Node prev = temp;
                int checklast = 0;
                if (temp.next == null)
                {
                    if ((temp.data).CompareTo(data) > 0)
                    head =addFirst(temp, node);
                    else
                        addLast(temp, node);
                    checklast = 1;
                }
                while (temp.next != null)
                {
                    if ((temp.data).CompareTo(data) > 0)
                    {
                        InsertAfter(prev.data, data);
                        checklast = 1;
                    }
                    prev = temp;
                    temp = temp.next;

                }
                if (checklast == 0)
                {
                    if ((temp.data).CompareTo(data) > 0)
                        InsertAfter(prev.data, data);
                    else
                        addLast(temp, node);
                }
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
        internal Node addFirst(Node temp, Node node)
        {
            node.next = temp;
            return node;
        }

        internal void addLast(Node temp, Node node)
        {
            temp.next = node;
        }
      
        internal void InsertAfter(int specifiedNodeData, int data)
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
                searchedNode.next.next = tempNode;
            }
        }
       


        }
    }





/*
Node temp = head;
Node prev = temp;
int checklast = 0;
while (temp != null)
{
    if ((temp.data).CompareTo(data) > 0 && temp.next == null)
    {
        head = addFirst(temp, node);
        checklast = 1;
    }
    else if ((temp.data).CompareTo(data) > 0)
    {
        InsertAfter(prev.data, data);
        checklast = 1;
    }
    prev = temp;
    temp = temp.next;

}
if (checklast == 0)
{
    addLast(prev, node);
}*/

/*public void Sort()
{
    Node<T> prev = this.head, curr = null;
    T temp;
    if (this.head == null)
    {
        return;
    }
    else
    {
        while (prev != null)
        {
            curr = prev.Next;
            while (curr != null)
            {
                if (prev.data.CompareTo(curr.data) > 0)
                {
                    temp = prev.data;
                    prev.data = curr.data;
                    curr.data = temp;
                }
                curr = curr.Next;
            }
            prev = prev.Next;
        }
    }
}*/