using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationApp
{
    class AddTeacher : Command
    {
        protected List<Audience> audiences;

        public AddTeacher(List<Audience> audiences)
        {
            this.audiences = audiences;
        }
        protected override void InternalLogic()
        {
            Console.WriteLine("Enter the name of Teacher");
            string name = Console.ReadLine();
            Teacher teacher = new Teacher(name);
            teacher.IntLogic(audiences);
        }
    }
}
