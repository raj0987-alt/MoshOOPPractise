using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public class Animal
    {
        public string Name;
        public virtual void Speed()
        {
            Console.WriteLine("Animal is faster");
        }
    }
    public class Bird : Animal
    {
        public override void Speed()
        {
            base.Speed();
            Console.WriteLine("Bird is slower");
        }
    }

    public class Tiger : Animal
    {
        public void Speed()
        {
            Console.WriteLine("Tiger is faster");
        }
    }
}
