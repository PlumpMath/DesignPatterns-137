using AbstractFactorySample2.ConcreteCars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample2.ConcreteFactories
{
    public class ToyotaFactory : ICarFactory
    {
        public IConvertible CreateConvertible()
        {
            return new Supra();
        }

        public ISedan CreateSedan()
        {
            return new Camry();
        }

        public ISUV CreateSUV()
        {
            return new Rav4();
        }
    }
}
