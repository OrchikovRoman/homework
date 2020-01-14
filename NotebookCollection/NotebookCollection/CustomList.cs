using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookCollection
{
    public class CustomList : IEnumerable, ICustomLink
    {

        public Node Head { get; private set; }
        public Node Tail { get; private set; }
        int count;

        public Notebook this[int index] 
        {
            get
            {
                Node current = Head;

                if (index < 0) throw new IndexOutOfRangeException();
                if (current == null) throw new NotImplementedException();
                for (int i = 1; i < index; i++)
                {
                    current = current.NextElement;
                }
                return current.Element;
            }
        }
            

        public void Add(Notebook value)
        {
            Node node = new Node(value);

            if (Head == null)
                Head = node;
            else
                Tail.NextElement = node;
            Tail = node;

            count++;
        }

        public bool Delete(Notebook value)
        {
            Node current = Head;
            Node previous = null;

            while (current !=null)
            {
                if (current.Element.Equals(value))
                {
                    if (previous !=null)
                    {
                        previous.NextElement = current.NextElement;
                        if (current.NextElement == null)
                            Tail = previous;
                    }
                    else
                    {
                        Head = Head.NextElement;
                        if (Head == null)
                            Tail = null;
                    }
                    count--;
                    return true;
                }
                previous = current;
                current = current.NextElement;
            }
            return false;
        }


        public IEnumerator GetEnumerator()
        {
            Node current = Head;
            while (current != null)
            {
                yield return current.Element;
                current = current.NextElement;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }



        //public class CustomListIEnumerator : IEnumerator
        //{
        //    public object Current => throw new NotImplementedException();

        //    public bool MoveNext()
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void Reset()
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
    }
}
