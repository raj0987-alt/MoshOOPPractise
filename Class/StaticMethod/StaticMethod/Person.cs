using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
{
    public class Person
    {
        public string Name { get; set; }
        public void Introduce (string name)
        {
            Console.WriteLine ("Hello {0}, I am {1}", Name, name);
        }

        public static Person Parse(string to)
        {
            Person person = new Person();
            person.Name = to;
            return person;
        }
    }
}
