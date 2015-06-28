using AbstractFatory.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFatory
{
    public abstract class Pizza
    {
        protected String name;
        protected Dough dough;
        protected Sauce sauce;
        protected Veggies[] veggies;
        protected Cheese cheese;
        protected Peppernoi pepperoni;
        protected Clams clams;
        //protected List<String> toppings = new List<String>();

        public abstract void prepare();

        public void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public String getName()
        {
            return name;
        }

        //public String toString()
        //{
        //    StringBuffer display = new StringBuffer();
        //    display.append("---- " + name + " ----\n");
        //    display.append(dough + "\n");
        //    display.append(sauce + "\n");
        //    for (int i = 0; i < toppings.size(); i++)
        //    {
        //        display.append((String)toppings.get(i) + "\n");
        //    }
        //    return display.toString();
        //}
    }

    public class CheesePizza : Pizza
    {
        IPizzaIngredientFatory pizzaIngredientFatory;

        public CheesePizza(IPizzaIngredientFatory pizzaIngredientFatory)
        {
            this.pizzaIngredientFatory = pizzaIngredientFatory;
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing " + name);
            dough = pizzaIngredientFatory.CreateDough();
            sauce = pizzaIngredientFatory.CreateSauce();
            cheese = pizzaIngredientFatory.CreateCheese();
        }
    }


    public class ClamPizza : Pizza
    {

       IPizzaIngredientFatory pizzaIngredientFatory;

       public ClamPizza(IPizzaIngredientFatory pizzaIngredientFatory)
        {
            this.pizzaIngredientFatory = pizzaIngredientFatory;
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing " + name);
            dough = pizzaIngredientFatory.CreateDough();
            sauce = pizzaIngredientFatory.CreateSauce();
            cheese = pizzaIngredientFatory.CreateCheese();
        }
    }


   
}
