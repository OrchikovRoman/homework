using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookCollection
{
    public interface ICustomLink
    {
        void Add(Notebook value);
        Notebook this [int index] { get; }
        bool Delete(Notebook value);
    }
}
