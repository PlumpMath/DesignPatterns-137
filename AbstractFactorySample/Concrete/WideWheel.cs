using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample
{
    public class WideWheel : IWheel
    {
        public WideWheel()
        {
            System.Console.WriteLine("Wide Wheel Created!");
        }

        public void Shalakhto()
        {
            System.Console.WriteLine("Shalakhto!");
        }
    }
}
