using System.Linq;

namespace PizzaStore.Helper
{
    public static class StringHelper
    {
        public static bool IsValidAnswer(this string answer)
        {
            var supportedAnswers = new []{"Cheese", "Greek", "Pepperoni"};
            return supportedAnswers.Contains(answer);
        }
    }
}
