using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample
{
    public class CoupeDoor: IDoor
    {
        public CoupeDoor()
        {
            System.Console.WriteLine("Coupe Door Created!");
        }
    }
}
