using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFatory.Ingredients
{
    public abstract class Clams
    {
        public string Name { get; set; }
    }

    public class FrozenClams : Clams
    {

    }

    public class FreshClams : Clams { }
}
