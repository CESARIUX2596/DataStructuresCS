using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LinkedListExmpl
{
    class LinkedList
    {
        private Node Root;
        public int Lengt
        {
            get { return this.GetLenght(); } //Devolver el tamaño lista
        }

        private int GetLenght()
        {
            int size = 0;
            Node n = Root;

            while (n != null)
            {
                size++;
                n = n.Next;
            }
            return size;
        }
        public void PrintNodes()
        {
            Node n = Root;
            while (n != null)
            {
                Console.WriteLine(n.Value);
                n = n.Next;
            }
        }
        public void AddNode(int val)
        {
            Node n = Root;
            //Caso para una lista nueva (Agregar el root de la lista)
            if(Root == null)
            {
                Root = new Node(val);
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
            n.Next = new Node(val);
        }
        public void FindNode(int val)
        {
            Node n = Root;
            int pos = 0;
            while (n.Next != null)
            {
                if(n.Value == val)
                {
                    Console.WriteLine("Se encontro el Valor: {0} en la posicion: {1}", n.Value, pos);
                    return;
                }
                pos++;
                n = n.Next;
            }
            Console.WriteLine("Nodo no encontrado");
        }
        public void DeleteNode(int val)
        {
            Node n = Root;
            if (Root == null)
            {
                Console.WriteLine("No hay nodos");
                return;
            }
            else if (Root.Value == val)
            {
                Root = Root.Next;
                return;
            }
            while(n.Next != null)
            {
                if(n.Next.Value == val)
                {
                    n.Next = n.Next.Next;
                    Console.WriteLine("Se elimino el nodo{0}", val);
                    return;
                }
                n = n.Next;
            }
            Console.WriteLine("Nodo no encontrado");
        }
        public Node GetNode(int index)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("El indice no es valido");
            }
            Node n = Root;
            int pos = 0;
            
            while(n != null)
            {
                if(pos++ == index)
                {
                    return n;
                }
                n = n.Next;
            }
            return null;
        }
    }
}
