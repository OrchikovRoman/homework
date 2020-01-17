using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookCollectionTwo_linked
{
    public class TwoLinkNode<Notebook> : Node<Notebook> 
    {
        public TwoLinkNode(Notebook element, Node<Notebook> nextElement = null, Node<Notebook> previousElement = null) : base(element,nextElement)
        {
            PreviousElement = previousElement;
        }
        public Node<Notebook> PreviousElement { get; set; }
    }
}
