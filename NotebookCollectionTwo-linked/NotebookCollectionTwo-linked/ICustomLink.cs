using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookCollectionTwo_linked
{
    public interface ICustomLink<Notebook>
    {
        void Add(Notebook value);
        Notebook this[int index] { get; }
        bool Delete(Notebook value);
    }
}
