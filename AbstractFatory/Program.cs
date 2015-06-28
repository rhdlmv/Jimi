using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFatory
{
    //定义：定义了一个创建对象的接口，但由子类决定要实例化的类是那一个。工厂方法让类把实例化推迟到子类。
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered a " + pizza.getName() + "\n");

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine("Joel ordered a " + pizza.getName() + "\n");

            pizza = nyStore.OrderPizza("clam");
            Console.WriteLine("Ethan ordered a " + pizza.getName() + "\n");

            pizza = chicagoStore.OrderPizza("clam");
            Console.WriteLine("Joel ordered a " + pizza.getName() + "\n");

            pizza = nyStore.OrderPizza("pepperoni");
            Console.WriteLine("Ethan ordered a " + pizza.getName() + "\n");

            pizza = chicagoStore.OrderPizza("pepperoni");
            Console.WriteLine("Joel ordered a " + pizza.getName() + "\n");

            pizza = nyStore.OrderPizza("veggie");
            Console.WriteLine("Ethan ordered a " + pizza.getName() + "\n");

            pizza = chicagoStore.OrderPizza("veggie");
            Console.WriteLine("Joel ordered a " + pizza.getName() + "\n");

            Console.ReadKey();
        }
    }
}
