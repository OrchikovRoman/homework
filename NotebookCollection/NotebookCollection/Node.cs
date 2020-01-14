using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookCollection
{
    public class Node
    {
        public Node(Notebook element, Node nextElement = null)
        {
            Element = element;
            NextElement = nextElement;
        }
        public Notebook Element { get; private set; }
        public Node NextElement { get; set; }
    }
}
