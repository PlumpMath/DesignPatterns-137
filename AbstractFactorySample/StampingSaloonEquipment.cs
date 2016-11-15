using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample
{
    // an example of concrete factory, Abstract factory uses Concrete factory to create objects
    public class StampingSaloonEquipment : IStampingEquipment
    {
        public IDoor StampDoor()
        {
            return new RegularDoor();
        }

        public IHood StampHood()
        {
            return new RegularHood();
        }

        public IWheel StampWheel()
        {
            return new RegularWheel();
        }
    }
}
