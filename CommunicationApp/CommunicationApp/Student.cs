using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationApp
{
    class Student : Human
    {
        public Student(string name) : base(name) { }
        
        public override void IntLogic(List<Audience> audiences)
        {
            base.IntLogic(audiences);
        }
    }
}
