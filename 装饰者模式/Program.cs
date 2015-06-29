using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    //动态地将责任附加到对象上，若要扩张功能，装饰者提供了比继承更有弹性的替代方案。
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.GetDescription() + "$" + beverage.cost().ToString());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);//用两个Mocha修饰
            beverage2 = new Whip(beverage2);//在用Whip修饰。
            Console.WriteLine(beverage2.GetDescription() + "$" + beverage2.cost().ToString());
            Console.ReadKey();

        }
    }

    //抽象类：咖啡
    public abstract class Beverage
    {
        protected string description = "Unknown Beverage";
        public virtual string GetDescription()
        {
            return this.description;
        }
        //价格
        public abstract double cost();
    }

    //
    public abstract class CondimentDecorator : Beverage
    {
        public override abstract string GetDescription();
    }

    //一种咖啡
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }

        public override double cost()
        {
            return 1.99;
        }
    }

    //另外一种咖啡
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Cofee";
        }

        public override double cost()
        {
            return 0.89;
        }
    }

    //另外一种咖啡
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast Cofee";
        }

        public override double cost()
        {
            return 0.5;
        }
    }

    //配料
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }

        public override double cost()
        {
            return 0.20 + beverage.cost();
        }
    }

    //另外一种配料
    public class Whip : CondimentDecorator
    {
        Beverage beverage;
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }

        public override double cost()
        {
            return 0.10 + beverage.cost();
        }
    }
}
