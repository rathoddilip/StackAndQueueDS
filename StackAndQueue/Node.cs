﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
   public class Node
    {
        public int data;
        public Node next;
        public Node front, rear;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
       

    }
}
