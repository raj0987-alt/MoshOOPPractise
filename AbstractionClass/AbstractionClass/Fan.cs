using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionClass
{
    public class Fan : Electronics
    {
        public override string Name { get; set; }
        public override void GiveService()
        {
            Console.WriteLine("Fan Gives Us Wind");
        }
    }
}
