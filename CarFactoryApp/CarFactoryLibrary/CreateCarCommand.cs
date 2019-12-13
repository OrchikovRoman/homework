using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary
{
    public class CreateCarCommand : Command
    {
        protected Factory factory;

        public CreateCarCommand(Factory factory)
        {
            this.factory = factory;
        }
        public override void InternalLogic()
        {
            CreateAutomobile.CreateCar();
        }
    }
}
