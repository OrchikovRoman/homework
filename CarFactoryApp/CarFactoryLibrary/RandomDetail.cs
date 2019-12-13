using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary
{
    class CreateRandomDetail
    {
        private static Random random = new Random();

        public static void RandomDetail()
        {
             
        Console.Clear();
            switch (random.Next(0, Factory.allDetail))
            {
                case 0:
                    Wheel wheel = new Wheel();
                    Factory.countWheel++;
                    break;
                case 1:
                    Engine engine = new Engine();
                    Factory.countEngine++;
                    break;
                case 2:
                    SteeringWheel steeringWheel = new SteeringWheel();
                    Factory.countSteeringWheel++;
                    break;
                case 3:
                    Seat seat = new Seat();
                    Factory.countSeat++;
                    break;
            }
            Console.WriteLine("Created Random Details");
        }
    } 
}
  

