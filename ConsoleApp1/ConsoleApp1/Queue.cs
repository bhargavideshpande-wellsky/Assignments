using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Queue : DataStructure
    {
        static int max = 100;
        int[] ele = new int[max];
            int front = 0;
            int rear = -1;
           
        

        public bool Add(int item)
        {
            if (rear == max - 1)
            {
                Console.WriteLine("Queue Overflow");
                return false;
            }
            else
            {
                ele[++rear] = item;
                return true;
            }
        }

        public bool Add()
        {
            throw new NotImplementedException();
        }

        public int Delete()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
                Console.WriteLine("deleted element is: " + ele[front]);
                return ele[front++];
            }
        }

        public void  Display ()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine("Item:" + ele[i]);
                    Console.ReadKey();
                }
            }
        }
    }
}
