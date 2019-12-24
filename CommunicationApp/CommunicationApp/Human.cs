using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationApp
{
    abstract class Human
    {
        public string Name { get; private set; }
        public Human(string Name)
        {
            this.Name = Name;
        }
        public virtual void IntLogic(List<Audience> audiences)
        {
            var command = new Dictionary<ConsoleKey, Audience>()
            {
                [ConsoleKey.D1] = audiences[0],
                [ConsoleKey.D2] = audiences[1],
                [ConsoleKey.D3] = audiences[2],
                [ConsoleKey.D4] = audiences[3]
            };

            Console.WriteLine("Select an audience from the list: 1.A-room, 2.B-room, 3.C-room, 4.D-room");
            var key = Console.ReadKey().Key;
            if (command.ContainsKey(key))
            {
                Console.Clear();
                var select = command[key];
                if (select.human.Count() < select.CountHumans)
                {
                    select.human.Add(this);
                }
                else
                    Console.WriteLine("Tank is full");
                
            }
            else
                Console.Clear();
        }
    }
}
