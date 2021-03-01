using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class LinkedListStack
    {
        Node top;
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
            Console.WriteLine("New Node added: "+newData);
        }
       
    }
}
