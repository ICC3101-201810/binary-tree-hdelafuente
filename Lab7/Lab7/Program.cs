using System;

namespace Lab7
{
    class Program
    {
        class Node<T>
        {
            private T info;
            private Node<T> nodo_padre;
            private Node<T> nodo_izquierdo;
            private Node<T> nodo_derecho;

            public Node()
            {
                info = default(T);
                nodo_izquierdo = null;
                nodo_derecho = null;
            }
            public Node(T Info, Node<T> Padre)
            {
                info = Info;
                nodo_padre = Padre;
                nodo_izquierdo = null;
                nodo_derecho = null;
            }

            public T InfoNodo()
            {
                return this.info;
            }
            public Node<T> HijoIzquierdo()
            {
                return nodo_izquierdo;
            }
            public Node<T> HijoDerecho()
            {
                return nodo_derecho;
            }

            //asiganrle nodos hijo al nodo actual 
            public void AgregarDerecha(Node<T> _node)
            {
                nodo_derecho = _node;
            }
            public void AgregarIzquierda(Node<T> _node)
            {
                nodo_izquierdo = _node;
            }



        }
        public static void Main()
        {

        }

    }
}
