using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Stack : DataStructure
    {
        static int MAX = 1000;
        int top=-1;
        int[] stack = new int[MAX];
        public bool Add (int data)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;

            }
            else
            {
                stack[++top] = data;
                return true;
            }
        }

        public bool Add()
        {
            throw new NotImplementedException();
        }

        public int Delete()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack Underflow");
                     return 0;
                }
                else
                {
                    int data = stack[top--];
                     return data;
                }
            }
           public void Display()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack Underflow");
                    return;
                }
                else
                {
                    Console.WriteLine("Elements of Stack are :");
                    for (int i = top; i >= 0; i--)
                    {
                        Console.WriteLine(stack[i]);
                    }
                Console.ReadKey();
            }

            }

     }
}

