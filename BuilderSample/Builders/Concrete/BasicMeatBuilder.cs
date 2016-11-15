using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSample.Builders.Concrete
{
    public class BasicMeatBuilder : IMeatBuilder
    {
        public void AddChicken(Pizza pizza)
        {
            pizza.Add("Chicken");
        }

        public void AddPepperoni(Pizza pizza)
        {
            pizza.Add("Pepperoni");
        }

        public void AddSausage(Pizza pizza)
        {
            pizza.Add("Sausage");
        }
    }
}
