using AbstractFatory.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFatory
{
    public interface IPizzaIngredientFatory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CreateCheese();
        Veggies[] CreateVeggies();
        Peppernoi CreatePeppernoi();
        Clams CreateClams();
    }
}
