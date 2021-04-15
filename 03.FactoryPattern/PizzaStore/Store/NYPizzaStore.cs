using PizzaStore.Ingredient;

namespace PizzaStore.Store
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            if (type == "cheese")
            {
                pizza = new CheesePizza(ingredientFactory)
                {
                    Name = "New York Style Cheese Pizza"
                };
            }
            else if (type == "clam")
            {
                pizza = new ClamPizza(ingredientFactory)
                {
                    Name = "New York Style Clam Pizza"
                };
            }

            return pizza;
        }
    }
}