using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFatory.Ingredients;

namespace AbstractFatory.IngredientFatories
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFatory
    {
        public Dough CreateDough()
        {
            return new ThickCrushDough();
        }

        public Sauce CreateSauce()
        {
            return new PlumTomaloSauce();
        }

        public Cheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public Veggies[] CreateVeggies()
        {
            return new Veggies[] { new Veggies1(), new Veggies1() };
        }

        public Peppernoi CreatePeppernoi()
        {
            return new SlicedPepperoni();
        }

        public Clams CreateClams()
        {
            return new FreshClams();
        }
    }
}
