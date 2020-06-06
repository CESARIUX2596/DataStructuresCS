using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListExmpl
{
    class GenericNode <T>
    {
        public T Value;
        public GenericNode<T> Next;

       public GenericNode(T val)
        {
            this.Value = val;
        }
        public GenericNode(T val, GenericNode<T> next)
        {
            this.Value = val;
            this.Next = next;
        }
    }
}
