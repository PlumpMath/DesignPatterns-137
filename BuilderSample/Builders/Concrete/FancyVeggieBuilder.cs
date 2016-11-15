using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSample.Builders.Concrete
{
    public class FancyVeggieBuilder : IVeggieBuilder
    {
        public void AddMushrooms(Pizza pizza)
        {
            pizza.Add("Fungus d'jour");
        }

        public void AddOlives(Pizza pizza)
        {
            pizza.Add("Spanish Arbequina");
        }

        public void AddPeppers(Pizza pizza)
        {
            pizza.Add("Padon Pepper");
        }
    }
}
