using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary
{
    public class PrintListCommand : Command
    {
        protected Factory factory;
        public PrintListCommand(Factory factory)
        {
            this.factory = factory;
        }
        public override void InternalLogic()
        {
            factory.PrintListCars();
        }
    }
}
