using CandyShop3;

namespace CandyShop3
{
    public class Candy : Sweet
    {
        public Candy()
        {
            Price = 20;
            Sugar = 10;
        }
        public Candy(double percentage)
        {
            Sugar = 10;
            Price = (percentage / 100 + 1) * 20;
        }
    }
}
