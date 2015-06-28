using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFatory.Ingredients
{
    public abstract class Dough
    {
        public string Name { get; set; }
    }

    public class ThickCrushDough : Dough
    {

    }

    public class ThinCrustDouhg : Dough
    {

    }
}
