using CandyShop2._0;

namespace CandyShopApp
{
    public class Candy : Sweets
    {
        public Candy()
        {
            SugarNeeded = 10;
            Price = 20;
        }
        public Candy(double percentage)
        {
            SugarNeeded = 10;
            Price = (percentage / 100 + 1) * 20;
        }
    }
}