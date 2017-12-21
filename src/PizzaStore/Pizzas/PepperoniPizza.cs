using System;

namespace PizzaStore.Pizzas
{
    public class PepperoniPizza : Pizza
    {
        public override string GetDescription()
        {
            return "Traditional Pepperoni Pizza";
        }

        public override void Bake()
        {
            Console.WriteLine("Preparing Traditional Pepperoni Pizza");
        }

        public override void Box()
        {
            Console.WriteLine("Boxing Traditional Pepperoni Pizza");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting up Traditional Pepperoni Pizza");
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing Traditional Pepperoni Pizza");
        }
    }
}
