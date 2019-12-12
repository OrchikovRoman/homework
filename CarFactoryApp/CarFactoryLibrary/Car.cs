using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary
{
    public class Car
    {
        Guid guid = Guid.NewGuid();

        public override string ToString()
        {
            return $"Car serial number - {guid}";
        }
    }
}
