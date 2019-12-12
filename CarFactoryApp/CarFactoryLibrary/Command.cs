using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary
{
    public class Command : ICommand
    {
        public virtual string Name { get; set; }

        public void Act()
        {
            InternalLogic();
        }
        public virtual void InternalLogic()
        {
            Console.WriteLine("Base Command");
        }
    }
}
