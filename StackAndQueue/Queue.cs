using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
   public class Queue
    {
        public Node front, rear;

        public Queue()
        {
            this.front = this.rear = null;
        }
        public void Enqueue(int newData)
        {
            Node newNode = new Node(newData);

            if (this.rear == null)
            {
                this.front = this.rear = newNode;
                Console.WriteLine("Added node to queue: "+ newData);

                return;
            }
            // Add the new node at the end of queue and change rear 
            this.rear.next = newNode;
            this.rear = newNode;
            Console.WriteLine("Added node to queue: "+newData);
        }
        public void Dequeue()
        {
            // If queue is empty, return NULL. 
            if (this.front == null)
                return;
            Node temp = this.front;
            this.front = this.front.next;
            if (this.front == null)
                this.rear = null;
            
    }
}

