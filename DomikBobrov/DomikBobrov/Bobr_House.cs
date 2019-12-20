using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomikBobrov
{
    class Bobr_House
    {
        public Bobr_House()
        {
            Bobrs = new List<Bobr>();
            Trash = new List<object>();
            BobrsTrash = new List<BobrTrash>();
        }
        static List<Bobr> Bobrs;
        static List<object> Trash;
        static List<BobrTrash> BobrsTrash;

        public static void BobrAdd(Bobr bobr)
        {
            Bobrs.Add(bobr);
        }
        public static void TrashAdd(object obj)
        {
            Trash.Add(obj);
        }

        public static void GetTrash(BobrTrash bobrTrash)
        {
            if (true)
            {
                BobrsTrash.Add(bobrTrash);
            }
            else
                throw new Exception("This trash taken other Beaver");
        }
        public static void PrintBobrTrashList()
        {
            Console.WriteLine($"\nTotal number of items in the collection: {BobrsTrash.Count}\n");
            foreach (var com in BobrsTrash)
            {
                Console.WriteLine($"Bober {com.Bober} taked {com.ObjTrash}");
            }
        }
    }
}
