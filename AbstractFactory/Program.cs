using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ShopFactory factory1 = new BakeryFactory();
            Shop shop1 = new Shop(factory1);
            shop1.GetInformation();

            ShopFactory factory2 = new ButcherShopFactory();
            Shop shop2 = new Shop(factory2);
            shop2.GetInformation();

            Console.ReadKey();
        }
    }
}
