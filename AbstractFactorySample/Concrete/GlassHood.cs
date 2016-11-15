using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample
{
    public class GlassHood : IHood
    {
        public GlassHood()
        {
            System.Console.WriteLine("Glass Hood Created!");
        }
    }
}
