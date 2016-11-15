using BuilderSample.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSample.Directors.Concrete
{
    public class EverythingDirector : IPizzaDirector
    {
        private ICoreBuilder coreBuilder;
        private IMeatBuilder meatBuilder;
        private IVeggieBuilder veggieBuilder;

        public EverythingDirector(ICoreBuilder coreBuilder, IMeatBuilder meatBuilder, IVeggieBuilder veggieBuilder)
        {
            this.coreBuilder = coreBuilder;
            this.meatBuilder = meatBuilder;
            this.veggieBuilder = veggieBuilder;
        }


        public Pizza MakePizza()
        {
            Pizza pizza = new Pizza();
            coreBuilder.RollDough(pizza);
            coreBuilder.AddCheese(pizza);
            coreBuilder.SpreadSauce(pizza);
            meatBuilder.AddChicken(pizza);
            meatBuilder.AddPepperoni(pizza);
            meatBuilder.AddSausage(pizza);
            veggieBuilder.AddMushrooms(pizza);
            veggieBuilder.AddPeppers(pizza);
            veggieBuilder.AddOlives(pizza);
            return pizza;
        }
    }
}
