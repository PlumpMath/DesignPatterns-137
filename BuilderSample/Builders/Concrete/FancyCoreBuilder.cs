using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSample.Builders.Concrete
{
    public class FancyCoreBuilder : ICoreBuilder
    {
        public void AddCheese(Pizza pizza)
        {
            pizza.Add("Artisan cheese");
        }

        public void RollDough(Pizza pizza)
        {
            pizza.Add("Artisan dough");
        }

        public void SpreadSauce(Pizza pizza)
        {
            pizza.Add("Artisan sauce");
        }
    }
}
