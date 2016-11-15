using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSample.Builders
{
    public interface IVeggieBuilder
    {
        void AddMushrooms(Pizza pizza);
        void AddPeppers(Pizza pizza);
        void AddOlives(Pizza pizza);
    }
}
