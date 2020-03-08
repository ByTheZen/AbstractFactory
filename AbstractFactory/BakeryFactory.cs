namespace AbstractFactory
{
    public class BakeryFactory : ShopFactory
    {
        public override Goods CreateGoods()
        {
            return new Bread();
        }

        public override ShopOwner CreateShopOwner()
        {
            return new Baker();
        }
    }
}
