using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFatory.Ingredients;

namespace AbstractFatory.IngredientFatories
{
    public class ChicagoIngredientFactory : IPizzaIngredientFatory
    {
        public Dough CreateDough()
        {
            return new ThinCrustDouhg();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public Cheese CreateCheese()
        {
            return new ReggiamoCheese();
        }

        public Veggies[] CreateVeggies()
        {
            return new Veggies[] { new Veggies2(), new Veggies2() };
        }

        public Peppernoi CreatePeppernoi()
        {
            return new SlicedPepperoni();
        }

        public Clams CreateClams()
        {
            return new FrozenClams();
        }
    }
}
