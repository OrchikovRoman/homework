using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookCollection
{
    public class Program
    {
        static void Main(string[] args)
        {
            var notebookCollection = new CustomList();

            var igor = new Notebook(1, "Igor");
            var vasia = new Notebook(2, "Vasia");
            var kurlik = new Notebook(3, "KYPJIblK");
            notebookCollection.Add(igor);
            notebookCollection.Add(vasia);
            notebookCollection.Add(kurlik);
            
            foreach (var notebook in notebookCollection)
                Console.WriteLine(notebook);

            var pupkin = notebookCollection[2];
            notebookCollection.Delete(pupkin);

            Console.WriteLine("\n========================================\n");
            
            foreach (var note in notebookCollection)
                Console.WriteLine(note);

            Console.ReadKey();
        }
    }
}
