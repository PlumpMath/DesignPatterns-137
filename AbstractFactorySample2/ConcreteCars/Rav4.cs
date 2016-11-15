using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample2.ConcreteCars
{
    public class Rav4 : ISUV
    {
        //some unique implementation 
        public void PrintName()
        {
            System.Console.WriteLine("Toyota - Rav4");
        }
    }
}
