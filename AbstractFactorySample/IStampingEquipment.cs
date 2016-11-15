using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample
{
    //Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
    //A hierarchy that encapsulates: many possible "platforms", and the construction of a suite of "products".
    //The new operator considered harmful.

    //in the below example, the objects are related
    public interface IStampingEquipment
    {
        IHood StampHood();
        IDoor StampDoor();
        IWheel StampWheel();
    }

    //Abstract Factory can be used as an alternative to Facade to hide platform-specific classes.
}
