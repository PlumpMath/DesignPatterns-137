using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSample.Builders
{
    public interface ICoreBuilder
    {
        void RollDough(Pizza pizza);
        void SpreadSauce(Pizza pizza);
        void AddCheese(Pizza pizza);
    }
}
