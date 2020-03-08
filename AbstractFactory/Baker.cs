using System;

namespace AbstractFactory
{
    class Baker : ShopOwner
    {
        public override void Sells(Goods goods)
        {
            Console.WriteLine(string.Format("The {0} sells {1} in their shop", this.GetType().Name, goods.GetType().Name));
        }
    }
}
