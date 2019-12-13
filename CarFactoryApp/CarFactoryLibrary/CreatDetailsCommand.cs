using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary
{
    public class CreatDetailsCommand : Command
    {
        protected CreateRandomDetail randomDetail;

        public CreatDetailsCommand(CreateRandomDetail randomDetail)
        {
            this.randomDetail = randomDetail;
        }
        public override void InternalLogic()
        {
            randomDetail.RandomDetail();
        }
    }
}
