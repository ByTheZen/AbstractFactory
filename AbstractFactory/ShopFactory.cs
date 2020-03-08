namespace AbstractFactory
{
    public abstract class ShopFactory
    {
        public abstract ShopOwner CreateShopOwner();
        public abstract Goods CreateGoods();
    }
}
