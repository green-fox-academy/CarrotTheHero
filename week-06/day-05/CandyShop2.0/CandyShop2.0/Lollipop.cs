using CandyShop2._0;

namespace CandyShopApp
{
    public class Lollipop : Sweets
    {
        public Lollipop()
        {
            SugarNeeded = 5;
            Price = 10;
        }
        public Lollipop(double percentage)
        {
            SugarNeeded = 5;
            Price = (percentage / 100 + 1) * 10;
        }
    }
}