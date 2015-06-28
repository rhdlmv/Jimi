using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFatory.Ingredients
{
    public abstract class Sauce
    {
        public string Name { get; set; }
    }

    public class PlumTomaloSauce : Sauce
    {

    }

    public class MarinaraSauce : Sauce
    {

    }
}
