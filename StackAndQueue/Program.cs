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
            linkedListStack.Display();
            Console.ReadLine();
        }
    }
}
