using System;

namespace AbstractFactory
{
    public class Shop
    {
        private ShopOwner _shopOwner;
        private Goods _goods;

        public Shop(ShopFactory factory)
        {
            _goods = factory.CreateGoods();
            _shopOwner = factory.CreateShopOwner();
        }
              
        public void GetInformation()
        {
            Console.WriteLine(string.Format("The {0} sells {1} in their shop", _shopOwner.GetType().Name, _goods.GetType().Name));
        }
    }
}
