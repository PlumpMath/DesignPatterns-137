using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample
{
    public enum CARTYPES
    {
        Sports,
        Regular
    }
    public class StampingEquipmentClient
    {
        IStampingEquipment equipment; 
        //factory method
        //reduce using new to ONE AND ONLY ONE place 
        public IStampingEquipment GetEquipment(CARTYPES CarType)
        {
            switch (CarType)
            {
                case CARTYPES.Regular:
                    equipment = new StampingSaloonEquipment();
                    break;
                case CARTYPES.Sports:
                    equipment = new StampingSportsEquipment();
                    break;
            }
            return equipment;
        }
    }
}
