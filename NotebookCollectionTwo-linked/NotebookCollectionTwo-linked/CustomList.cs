using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookCollectionTwo_linked
{
    public class CustomList<Notebook> : IEnumerable<Notebook>, ICustomLink<Notebook>
    {

        public Node<Notebook> Head { get; set; }
        public Node<Notebook> Tail { get; set; }

        public int count;

        public virtual Notebook this[int index]
        {
            get
            {
                Node<Notebook> current = Head;

                if (index < 0) throw new IndexOutOfRangeException();
                if (current == null) throw new NotImplementedException();
                for (int i = 1; i < index; i++)
                {
                    current = current.NextElement;
                }
                return current.Element;
            }
        }


        public virtual void Add(Notebook value)
        {
            Node<Notebook> node = new Node<Notebook>(value);

            if (Head == null)
                Head = node;
            else
                Tail.NextElement = node;
            Tail = node;

            count++;
        }

        public virtual bool Delete(Notebook value)
        {
            Node<Notebook> current = Head;
            Node<Notebook> previous = null;

            while (current != null)
            {
                if (current.Element.Equals(value))
                {
                    if (previous != null)
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



        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<Notebook> IEnumerable<Notebook>.GetEnumerator()
        {
            Node<Notebook> current = Head;
            while (current != null)
            {
                yield return current.Element;
                current = current.NextElement;
            }
        }

       
    }
}
