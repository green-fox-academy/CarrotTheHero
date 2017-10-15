using CandyShop3;

namespace CandyShop3
{
    public class Lollipop : Sweet
    {
        public Lollipop()
        {
            Price = 10;
            Sugar = 5;
        }
        public Lollipop(double percentage)
        {
            Sugar = 5;
            Price = (percentage / 100 + 1) * 10;
        }
    }
}
