using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSample.Builders.Concrete
{
    public class BasicVeggieBuilder : IVeggieBuilder
    {
        public void AddMushrooms(Pizza pizza)
        {
            pizza.Add("Mushroom");
        }

        public void AddOlives(Pizza pizza)
        {
            pizza.Add("Black olives");
        }

        public void AddPeppers(Pizza pizza)
        {
            pizza.Add("Green peppers");
        }
    }
}
