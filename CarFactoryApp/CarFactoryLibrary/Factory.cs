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
        
        public static int countWheel;
        public static int countEngine;
        public static int countSteeringWheel;
        public static int countSeat;
        public static int allDetail = 4;

        
        
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