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
        protected CreateRandomDetail randomDetail;

        public CreateCarCommand(Factory factory, CreateRandomDetail randomDetail)
        {
            this.factory = factory;
            this.randomDetail = randomDetail;
        }
        public override void InternalLogic()
        {
            factory.CreateCar(randomDetail.countWheel,randomDetail.countEngine, randomDetail.countSteeringWheel,randomDetail.countSeat);
        }
    }
}
