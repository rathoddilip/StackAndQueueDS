using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    public class LinkedListStack
    {

        // create global top reference variable 
        Node top;
        public LinkedListStack()
        {
            this.top = null;
        }
        /// <summary>
        /// push operation in stack
        /// </summary>
        /// <param name="newData"></param>
        public void Push(int newData)
        {
            Node newNode = new Node(newData);
                if (this.top != null)
                {
                    newNode.next = this.top;
                }
            this.top = newNode;
            Console.WriteLine($"New Node added to the stack: "+newData);
        }
        public void Display()
        {
            if (top == null)
            {
                Console.Write("stack is empty");
                return;
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {
                    Console.Write("{0}->", temp.data);
                    // assign temp link to temp 
                    temp = temp.next;
                }
            }
        }
    }
}
