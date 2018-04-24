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
                nodo_padre = null;
                nodo_izquierdo = null;
                nodo_derecho = null;
            }
            public Node(T Info)
            {
                info = Info;
                nodo_padre = null;
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
            public Node<T> NodoPadre()
            {
                return this.nodo_padre;
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
            Inicio:
            Node<int> arbol1 = new Node<int>(1);
            Console.Write("1.Ver Info del nodo\n2.Ver nodos hijos\n3.Agregar nodo hijo\n Opcion:");
            int des = Convert.ToInt32(Console.ReadLine());
            if (des == 1) {Console.WriteLine(arbol1.InfoNodo()); goto Inicio;}
            else if (des == 2) {}


            Console.ReadKey();

        }

    }
}
