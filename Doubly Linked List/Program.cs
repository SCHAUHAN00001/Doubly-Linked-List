using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubly_Linked_List
{
    internal class Program
    {
        public class Node
        {
            public int element;
            public Node next;
            public Node prev;
            public Node(int e, Node n , Node p)
            {
                element = e;
                next = n;
                prev = p;
            }

        }
        class Doubly_Linked_list
        {
            private Node head;
            private Node tail;
            private Node prev;
            private int size;
            public Doubly_Linked_list()
            {
                head = null;
                tail = null;
                size = 0;
            }
            public int length()
            {
                return size;
            }
            public bool isEmpty()
            {
                return size == 0;
            }
            public void addLast(int e)
            {
                Node newest = new Node(e,null,null);
                if (isEmpty())
                {
                    head = newest;  
                    tail = newest;
                }
                else
                {
                    tail.next = newest;
                    newest.prev = tail;
                    tail = newest;
                }
                size++;
            }
            public void addFirst(int e) 
            {
                Node newest = new Node(e, null, null);
                if (isEmpty())
                {
                    head = newest;
                    tail = newest;
                }
                else
                {
                    newest.next = head;
                    head.prev = newest;
                    head = newest;
                }
                size++;
                

                
            }
            public void addAnywhere(int e, int position)
            {
                Node newest = new Node(e, null, null);
                Node p = head;
                int i = 1;
                while (i<position-1)
                {
                    p = p.next;
                    i++;

                }
                newest.next = p.next;
                p.next.prev = newest;
                p.next = newest;
                newest.prev = p;
                size++;

            }
            public int removeFirst() 
            {
                if (isEmpty())
                {
                    Console.WriteLine("List is empty");
                    return -1;
                }
                int e = head.element;
                head = head.next;
                head.prev = null;
                size--;
                if (isEmpty())
                {
                    tail = null;
                }
                return e;
            }
            public int removeLast()
            {
                if (isEmpty())
                {
                    Console.WriteLine("List is empty");
                        return -1;
                    
                }
                int e = tail.element;
                tail = tail.prev;
                tail.next = null;
                size--;
                return e;
            }
            public int removeAnywhere(int position)
            {
                Node p = head;
                int i = 1;
                while (i < position - 1)
                {
                    p = p.next;
                    i++;

                } 
                int e = p.next.element; 
                p.next = p.next.next;
                p.next.prev = p;
                size--;
                return e;

            }
            public void display()
            {
                Node p = head;
                while (p != null)
                {
                    Console.WriteLine(p.element);
                    p= p.next;
                }
            }


        }


        static void Main(string[] args)
        {
            Doubly_Linked_list Doubly = new Doubly_Linked_list();
            Console.WriteLine("Creating a Doubly Linked list : ");
            Doubly.addLast(1);
            Doubly.addLast(2);
            Doubly.addLast(3);
            Doubly.addLast(4);
            Doubly.addLast(5);
            Doubly.addLast(6);
            Doubly.display();
            Console.WriteLine("Size --> "+ Doubly.length());
            Console.WriteLine();
            Console.WriteLine("Adding 15 on first position : ");
            Doubly.addFirst(15);
            Doubly.display();
            Console.WriteLine("Size --> " + Doubly.length());
            Console.WriteLine();
            Console.WriteLine("Adding 55 on 5th position");
            Doubly.addAnywhere(55, 5);
            Doubly.display();
            Console.WriteLine("Size --> " + Doubly.length());
            Console.WriteLine();
            Console.WriteLine("Removing element on first position");
            Doubly.removeFirst();
            Doubly.display();
            Console.WriteLine("Size --> " + Doubly.length());
            Console.WriteLine();
            Console.WriteLine("Removing element on Last position");
            Doubly.removeLast();
            Doubly.display();
            Console.WriteLine("Size --> " + Doubly.length());
            Console.WriteLine();
            Console.WriteLine("Removing element on 4th position");
            Doubly.removeAnywhere(4);
            Doubly.display();
            Console.WriteLine("Size --> " + Doubly.length());



            Console.ReadLine();
            

        }
    }
}
