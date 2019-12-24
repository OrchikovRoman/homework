using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationApp
{
    class Program
    {
        private static List<Audience> AudiencesList = new List<Audience>();
        public static bool isMenu = true;
        static void Main(string[] args)
        {
            Admin admin = new Admin();
            Audience ARoom = new Audience();
            AudiencesList.Add(ARoom);
            Audience BRoom = new Audience();
            AudiencesList.Add(BRoom);
            Audience CRoom = new Audience();
            AudiencesList.Add(CRoom);
            Audience DRoom = new Audience();
            AudiencesList.Add(DRoom);

            var commands = new Dictionary<ConsoleKey, ICommand>()
            {
                [ConsoleKey.D1] = new ShowAll(AudiencesList),
                [ConsoleKey.D2] = new IndicateQuantity(AudiencesList, admin),
                [ConsoleKey.D3] = new AddStudent(AudiencesList),
                [ConsoleKey.D4] = new AddTeacher(AudiencesList),
                [ConsoleKey.Escape] = new Exit()
            };

            while(isMenu)
            {
                Console.WriteLine("<Press 1>: Show all audience\n<Press 2> Used admin for dirty purposes\n<Press 3> Add new Student\n<Press 4> Add new Teacher\n<Press ESC> For Exit");
                var key = Console.ReadKey().Key;

                if (commands.ContainsKey(key))
                {
                    Console.Clear();
                    var selectCommand = commands[key];
                    selectCommand.Act();
                }
                else
                {
                    Console.Clear();
                }
            }
        }

    }
}
