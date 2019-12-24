using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationApp
{
    class Admin
    {
        public int CountHumanos { get; set; }

        public int SetCountHumanos()
        {
            Console.WriteLine("Enter the number of people in the audience:");
            int countHum;
            while (!Int32.TryParse(Console.ReadLine(), out countHum))
            {
                Console.WriteLine("Input Error! Insert the number type Int32");
            }
            CountHumanos = countHum;
            return countHum;
        }
    }
}
