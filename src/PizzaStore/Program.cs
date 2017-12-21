using System;
using PizzaStore.Helper;

namespace PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var endProgram = false;
            var factory    = new Factory.SimplePizzaFactory();
            var store      = new Store.PizzaStore(factory);

            do
            {
                var answer = GetOrder();

                if (answer.IsValidAnswer())
                {
                    Console.WriteLine("placing order...");
                    var order = store.OrderPizza(answer);
                    Console.WriteLine(String.Empty);
                    Console.WriteLine($"You just ordered : {order.GetDescription()}");
                    Console.WriteLine(string.Empty);
                }
                else
                {
                    endProgram = true;
                }

            } while (!endProgram);

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }

        private static string GetOrder()
        {
            Console.WriteLine("What do you want to order? 1)Cheese 2)Greek 3) Pepperoni");
            var rawAnswer = Console.ReadLine();

            switch (rawAnswer)
            {
                case "1":
                    return "Cheese";
                case "2":
                    return "Greek";
                case "3":
                    return "Pepperoni";
                default:
                    return rawAnswer;
            }
        }
    }
}
