#region Stack implementation using Linked list

using System;
using System.Collections.Generic;

namespace Stack_Implementation
{
    class LinkedlistSatck<t>
    {
        LinkedList<t> list;
        public LinkedlistSatck()
        {
            list = new LinkedList<t>();
        }
        public void Push(t item)
        {
            list.AddLast(item);
        }
        public t Pop()
        {
            t item = list.Last.Value;
            list.RemoveLast();
            return item;
        }

        public t Peek()
        {
            return list.Last.Value;
        }
        public int Count { get { return list.Count; } }

    }
    class Program
    {
        static void Main(string[] args)
        {
            LinkedlistSatck<int> list = new LinkedlistSatck<int>();
            list.Push(100);
            list.Push(200);
            list.Push(300);
            list.Push(400);


            Console.WriteLine($"Count: {list.Count}");
            while (list.Count > 0)
            {
                Console.WriteLine(list.Pop());
            }

        }
    }
}

#endregion

#region Stack implementation using Arraylist

using System;
using System.Collections;

namespace First
{
    class Stack
    {
        int top = -1;
        ArrayList stackarr;
        public Stack()
        {
            stackarr = new ArrayList();
        }

        //Add new item in the top
        public void Push(int value)
        {
            stackarr.Add(value);
            top++;
        }

        //return top item in stack and delete it
        public object Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("\nStack is empty");
                return null;
            }
            else
            {
                object value = stackarr[top--];
                return value;
            }
        }

        //return top item in stack without delete it
        public object Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                return stackarr[top]; //using indexer to return my value
            }
        }
        public void Print()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack has no items");
            }
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine($"{stackarr[i]}");
            }

        }
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Peek();
            stack.Pop();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Print();
            Console.WriteLine($"Item was Poded: {stack.Pop()}");
            stack.Print();
            Console.WriteLine("Stack Peek: " + stack.Peek());

        }
    }
}

#endregion

#region Stack implementation using array

using System;
using System.Collections;

namespace First
{
    class Stack
    {
        int top = -1;
        int[] stackarr;
        public Stack()
        {
            stackarr = new int[50];
        }

        //Add new item in the top
        public void Push(int value)
        {
            if (top > 50)
            
                Console.WriteLine("Stack ovreflow!");
            
            else
                stackarr[++top] = value;
        }

        //return top item in stack and delete it
        public int? Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("\nStack is empty");
                return null;
            }
            else
            {
                int value = stackarr[top];
                stackarr[top] = 0;
                top--;
                return value;
            }
        }

        //return top item in stack without delete it
        public int Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                return stackarr[top]; //using indexer to return my value
            }
        }
        public void Print()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack has no items");
            }
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine($"{stackarr[i]}");
            }
        }

        public bool Contain(int value)
        {
            for (int i = 0; i < stackarr.Length; i++)
            {
                if (stackarr[i]==value)
                {
                    return true;
                }
            }

            return false;
        }
        static void Main(string[] args)
        {

            Stack stack = new Stack();
            stack.Peek();
            stack.Pop();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Print();
            Console.WriteLine($"Item was Poded: {stack.Pop()}");
            stack.Print();
            Console.WriteLine("Stack Peek: " + stack.Peek());
            Console.WriteLine("Stack contain:  " + stack.Contain(5));

        }
    }
}
#endregion
