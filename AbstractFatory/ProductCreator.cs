using AbstractFatory.IngredientFatories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFatory
{
    public abstract class PizzaStore
    {
        public abstract Pizza CreatePizza(String item);

        public Pizza OrderPizza(String type)
        {
            Pizza pizza = CreatePizza(type);
            Console.WriteLine("--- Making a " + pizza.getName() + " ---");
            pizza.prepare();
            pizza.bake(); 
            pizza.cut();
            pizza.box();
            return pizza;
        }
    }

    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string item)
        {
            Pizza pizza = null;
            IPizzaIngredientFatory pizzaIngredientFatory = new ChicagoIngredientFactory();
            if (item.Equals("cheese"))
            {
                pizza = new CheesePizza(pizzaIngredientFatory);
                pizza.SetName("New York Style Cheese pizza");
            }

            else if (item.Equals("clam"))
            {
                pizza = new ClamPizza(pizzaIngredientFatory);
                pizza.SetName("New York Style Clam pizza");
            }
            return pizza;
        }
    }


    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string item)
        {
            Pizza pizza = null;
            IPizzaIngredientFatory pizzaIngredientFatory = new NYPizzaIngredientFactory();

            if (item.Equals("cheese"))
            {
                pizza = new CheesePizza(pizzaIngredientFatory);
                pizza.SetName("New York Style Cheese pizza");
            }

            else if (item.Equals("clam"))
            {
                pizza = new ClamPizza(pizzaIngredientFatory);
                pizza.SetName("New York Style Clam pizza");
            }

            return pizza;
        }
    }
}
