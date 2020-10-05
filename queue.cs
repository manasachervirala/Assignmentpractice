using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Queue<int> x = new Queue<int>(); // queue object is created
            x.Enqueue(2);
            x.Enqueue(4);
            x.Enqueue(6);
            x.Enqueue(8);
            x.Enqueue(10);
            x.Enqueue(12);
            x.Enqueue(14);
            x.Enqueue(16);
            x.Enqueue(18);
            x.Enqueue(20);
            


            foreach(int z in x)
            {
                Console.WriteLine("Queue elements entered are: {0}" , z);
            }
            Console.WriteLine("pop elements of the queue is :" + x.Dequeue());
            foreach (int z in x)
            {
                Console.WriteLine("Queue elements entered are: {0}", z);
            }
            Console.WriteLine("pop elements of the queue is :" + x.Dequeue());
            foreach (int z in x)
            {
                Console.WriteLine("Queue elements entered are: {0}", z);
            }
            Console.WriteLine("pop elements of the queue is :" + x.Dequeue());
            foreach (int z in x)
            {
                Console.WriteLine("Queue elements entered are: {0}", z);
            }
            Console.WriteLine("pop elements of the queue is :" + x.Dequeue());
            foreach (int z in x)
            {
                Console.WriteLine("Queue elements entered are: {0}", z);
            }
            Console.WriteLine("pop elements of the queue is :" + x.Dequeue());
            foreach (int z in x)
            {
                Console.WriteLine("Queue elements entered are: {0}", z);
            }
            Console.WriteLine("pop elements of the queue is :" + x.Dequeue());
            foreach (int z in x)
            {
                Console.WriteLine("Queue elements entered are: {0}", z);
            }
            
            Console.WriteLine("peek elemnets of the queue :" + x.Peek());
            Console.WriteLine("elements left in queue are:");
            foreach(int z in x)
            {
                Console.WriteLine("Queue elements entered are: {0}", z);
                //Console.WriteLine("Queue elements entererd are:{ 0}", z);
            }
            Console.WriteLine("the current present elements:" + x.Count());
            Console.ReadKey();
        }
        
    }
}
