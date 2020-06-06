using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListExmpl
{
    class Node
    {
        public int Value;
        public Node Next;
        Node()
        {
            this.Value = 0;
        }
        public Node(int val)
        {
            this.Value = val;
        }
        public Node(int val, Node next)
        {
            this.Value = val;
            this.Next = next;
        }
    }
}
