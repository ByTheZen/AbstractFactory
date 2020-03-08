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
            _shopOwner.Sells(_goods);
        }
    }
}
