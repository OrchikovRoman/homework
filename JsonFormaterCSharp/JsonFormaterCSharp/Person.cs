using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace JsonFormaterCSharp
{
    
    public class Person
    {
        public string FirsName { get; set; }
        [IgnoreProperty]
        public string LastName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{FirsName} {LastName} {Age}";
        }
    }
}
