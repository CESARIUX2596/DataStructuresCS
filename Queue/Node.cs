using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    class Node<T>
    {
        public T Value;
        public Node<T> Next;
        public Node(T val)
        {
            this.Value = val;
        }
    }
}
