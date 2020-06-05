using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListExmpl
{
    class GenericLinkedList<T>
       
    {
        private GenericNode<T> Root;
        public int Lenght
        {
            get { return this.GetLenght(); }
        }
        private int GetLenght()
        {
            int size = 0;
            GenericNode<T> n = Root;
            while(n != null)
            {
                size++;
                n = n.Next;
            }
            return size;
        }
        public void PrintNodes()
        {
            GenericNode<T> n = Root;
            while (n != null)
            {
                Console.WriteLine(n.Value);
                n = n.Next;
            }
        }
        public void AddNode(T val)
        {
            GenericNode<T> n = Root;
            //Caso para una lista nueva (Agregar el root de la lista)
            if (Root == null)
            {
                Root = new GenericNode<T>(val);
                return;
            }
            // Agregar un valor despues del root
            // N1 =0 -> N2=1 -> *N3=2* - null!
            while (n.Next != null)
            {
                //Buscar ultimo nodo de la lista
                n = n.Next;
            }
            //Creamos N4
            // N3 -> N4 -> null
            n.Next = new GenericNode<T>(val);
        }
        public void FindNode(T val)
        {
            GenericNode<T> n = Root;
            int pos = 0;
            while (n.Next != null)
            {
                //if (n.Value == val)
                //if(IEqualityComparer())
                if(IEqualityComparer<T>.ReferenceEquals(n.Value, val))
                {
                    Console.WriteLine("Se encontro el Valor: {0} en la posicion: {1}", n.Value, pos);
                    return;
                }
                pos++;
            }
            Console.WriteLine("Nodo no encontrado");
        }
        public void DeleteNode(int val)
        {
            GenericNode<T> n = Root;
            if (Root == null)
            {
                Console.WriteLine("No hay nodos");
                return;
            }
            else if (IEqualityComparer<T>.ReferenceEquals(n.Value, val))
            {
                Root = Root.Next;
                return;
            }
            while (n.Next != null)
            {
                if (IEqualityComparer<T>.ReferenceEquals(n.Value, val))
                {
                    n.Next = n.Next.Next;
                    Console.WriteLine("Se elimino el nodo{0}", val);
                    return;
                }
                n = n.Next;
            }
            Console.WriteLine("Nodo no encontrado");
        }
        public GenericNode<T> GetNode(int index)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("El indice no es valido");
            }
            GenericNode<T> n = Root;
            int pos = 0;

            while (n != null)
            {
                if (pos++ == index)
                {
                    return n;
                }
                n = n.Next;
            }
            return null;
        }
    }
}
//if(IEqualityComparer<T>.ReferenceEquals(n.Value, val))