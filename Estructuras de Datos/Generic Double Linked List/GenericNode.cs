using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkedListGeneric
{
    class GenericNode<T>
    // type = int, type = class, type =s tring
    {
        /*Propiedades
        T hace referencia a que es generico y puede
        aceptar caulquir tipo de dato
        */
        public T Val;
        public GenericNode<T> Next;
        public GenericNode<T> Prev;

        public GenericNode(T val)
        {
            this.Val = val;
        }
        public GenericNode(T val, GenericNode<T> node)
        {
            this.Val = val;
            this.Next = node;
            node.Prev = this;
        }
    }
}
