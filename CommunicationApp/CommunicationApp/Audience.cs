using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationApp
{
    class Audience
    {
        public int CountHumans { get; set; }
        public List<Human> human = new List<Human>();

        public void CountHumanSet(Admin admin)
        {
            CountHumans = admin.SetCountHumanos();
        }
    }
}
