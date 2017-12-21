﻿using System;
using PizzaStore.Pizzas;

namespace PizzaStore.Factory
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            if (type.Equals("Cheese"))
            {
                return new CheesePizza();
            }

            if (type.Equals("Greek"))
            {
                return new GreekPizza();
            }

            if (type.Equals("Pepperoni"))
            {
                return new PepperoniPizza();
            }

            throw new NotSupportedException(nameof(type));
        }
    }
}
