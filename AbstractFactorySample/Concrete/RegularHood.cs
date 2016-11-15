using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample
{
    public class RegularHood : IHood
    {
        public RegularHood()
        {
            System.Console.WriteLine("Regular Hood Created!");
        }
    }
}
