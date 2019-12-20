using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomikBobrov
{
    class Program
    {
        static void Main(string[] args)
        {
            Bobr_House bobr_House = new Bobr_House();
            ConsoleMenu();
        }

        private static void ConsoleMenu()
        {
            while (true)
            {
                
                Console.WriteLine("\n<Press 1>: Show Trash and Bobrs\n<Press 2>: Take Trash\n<Press D>: For clear Console\n<Press 9> double click: <EXIT>\n\n");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Bobr_House.PrintBobrTrashList();
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("Choose the right beaver:\n1.Leha\n2.Vasia\n3.Eugene\n4.Other");
                        string nameBobr = "";
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.D1:
                                nameBobr = "Leha";
                                break;
                            case ConsoleKey.D2:
                                nameBobr = "Vasia";
                                break;
                            case ConsoleKey.D3:
                                nameBobr = "Eugene";
                                break;
                            default:
                                nameBobr = "Outist";
                                break;
                        }
                        Console.Clear();
                        Console.WriteLine("What you need to take in your hands?:\n1.Pistol\n2.Unicorn\n3.Java\n4.Apple\n5.Other");
                        object trsh = "";
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.D1:
                                trsh = "Pistol";
                                break;
                            case ConsoleKey.D2:
                                trsh = "Unicorn";
                                break;
                            case ConsoleKey.D3:
                                trsh = "Java";
                                break;
                            case ConsoleKey.D4:
                                trsh = "Apple";
                                break;
                            default:
                                trsh = "Brain :D";
                                break;
                        }
                        Bobr bobr = new Bobr(nameBobr);
                        Bobr_House.BobrAdd(bobr);
                        Bobr_House.TrashAdd(trsh);

                        var newBobrTrash = new BobrTrash(bobr, trsh);
                        Bobr_House.GetTrash(newBobrTrash);
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
    }
}
