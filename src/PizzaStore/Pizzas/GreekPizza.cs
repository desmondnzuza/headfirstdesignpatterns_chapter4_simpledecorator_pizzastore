using System;

namespace PizzaStore.Pizzas
{
    public class GreekPizza : Pizza
    {
        public override string GetDescription()
        {
            return "Traditional Greek Pizza";
        }

        public override void Bake()
        {
            Console.WriteLine("Preparing Traditional Greek Pizza");
        }

        public override void Box()
        {
            Console.WriteLine("Boxing Traditional Greek Pizza");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting up Traditional Greek Pizza");
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing Traditional Greek Pizza");
        }
    }
}
