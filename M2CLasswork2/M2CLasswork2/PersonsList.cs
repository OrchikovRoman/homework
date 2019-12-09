using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2CLasswork2
{
    public static class PersonsKeeper
    {
        public static List<Person> AthletesList = new List<Person>();

        public static void Add(Person person)
        {
            AthletesList.Add(person);
        }
        public static void Delete(int target)
        {
            for (int i = 0; i < AthletesList.Count; i++)
            {
                if (i + 1 == target)
                {
                    AthletesList.RemoveAt(i);
                }
            }
        }
        public static void Training()
        {
            foreach (var athlete in AthletesList)
            {
                if (athlete.count != 0)
                {
                    for (int i = 0; i < athlete.count; i++)
                    {
                        if (athlete.count > 0)
                        {
                            int count = athlete.count--;
                            Console.WriteLine($"{athlete.name} now in {athlete.group}, Approaches left: {count}, Receptionist Masha: \"For a long time: (\"");
                        }
                        else 
                        {
                            Console.WriteLine($"{athlete.name} finished :D");
                        }
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("The gym is empty :(");
                }

            }
        }
        public static void PrintAthletesList()
        {
            Console.WriteLine($"\nTotal number of items in the collection: {AthletesList.Count}\n");
            foreach (var athlete in AthletesList)
            {
                Console.WriteLine(athlete);
            }
        }
    }
}
