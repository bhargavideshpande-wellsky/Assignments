using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INSERTION IN STACK");
            Stack stack = new Stack();
            stack.Add(20);
            stack.Add(10);
            stack.Add(22);
            stack.Add(15);
            stack.Display();
            Console.WriteLine("DELETION OF ELEMENT IN STACK");
            Console.WriteLine("Item popped from Stack : {0}", stack.Delete());
            stack.Display();
           
            Queue queue = new Queue();
            Console.WriteLine("INSERTION IN QUEUE");
            queue.Add(2);
            queue.Add(21);
            queue.Add(10);
            queue.Add(25);
            queue.Display();
            Console.WriteLine("DELETION IN QUEUE");
            Console.WriteLine("Item deleted from Queue : {0}", queue.Delete());
            queue.Display();
            Console.WriteLine("INSERTION IN LINKED LIST");
            LinkedList linkedList = new LinkedList();
            linkedList.Add(11);
            linkedList.Add(12);
            linkedList.Add(55);
            linkedList.Add(54);
            linkedList.Display();
            Console.WriteLine("DELETION IN LINKED LIST");
            linkedList.Delete();
            linkedList.Display();
           

        }
    }
}
