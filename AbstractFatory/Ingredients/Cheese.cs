using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFatory.Ingredients
{
    public abstract class Cheese
    {
        public string Name { get; set; }
    }

    public class MozzarellaCheese : Cheese { }

    public class ReggiamoCheese : Cheese { }
}
