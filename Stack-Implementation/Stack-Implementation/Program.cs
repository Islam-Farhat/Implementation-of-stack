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
            while (list.Count>0)
            {
                Console.WriteLine(list.Pop());
            }

        }
    }
}
