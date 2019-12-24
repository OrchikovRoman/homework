using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationApp
{
    class AddStudent : Command
    {
        protected List<Audience> audiences;

        public AddStudent(List<Audience> audiences)
        {
            this.audiences=audiences;
        }
        protected override void InternalLogic()
        {
            Console.WriteLine("Enter the name of Student");
            string name = Console.ReadLine();
            Student student = new Student(name);
            student.IntLogic(audiences);
        }
    }
}
