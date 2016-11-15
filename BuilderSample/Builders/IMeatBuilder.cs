using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSample.Builders
{
    public interface IMeatBuilder
    {
        void AddPepperoni(Pizza pizza);
        void AddSausage(Pizza pizza);
        void AddChicken(Pizza pizza);
    }
}
