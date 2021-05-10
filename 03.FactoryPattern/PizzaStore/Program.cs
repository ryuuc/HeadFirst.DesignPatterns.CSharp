using PizzaFactory.Store;

using System;

namespace PizzaFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaFactory.Store.PizzaStore nyStore = new NYPizzaStore();

            Pizza pizza = nyStore.CreatePizza("cheese");
            Console.WriteLine($"Ethan ordered a {pizza.Name}");

            Console.ReadKey();
        }
    }
}
