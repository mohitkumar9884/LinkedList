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

        public void Append(int data)
        {
            AddLast(data);
        }

        public void InsertBetween(int valueToInsert, int afterValue, int beforeValue)
        {
            Node currentNode = head;

            while (currentNode != null)
            {
                if (currentNode.data == afterValue)
                {
                    Node newNode = new Node(valueToInsert);
                    newNode.next = currentNode.next;
                    currentNode.next = newNode;
                    break;
                }

                currentNode = currentNode.next;
            }
        }

        public void RemoveFirst()
        {
            if(head==null)
            {
                Console.WriteLine("\nLinkedList is empty");
            }
            else
            {
                Console.WriteLine("\n{0} is removed from linkedList",head.data);
                head=head.next;
            }
        }

        public void Display()
        {
            Console.WriteLine("\nDisplaying nodes");
           
            Node temp= head;
            if(head==null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            else
            {
                while(temp!=null)
                {
                    Console.Write(temp.data+" ");
                    Console.WriteLine(" ");
                    temp = temp.next;
                }
            }
        }

        public void RemoveLast()
        {
            Node temp= head;
            if(head==null)
            {
                Console.WriteLine("No nodes are present");
            }
            else if (head.next==null)
            {
                head = null;
            }
            else
            {
                while(temp.next.next!=null)
                {
                    temp= temp.next;
                }
                Console.WriteLine(" ");
                Console.WriteLine("{0} is removed  from last",temp.next.data);
                temp.next = null;
            }
        }
        public void Search(int input)
        {
            bool isFound= false;
            Node temp= head;
            if (temp!=null)
            {
                while (temp!=null)
                {
                    if (temp.data==input)
                    {
                        isFound= true;
                        Console.WriteLine("{0} Node is Found", temp.data);
                    }
                    else
                    {
                        temp = temp.next;
                    }
                }
                if (!isFound)
                    Console.WriteLine("{0} Node is found", input);
            }
            else
            {
                Console.WriteLine("Linkedlist is Empty");
            }
        }
    }
}
