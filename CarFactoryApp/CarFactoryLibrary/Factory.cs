using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary
{
     public class Factory
     {
        public static readonly List<Car> cars = new List<Car>();
        
        

        public void CreateCar(int countWheel, int countEngine, int countSteeringWheel, int countSeat)
        {
            Console.Clear();
            int kitWheel = 4;
            int kitEngine = 2;
            int kitSteeringWheel = 1;
            int kitSeat = 2;

            if (countWheel >= kitWheel && countEngine >= kitEngine && countSteeringWheel >= kitSteeringWheel && countSeat >= kitSeat)
            {
                Car car = new Car();

                cars.Add(car);

                countWheel -= kitWheel;
                countEngine -= kitEngine;
                countSteeringWheel -= kitSteeringWheel;
                countSeat -= kitSeat;

                Console.WriteLine($"Created {car.ToString()}");
            }
            else
            {
                Console.WriteLine($@"Not enough details: 
kitWheel = {countWheel}/{kitWheel},
kitEngine = {countEngine}/{kitEngine},
kitSteeringWheel = {countSteeringWheel}/{kitSteeringWheel},
kitSeat = {countSeat}/{kitSeat}");
            }
        }


        public void PrintListCars()
        {
            Console.WriteLine($"\nTotal number of items in the collection: {cars.Count}\n");
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }   
}       