using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary
{
    public class CreateRandomDetail
    {
        public static Random random = new Random();
        public int countWheel;
        public int countEngine;
        public int countSteeringWheel;
        public int countSeat;
        public int allDetail = 4;

        public void RandomDetail()
        {
             
        Console.Clear();
            switch (random.Next(0, allDetail))
            {
                case 0:
                    Wheel wheel = new Wheel();
                    countWheel++;
                    break;
                case 1:
                    Engine engine = new Engine();
                    countEngine++;
                    break;
                case 2:
                    SteeringWheel steeringWheel = new SteeringWheel();
                    countSteeringWheel++;
                    break;
                case 3:
                    Seat seat = new Seat();
                    countSeat++;
                    break;
            }
            Console.WriteLine("Created Random Details");
        }
    } 
}
  

