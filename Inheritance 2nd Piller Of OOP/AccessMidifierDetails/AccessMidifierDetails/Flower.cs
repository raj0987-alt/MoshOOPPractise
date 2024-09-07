using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessMidifierDetails
{
    public class Flower
    {
        public string FlowerName {  get; set; }
        private void SmellGet()
        {
            int issmell = IsSmell();
            if(issmell == 0)
            {
                Console.WriteLine("Flower Is smelt");
            }
            else
            {
                Console.WriteLine("Flower Is Not smelt");
            }
        }
        public int IsSmell()
        {
            return 0;
        }
    }
}
