using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookCollectionTwo_linked
{
    public class Node<Notebook> 
    {
        public Node(Notebook element, Node<Notebook> nextElement = null)
        {
            Element = element;
            NextElement = nextElement;
        }
        public Notebook Element { get; private set; }
        public Node<Notebook> NextElement { get; set; }
    }
}
