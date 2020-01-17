using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookCollectionTwo_linked
{
    public class CustomTwoLinkedList<Notebook> : CustomList<Notebook> 
    {
        public Node<Notebook> PreviousTail { get; private set; }

        public override Notebook this[int index] => base[index];

        public override void Add(Notebook value)
        {
            base.Add(value);
            TwoLinkNode<Notebook> node = new TwoLinkNode<Notebook>(value);
            if (PreviousTail == null)
                node.PreviousElement = Head;
            node.PreviousElement = node.PreviousElement.NextElement;
        }
        
        public override bool Delete(Notebook value)
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
    }
}
