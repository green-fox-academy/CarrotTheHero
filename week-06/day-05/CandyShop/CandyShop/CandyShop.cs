using System;
using System.Collections.Generic;

namespace CandyShopLogic
{
    public class CandyShop
    {
        private decimal moneyInDrawer = 0;
        private decimal sugarInventory = 0;
        private decimal sugarPrice = 100;
        private Dictionary<Type, decimal> pricesOfSweets = new Dictionary<Type, decimal>();
        private Dictionary<Type, decimal> sweetInventory = new Dictionary<Type, decimal>();
        public static readonly Candy CANDY = new Candy();
        public static readonly Lollipop LOLLIPOP = new Lollipop();


        public CandyShop(decimal sugarGiven)
        {
            sugarInventory = sugarGiven;
            sweetInventory.Add(typeof(Candy), 0);
            sweetInventory.Add(typeof(Lollipop), 0);
            pricesOfSweets.Add(typeof(Candy), 20);
            pricesOfSweets.Add(typeof(Lollipop), 10);
        }

        public void CreateSweets(Sweets sweet)
        {
            if (sweet.sugarNeeded < sugarInventory)
            {
                sweetInventory[sweet.GetType()] += 1;
                sugarInventory -= sweet.sugarNeeded;
            }
            else
            {
                Console.WriteLine($"Not enough sugar to create the {sweet.GetType().Name}.");
            };
        }

        public void PrintInfo()
        {
            Console.WriteLine(ToString());
        }

        public void Sell(Sweets sweet, decimal qty)
        {
            if (sweetInventory[sweet.GetType()] > qty)
            {
                sweetInventory[sweet.GetType()] -= qty;
                moneyInDrawer += pricesOfSweets[sweet.GetType()] * qty;
            };
        }

        public void Raise(decimal raise)
        {
            pricesOfSweets[typeof(Candy)] *= (1 + raise / 100);
            pricesOfSweets[typeof(Lollipop)] *= (1 + raise / 100);
        }
        
        public void BuySugar(decimal sugar)
        {
            if (sugar / 1000 * sugarPrice < moneyInDrawer)
            {
                sugarInventory += sugar;
                moneyInDrawer -= sugar / 1000 * sugarPrice;
            }
            else
            {
                Console.WriteLine($"Not enough money to buy {sugar} gr of sugar.");
            }
        }

        public override string ToString() => $"CandyShop: Money: ${moneyInDrawer}" +
                $" Sugar: {sugarInventory} gr" +
                $" Candy: {sweetInventory[typeof(Candy)]} pcs" +
                $" Lollipop: {sweetInventory[typeof(Lollipop)]} pcs";
    }
}