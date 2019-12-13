using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary
{
    class CreateAutomobile
    {
        public static void CreateCar()
        {
            Console.Clear();
            int kitWheel = 4;
            int kitEngine = 2;
            int kitSteeringWheel = 1;
            int kitSeat = 2;

            if (Factory.countWheel >= kitWheel && Factory.countEngine >= kitEngine && Factory.countSteeringWheel >= kitSteeringWheel && Factory.countSeat >= kitSeat)
            {
                Car car = new Car();

                Factory.cars.Add(car);

                Factory.countWheel -= kitWheel;
                Factory.countEngine -= kitEngine;
                Factory.countSteeringWheel -= kitSteeringWheel;
                Factory.countSeat -= kitSeat;

                Console.WriteLine($"Created {car.ToString()}");
            }
            else
            {
                Console.WriteLine($@"Not enough details: 
kitWheel = {Factory.countWheel}/{kitWheel},
kitEngine = {Factory.countEngine}/{kitEngine},
kitSteeringWheel = {Factory.countSteeringWheel}/{kitSteeringWheel},
kitSeat = {Factory.countSeat}/{kitSeat}");
            }
        }
    }
}
