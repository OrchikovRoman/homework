using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookCollectionTwo_linked
{
    public class Program
    {
        static void Main(string[] args)
        {
            var notebookCollection = new CustomList<Notebook>();

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

            Console.WriteLine("\n========================================\n");
            Console.WriteLine("Two-Linked List:");
            Console.WriteLine("\n========================================\n");

            var notebookCollec = new CustomTwoLinkedList<Notebook>();

            
            notebookCollec.Add(igor);
            notebookCollec.Add(vasia);
            notebookCollec.Add(kurlik);

            foreach (var res in notebookCollec)
                Console.WriteLine(res);

            var Lol = notebookCollec[2];
            notebookCollec.Delete(Lol);

            Console.WriteLine("\n========================================\n");

            foreach (var res in notebookCollection)
                Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
