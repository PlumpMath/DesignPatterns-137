using AbstractFactorySample2.ConcreteCars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample2.ConcreteFactories
{
    public class FordFactory : ICarFactory
    {
        public IConvertible CreateConvertible()
        {
            return new Mustang();
        }

        public ISedan CreateSedan()
        {
            return new Taurus();
        }

        public ISUV CreateSUV()
        {
            return new Edge();
        }
    }
}
