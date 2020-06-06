using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Schema;

namespace Queue
{
    class Queue<T>
    {
        private Node<T> front;
        private int size;
        public int total;
        public Queue(int size)
        {
            this.size = size;
        }
        public void queue(T data)
        {
            if(total != size)
            {
                Node<T> n = new Node<T>(data);
                if (front == null)
                {
                    front = n;
                }
                else
                {
                    Node<T> aux = front;
                    while(aux.Next != null)
                    {
                        aux = aux.Next;
                    }
                    aux.Next = n;
                }
                total++;
            }
        }
        public void dequeue()
        {
            if (!isEmpty())
            {
                front = front.Next;
                total--;
            }
        }
        public bool isEmpty()
        {
            return total == 0;
        }
        public T FrontValue()
        {
            return front.Value;
        }
    }
}
