using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSample.Builders.Concrete
{
    public class BasicCoreBuilder : ICoreBuilder
    {
        public void AddCheese(Pizza pizza)
        {
            pizza.Add("Basic Cheese");
        }

        public void RollDough(Pizza pizza)
        {
            pizza.Add("Classic Dough");
        }

        public void SpreadSauce(Pizza pizza)
        {
            pizza.Add("Classic Sauce");
        }
    }
}
