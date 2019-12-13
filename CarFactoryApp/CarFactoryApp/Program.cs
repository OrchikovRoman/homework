using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactoryLibrary;

namespace CarFactoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            CreateRandomDetail randomDetail = new CreateRandomDetail();
            bool isMenu = true;

            var commands = new Dictionary<ConsoleKey, ICommand>
            {
                [ConsoleKey.D1] = new CreateCarCommand(factory, randomDetail),
                [ConsoleKey.D2] = new CreatDetailsCommand(randomDetail),
                [ConsoleKey.D3] = new PrintListCommand(factory),
            };
            while (isMenu)
            {
                Console.WriteLine("<Press 1>: Create Car\n<Press 2>: Create Random Details\n<Press 3>: Show list of complete cars\n<Press Escape>: Exit");
                var key = Console.ReadKey().Key;

                if (!commands.ContainsKey(key))
                {
                    break;
                }
                var selectCommand = commands[key];
                selectCommand.Act();
            }
        }
    }
}
