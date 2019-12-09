using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2CLasswork2
{
    class Program
    {
        static void Main(string[] args)
        {
            var personOne = new Person("Roman", 10, "Hands room");
            var personTwo = new Person("Roman Shuvalov", 12, "Legs room");
            PersonsKeeper.Add(personOne);
            PersonsKeeper.Add(personTwo);
            ConsoleStart();
            ConsoleMenu();

            
        }
        private static void ConsoleStart()
        {
            Console.WriteLine("===================WELCOME TO GYM APP!===================");
        } 
        private static void ConsoleMenu()
        {
            while (true)
            {
                Console.WriteLine("\n<Press 1>: Create a new Person\n<Press 2>: Training\n<Press 3>: View list Persons \n<Press 4>: To remove a person\n<Press D>: For clear Console\n<Press 9> double click: <EXIT>\n\n");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine("Enter person name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the number of approaches: ");
                        int count = InputCheck();
                        Console.WriteLine("What are we pumping today? Choose a muscle group:\n1.Hands\n2.Legs\n3.Torso and back");
                        string group = "";
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.D1:
                                group = "Hands room";
                                break;
                            case ConsoleKey.D2:
                                group = "Legs room";
                                break;
                            case ConsoleKey.D3:
                                group = "Torso and back room";
                                break;
                            default:
                                group = "Came for Instagram photos :D";
                                break;
                        }
                        var pers = new Person(name, count, group);
                        PersonsKeeper.Add(pers);
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        PersonsKeeper.Training();
                        
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        PersonsKeeper.PrintAthletesList();
                        break;

                    case ConsoleKey.D4:
                        Console.Clear();
                        Console.WriteLine("Enter the number from the list of the person whom you want to destroy: ");
                        int target = InputCheck();
                        PersonsKeeper.Delete(target);
                        break;

                    case ConsoleKey.D:
                        Console.Clear();
                        break;

                    case ConsoleKey.D9:
                        Environment.Exit(0);
                        break;
                }

                
            }
        }
        static int InputCheck()
        {
            int number;

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Incorrect number, try again");
            }

            return number;
        }
    }
}
