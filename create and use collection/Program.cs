using System;
using System.Collections;
using System.Collections.Generic;

namespace create_and_use_collection
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            queue.Enqueue("Fourth");

            while (queue.Count > 0)
            {
                object obj = queue.Dequeue();

                Console.WriteLine("From Queue: {0}", obj);
            }

            Stack stacks = new Stack();
            stacks.Push("one");
            stacks.Push("two");
            stacks.Push("three");
            stacks.Push("four");

            while(stacks.Count > 0)
            {
                Object obj = stacks.Pop();
                Console.WriteLine("From stack: {0}", obj);
            }


        }
    }
}
