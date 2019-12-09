using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2CLasswork2
{
    public class Person
    {
        public string name;
        public int count;
        public string group;
        public string guidStr;
        Guid guid;

        public Person(string name, int count, string group, string guidStr =null)
        {
            this.name = name;
            this.count = count;
            this.group = group;
            if (this.guidStr == null)
            {
                guid = Guid.NewGuid();
                this.guidStr = guid.ToString();
            }
            else this.guidStr = guidStr;
        }

        public override string ToString()
        {
            return $"Name: {name}, Count: {count}, Group room: {group}, Guid: {guid}";
        }
    }
}
