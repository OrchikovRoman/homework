using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonFormaterCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                FirsName = "Alex",
                LastName = "Jameson",
                Age = 25
            };
            //var Serialized = JsonConvert.SerializeObject(new Person()
            //{
            //    FirsName = "Alex",
            //    LastName = "Jameson",
            //    Age = 25
            //});
            //Console.WriteLine(Serialized);
            Console.WriteLine(person);

            var serialize = ConveterToJson.SerializerPers(person);
            Console.WriteLine(serialize);
            var deserialize = JsonConvert.DeserializeObject(serialize);
            Console.WriteLine(deserialize);


            Console.ReadKey();
        }
    }



}
