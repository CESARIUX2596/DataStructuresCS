using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkedListGeneric
{
    class GenericDoubleLinkedList<T>
        //T representa un tipo generico
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
        public void AddNode(T val) 
        {
            //Caso en que la lista se encuentre vacia
            GenericNode<T> n = Root;
            if(Root == null)
            {
                Root = new GenericNode<T>(val);
                return;
            }
            //Caso en que existan elementos en la lista;
            while(n.Next != null)
            {
                n = n.Next;
            }
            n.Next = new GenericNode<T>(val);
            n.Next.Prev = n;
        }
        public void PrintNodes()
        {
            GenericNode<T> n = Root;
            while(n != null)
            {
                Console.WriteLine(n.Val);
                //Incrementa el valor de N para que no sea un ciclo infinito
                n = n.Next;
            }
        }
        public void DeleteNode(T val)
        {
            GenericNode<T> n = Root;
            if (Root == null)
            {
                Console.WriteLine("No hay nodos");
                return;
            }
            //Caso para borrar la raiz de la lista
            /* IComparable<T>.Equals(Root,val) es equivalente a  (Root == val)
             * Al utilizar genericos no nos permite compararr de manera simple
             */
            else if (IComparable<T>.Equals(Root,val)) 
            {
                Root = Root.Next;
                Root.Prev = null;
                return;
            }
            //Caso para borrar cualquier elemento
            while(n.Next != null)
            {
                if(IComparable<T>.Equals(n.Next.Val, val))
                {
                    n.Next = n.Next.Next;
                    if(n.Next == null)
                    {
                        return;
                    }
                    n.Next.Prev = n;
                }
                n = n.Next;
            }
            Console.WriteLine("No se encontro un nodo");
        }
        //Busca por indice
        public GenericNode<T> GetNode(int index)
        {
            if(index < 0)
            {
                //Se requiere el exception por que no podemos salir de la fn!
                throw new IndexOutOfRangeException("El indice no es valido");
            }
            GenericNode<T> n = Root;
            int pos = 0;
            while(n != null)
            {
                 //Es igual a sumar 1
                if(pos++ == index)
                {
                    return n;
                }
                n = n.Next;
            }
            return null;
        }
        //Busca por Contenido
        public void FindNode(T val)
        {
            GenericNode<T> n = Root;
            int pos = 0;
            while(n.Next != null)
            {
                if(IComparable<T>.Equals(n.Val, val))
                {
                    Console.WriteLine("Se encontro el valor {0}, en la posicion: {1}", n.Val, pos );
                    return;
                }
                pos++;
                n = n.Next;
            }
            Console.WriteLine("No se encontro el valor");
        }
        //Agregando valor antes de la raiz
        public void Shift(T val)
        {
            Root.Prev = new GenericNode<T>(val);
            Root.Prev.Next = Root;
        }
        //Mover la raiz de lugar
        public void UnShift() 
        {
            Root = Root.Next;
            Root.Prev = null;
        }
        //Push siempre agrega al final
        public void Push(T val)
        {
            this.AddNode(val);
        }
        //Elimina el ultimo elemento
        public void Pop()
        {
            GenericNode<T> n = Root;
            while(n.Next != null)
            {
                if(n.Next == null)
                {
                    n.Prev.Next = null;
                    this.DeleteNode(n.Next.Val);
                    return;
                }
                n = n.Next;
            }
            Console.WriteLine("Se ha eliminado el último nodo");
        }
            
    }
}
