using BuilderSample.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSample.Directors.Concrete
{
    public class VeggieDirector : IPizzaDirector
    {
        ICoreBuilder coreBuilder;
        IVeggieBuilder veggieBuilder;

        public VeggieDirector(ICoreBuilder coreBuilder, IVeggieBuilder veggieBuilder)
        {
            this.coreBuilder = coreBuilder;
            this.veggieBuilder = veggieBuilder;
        }

        public Pizza MakePizza()
        {
            Pizza pizza = new Pizza();
            coreBuilder.RollDough(pizza);
            coreBuilder.AddCheese(pizza);
            coreBuilder.SpreadSauce(pizza);

            veggieBuilder.AddMushrooms(pizza);
            veggieBuilder.AddPeppers(pizza);
            veggieBuilder.AddOlives(pizza);
            return pizza;
        }
    }
}
