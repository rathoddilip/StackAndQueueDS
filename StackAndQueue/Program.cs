using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue Operations");
            LinkedListStack linkedListStack = new LinkedListStack();
            //UC-1
            Console.WriteLine("Pushing nodes in stack");
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            //UC-2
            Console.WriteLine("Peek node");
            linkedListStack.peek();
            Console.WriteLine("Poping node from stack");
            linkedListStack.Pop();
            //UC3
            Console.WriteLine();
            Console.WriteLine("Queue Operation");
            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            Console.ReadLine();
           
        }
    }
}
