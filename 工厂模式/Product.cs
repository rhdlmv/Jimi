using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    public abstract class Pizza
    {
        protected String name;
        protected String dough;
        protected String sauce;
        protected List<String> toppings = new List<String>();

        public void prepare()
        {
            Console.WriteLine("Preparing " + name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            for (int i = 0; i < toppings.Count; i++)
            {
                Console.WriteLine("   " + toppings[i]);
            }
        }

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

    public class ChicagoStyleCheesePizza : Pizza
    {

        public ChicagoStyleCheesePizza()
        {
            name = "Chicago Style Deep Dish Cheese Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Shredded Mozzarella Cheese");
        }

        void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }

    public class ChicagoStyleClamPizza : Pizza
    {
        public ChicagoStyleClamPizza()
        {
            name = "Chicago Style Clam Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";
            toppings.Add("Shredded Mozzarella Cheese");
            toppings.Add("Frozen Clams from Chesapeake Bay");
        }

        void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }

    public class ChicagoStylePepperoniPizza : Pizza
    {
        public ChicagoStylePepperoniPizza()
        {
            name = "Chicago Style Pepperoni Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Shredded Mozzarella Cheese");
            toppings.Add("Black Olives");
            toppings.Add("Spinach");
            toppings.Add("Eggplant");
            toppings.Add("Sliced Pepperoni");
        }

        void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }

    public class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            name = "Chicago Deep Dish Veggie Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";
            toppings.Add("Shredded Mozzarella Cheese");
            toppings.Add("Black Olives");
            toppings.Add("Spinach");
            toppings.Add("Eggplant");
        }

        void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }


    public class NYStyleCheesePizza : Pizza
    {

        public NYStyleCheesePizza()
        {
            name = "NY Style Sauce and Cheese Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
        }
    }


    public class NYStyleClamPizza : Pizza
    {

        public NYStyleClamPizza()
        {
            name = "NY Style Clam Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
            toppings.Add("Fresh Clams from Long Island Sound");
        }
    }


    public class NYStylePepperoniPizza : Pizza
    {

        public NYStylePepperoniPizza()
        {
            name = "NY Style Pepperoni Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
            toppings.Add("Sliced Pepperoni");
            toppings.Add("Garlic");
            toppings.Add("Onion");
            toppings.Add("Mushrooms");
            toppings.Add("Red Pepper");
        }
    }


    public class NYStyleVeggiePizza : Pizza
    {

        public NYStyleVeggiePizza()
        {
            name = "NY Style Veggie Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
            toppings.Add("Garlic");
            toppings.Add("Onion");
            toppings.Add("Mushrooms");
            toppings.Add("Red Pepper");
        }
    }

}
