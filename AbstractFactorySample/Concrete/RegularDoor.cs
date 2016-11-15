using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample
{
    public class RegularDoor : IDoor
    {
        public RegularDoor()
        {
            System.Console.WriteLine("Regular Door Created!");
        }
    }
}
