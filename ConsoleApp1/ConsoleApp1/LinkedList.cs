using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Node
    {
        public Node Next;
        public object Value;
    }
    class LinkedList : DataStructure
    {
        private Node head;
        private Node current;
        public int Count;
        public LinkedList()
        {
            head = new Node();
            current = head;
        }
        public bool Add(object data)
        {
            Node newNode = new Node();
            newNode.Value = data;
            current.Next = newNode;
            current = newNode;
            Count++;
            return true;
        }
        public int Delete()
        {
            if (Count > 0)
            {
                head.Next = head.Next.Next;
                Count--;
            }
            else
            {
                Console.WriteLine("No element exist in this linked list.");
             }
            return 0;
        }

        public void Display()
        {
            //Traverse from head
            Console.Write("Head ->");
            Node curr = head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.Value);
                Console.Write("->");
            }
            Console.Write("NULL");

            Console.ReadKey();
        }

        public bool Add()
        {
            throw new NotImplementedException();
        }
    }

    


}
