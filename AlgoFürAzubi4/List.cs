using System;
using System.Collections.Generic;
using System.Text;
namespace AlgoFürAzubi4
{
    public class List<T>
    {
        Node<T> First;
        Node<T> Last;

        public void Add(T value)
        {
            if (First == null)
            {
                var firstNode = new Node<T>(null, value, null);
                Last = firstNode;
                First = firstNode;
                return;
            }
            var add = new Node<T>(First, value, null);
            Last.Next = add;
            Last = add;
        }


        // ADDRINGE Funktion
        public void AddRange(List<T> neo)
        {
            var neuElement = neo.First;

            for (int i = 0; i < neo.Counter(); i++)
            {
                Add(neuElement.data);
                neuElement = neuElement.Next;
            }

        }

        //CLEAR Funktion 
        public void clear()
        {
            if (First == null)
            {
                Console.WriteLine("the list is already clean!");
            }
            else
                First = null;
            Last = null;
        }

        //CONTAINS Funktion
        public bool Contains(T value)
        {
            var element = First.data;
            for (int i = 0; Last.Next == null; i++)
            {

                if (element.Equals(value))
                {
                    return true;
                }
                else return false;
            }
            return false;
        }

        // EXISTS Funktion ??
        //public bool Exists()
        //{
        //    return false;
        //}

        //Find Funktion
        //public T find(T Value)
        //{
        //    for (int i = 0; i < 5 ; i++)
        //    {
        //        return false;
        //    }
        //}


        //FindAll Funktion
        //public T findAll(T Value)
        //{
        //    for (int i = 0; i < 5 ; i++)
        //    {
        //        return false;
        //    }
        //}

        // INDEXOF Finktions
        public int IndexOf(T value)
        {
            int index = 0;
            var zeiger = First;
            while (zeiger != null)
            {

                if (zeiger.data.Equals(value))
                {
                    return index;
                }
                zeiger = zeiger.Next;
                index++;
            }
            return -1;
        }
        //INDEXOF Finktions Ab bestimmten Index
        public int IndexOf(T value, int v)
        {
            int index = v;
            var zeiger = First;
            for (int i = 0; i < v; i++)
            {
                zeiger = zeiger.Next;
            }
            while (zeiger != null)
            {
                if (zeiger.data.Equals(value))
                {
                    return index;
                }
                zeiger = zeiger.Next;
                index++;
            }
            return -1;
        }

        // INSERT Funktion
        public void Insert(T value, int index)
        {
            var zeiger = First;

            for (int i = 1; i < index; i++)
            {
                zeiger = zeiger.Next;
            }
            var vorgänger = zeiger;
            var nachfolger = zeiger.Next;
            var neu = new Node<T>(vorgänger, value, nachfolger);

            vorgänger.Next = neu;
            nachfolger.Prev = neu;
        }

        // REMOVE Funktion

        public void Remove(T value)
        {
            var zeiger = First;

            while (Last != null)
            {
                if (zeiger.data.Equals(value))
                {
                    zeiger.Prev.Next = zeiger.Next;
                    zeiger.Next.Prev = zeiger.Prev;

                    break;
                }

                zeiger = zeiger.Next;


            }

        }

        public int Counter()
        {
            var num = 0;
            var first = First;

            while (first != null)
            {
                num++;
                first = first.Next;
            }
            return num;
        }


        // Ausgabe Funktion 
        public void Display()
        {
            Node<T> Start = First;
            if (Start == null)
            {
                Console.WriteLine("Die Liste ist Leer!");
            }
            else
            {
                while (Start != null)
                {
                    Console.Write(" " + Start.data + " ");
                    Console.Write(" -->  ");

                    Start = Start.Next;
                }
            }
        }
    }
}
