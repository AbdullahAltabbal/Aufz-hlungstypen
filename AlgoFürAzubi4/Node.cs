using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFürAzubi4
{
    public class Node<T>
    {        
        public T data;
        public Node<T> Next;
        public Node<T> Prev;
        public Node(Node<T> prev, T date, Node<T> next)
        {
            data = date;
            Next = next;
            Prev = prev;
        }
    }

}

    

