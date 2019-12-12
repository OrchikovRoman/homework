using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary
{
    public class CreatDetailsCommand : Command
    {
        protected Factory factory;

        public CreatDetailsCommand(Factory factory)
        {
            this.factory = factory;
        }
        public override void InternalLogic()
        {
            factory.RandomDetail();
        }
    }
}
