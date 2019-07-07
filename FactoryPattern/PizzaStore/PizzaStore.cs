using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.PizzaTypes;

namespace FactoryPattern.PizzaStore
{
    public abstract class PizzaStore
    {
        public virtual Pizza OrderPizza(string type)
        {
            var pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }
}
