using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationApp
{
    class IndicateQuantity : Command
    {
        protected List<Audience> audiences;
        protected Admin admin;
        public IndicateQuantity(List<Audience> audiences, Admin admin)
        {
            this.audiences = audiences;
            this.admin = admin;
        }
        protected override void InternalLogic()
        {
            for (int i = 0; i < audiences.Count(); i++)
            {
                if(audiences[i].CountHumans<=0)
                {
                    audiences[i].CountHumanSet(admin);
                }
            }
        }
    }
}
