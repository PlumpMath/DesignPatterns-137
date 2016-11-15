using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample
{
    public class RegularWheel : IWheel
    {
        public RegularWheel()
        {
            System.Console.WriteLine("Regular Wheel Created!");
        }
        public void Samatto()
        {
            System.Console.WriteLine("Samatto!");
        }
    }
}
