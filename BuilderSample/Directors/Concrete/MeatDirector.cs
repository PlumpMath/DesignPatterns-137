using BuilderSample.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSample.Directors.Concrete
{
    public class MeatDirector : IPizzaDirector
    {
        private ICoreBuilder coreBuilder;
        private IMeatBuilder meatBuilder;
        private IVeggieBuilder veggieBuilder;

        public MeatDirector(ICoreBuilder coreBuilder, IMeatBuilder meatBuilder, IVeggieBuilder veggieBuilder)
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
            return pizza;
        }
    }
}
