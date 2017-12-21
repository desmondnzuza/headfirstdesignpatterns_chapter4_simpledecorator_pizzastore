using System;

namespace PizzaStore.Pizzas
{
    public class CheesePizza : Pizza
    {
        public override string GetDescription()
        {
            return "Traditional Cheeze Pizza";
        }

        public override void Bake()
        {
            Console.WriteLine("Preparing:\tTraditional Cheeze Pizza");
        }

        public override void Box()
        {
            Console.WriteLine("Boxing:\t Traditional Cheeze Pizza");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting Up:\t Traditional Cheeze Pizza");
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing:\t Traditional Cheeze Pizza");
        }
    }
}
