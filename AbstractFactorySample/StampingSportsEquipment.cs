using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample
{
    public class StampingSportsEquipment : IStampingEquipment
    {
        public IDoor StampDoor()
        {
            return new CoupeDoor();
        }

        public IHood StampHood()
        {
            return new GlassHood();
        }

        public IWheel StampWheel()
        {
            return new WideWheel();
        }
    }
}
