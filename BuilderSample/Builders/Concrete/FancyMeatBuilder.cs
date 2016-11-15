using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSample.Builders.Concrete
{
    public class FancyMeatBuilder : IMeatBuilder
    {
        public void AddChicken(Pizza pizza)
        {
            pizza.Add("Snobby Chicken");
        }

        public void AddPepperoni(Pizza pizza)
        {
            pizza.Add("Snobby Pepperoni");
        }

        public void AddSausage(Pizza pizza)
        {
            pizza.Add("Snobby Sausage");
        }
    }
}
