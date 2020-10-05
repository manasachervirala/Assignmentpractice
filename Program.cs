using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //created an object of stack
            Stack<int> MyStack = new Stack<int>();
            MyStack.Push(2);//push method takes one parameters/arguments
            MyStack.Push(4);
            MyStack.Push(6);
            MyStack.Push(8);
            MyStack.Push(10);
            MyStack.Push(12);
            MyStack.Push(14);
           
            Console.WriteLine("the top element {0}",MyStack.Peek());
            //Console.ReadLine();
            foreach(int stack in MyStack)
            {
                Console.WriteLine("The elements of my stack are is {0}" + stack);
                Console.ReadLine();
            }

            MyStack.Pop();
            MyStack.Pop();
            MyStack.Pop();
            MyStack.Pop();
            MyStack.Pop();
            Console.WriteLine("after 4");
            Console.WriteLine("peek {0}" ,MyStack.Peek());
            foreach(int z in MyStack)
                {
                Console.WriteLine("stack elements {0}", z);
            }
           MyStack .Pop();
            MyStack.Pop();
            foreach(int z in MyStack)
            {
                Console.WriteLine("stack elements {0}", z);
            }

            Console.ReadKey();
            //Console.WriteLine("peek element of the stack is:" + MyStack.Peek());// peek is to find the top most elements on the stack
            //Console.WriteLine("poping the elements of the stack is:" + MyStack.Pop());// pop is to delete the elements in the stack
            //Console.WriteLine("delete the elements in the pop operations" + MyStack.Pop());//
        }
        
    }
}
