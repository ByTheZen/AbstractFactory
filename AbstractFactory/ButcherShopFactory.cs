namespace AbstractFactory
{
    public class ButcherShopFactory : ShopFactory
    {
        public override Goods CreateGoods()
        {
            return new Meat();
        }

        public override ShopOwner CreateShopOwner()
        {
            return new Butcher();
        }
    }
}
