namespace PizzaStore.Pizzas
{
    public abstract class Pizza
    {
        public abstract string GetDescription();
        public abstract string Prepare();
        public abstract string Bake();
        public abstract string Cut();
        public abstract string Box();
    }
}
