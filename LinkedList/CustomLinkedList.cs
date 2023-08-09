using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class CustomLinkedList
    {
        public Node head;
         public void AddLast(int data)
         {

               Node newNode = new Node(data);
               if(head==null)
               {
                    head = newNode;
                   // Console.WriteLine("{0} is inserted at lastNode", newNode.data);
               }
               else
               {
                    Node lastNode = GetLastNode();
                    lastNode.next = newNode;
                    //Console.WriteLine("{0} is inserted at lastNode",newNode.data);        
               }
         }

        private Node GetLastNode()
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;

        }

        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
            Console.WriteLine("{0} is inserted at first", newNode.data);

        }

        public void Display()
        {
            Node temp= head;
            if(head==null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            else
            {
                while(temp!=null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
