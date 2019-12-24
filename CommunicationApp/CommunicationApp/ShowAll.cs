using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationApp
{
    class ShowAll : Command
    {
        protected List<Audience> audience;
        public ShowAll(List<Audience> audience)
        {
            this.audience = audience;
        }
        protected override void InternalLogic()
        {
            for (int i = 0; i < audience.Count; i++)
            {
                Console.WriteLine($"room: {i+1}");
                foreach (var item in audience[i].human)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
}
