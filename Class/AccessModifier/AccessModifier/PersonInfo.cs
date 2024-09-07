using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    public class PersonInfo
    {
        
        public DateTime BirthDate {  get; private set; }
        public string Name { get; set; }

        public PersonInfo(DateTime birthDate)
        {
            BirthDate = birthDate;
        }
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Now - BirthDate;
                return timeSpan.Days / 365;
            }
        }
    }
}
