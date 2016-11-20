using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class MyLinkedList<T>
    {
        Node<T> start = null;
        Node<T> end = null;

        //Overriding the ToString for My list 
        public override string ToString()
        {
            Node<T> tmp = start;
            StringBuilder sb = new StringBuilder();
            while (tmp != null)
            {
                sb.Append(tmp.data.ToString() + "\n");
                tmp = tmp.next;
            }

            return sb.ToString();
        }

        public int Search(T value)
        {
            if (start == null)
            {
                return -1;
            }

            Node<T> nTmp = start;
            int index = 0;

            while (nTmp != null)
            {
                if (nTmp.data.Equals(value))
                {
                    return index;
                }

                index++;
                nTmp = nTmp.next;
            }
            return -1;
        }

        public T SearchT(T value)
        {
            Node<T> nTmp = start;

            while (nTmp != null)
            {
                if (value.Equals(nTmp.data))
                {
                    return nTmp.data;
                }

                nTmp = nTmp.next;
            }
            return default(T);
        }

        //Append to the end of the dual bunded list
        public void Append(T val)
        {
            //if ((start == end) && (start == null))
            if (start == null)
            {
                Add2Start(val);
                end = start;
            }
            else
            {
                Node<T> nAppend = new Node<T>(val);
                nAppend.prev = end;
                end.next = nAppend;
                end = nAppend;
            }
        }

        //Remove the last Node from the list, still save the last Node for furure using if needed
        public bool RemoveFromEnd(out T tmpData)
        {
            if (end == null)
            {
                tmpData = default(T);
                return false;
            }
            else
            {
                tmpData = end.data;
                end = end.prev;
                end.next = null;
                if(end == null)
                {
                    end = start = null;
                }
                return true;
            }
        }

        public bool RemoveFromStart(out T tmpDdata)
        {
            if (start == null)
            {
                tmpDdata = default(T);
                return false;
            }
            else
            {
                tmpDdata = start.data;
                start = start.next;
                if (start == null)
                {
                    end = start;
                }
                return true;
            }
        }

        public void Add2Start(T val)
        {
            Node<T> n = new Node<T>(val);
            n.next = start;
            start = n;
            if ((end == start) || (end == null))
            {
                end = n;
            }
        }

        public void PrintAll()
        {
            Node<T> tmp = start;
            while (tmp != null)
            {
                Console.WriteLine(tmp.data);
                tmp = tmp.next;
            }
        }

        class Node<T>
        {
            public T data;
            public Node<T> next;
            public Node<T> prev;

            public Node(T data)
            {
                this.data = data;
            }
        }
    }
}
