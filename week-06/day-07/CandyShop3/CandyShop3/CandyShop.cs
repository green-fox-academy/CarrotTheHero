using System;
using System.Collections.Generic;
using CandyShop3;

namespace TakeMeToThe
{
    public class CandyShop
    {
        public static Candy CANDY = new Candy();
        public static Lollipop LOLLIPOP = new Lollipop();
        public List<Sweet> SweetInventory;
        public double Money, SugarStock;

        public CandyShop(int sugarstock)
        {
            SugarStock = sugarstock;
            SweetInventory = new List<Sweet>();
        }

        public void CreateSweets(Sweet sweet)
        {
            if (SugarStock > sweet.Sugar)
            {
                SweetInventory.Add(sweet);
                SugarStock -= sweet.Sugar;
            }
            else
            {
                Console.WriteLine($"Not enough sugar to create {sweet.GetType().Name}");
            }
        }

        public void PrintInfo()
        {
            int inventorySum = SweetInventory.Count;
            int candyCounter = 0;
            int lolliCounter = 0;

            foreach (Sweet sweet in SweetInventory)
            {
                if (sweet == CANDY)
                    candyCounter++;

                else
                    lolliCounter++;
            }
            Console.WriteLine("Inventory: {0} candies, {1} lollipops," +
                              " Income: {2}$, Sugar: {3}gr", candyCounter, lolliCounter, Money, SugarStock);
        }

        public void Sell(Sweet sweet, int pieces)
        {
            int inventorySum = SweetInventory.Count;
            int candyCounter = 0;
            int lollipopCounter = 0;

            foreach (Sweet sweetie in SweetInventory)
            {
                if (sweetie == CANDY)
                    candyCounter++;

                else
                    lollipopCounter++;
            }

            if (sweet == CANDY)
            {
                if (candyCounter > pieces)
                {
                    SweetInventory.Remove(sweet);
                    Money += sweet.Price;
                }
            }
            else
            {
                if (lollipopCounter > pieces)
                {
                    SweetInventory.Remove(sweet);
                    Money += sweet.Price;
                }
            }
        }

        public void Raise(double percentage)
        {
            int i = 0;
            while (i < SweetInventory.Count)
            {
                if (SweetInventory[i] == CANDY)
                {
                    SweetInventory.Remove(SweetInventory[i]);
                    SweetInventory.Insert(SweetInventory.Count - 1, new Candy(percentage));
                }
                else
                {
                    SweetInventory.Remove(SweetInventory[i]);
                    SweetInventory.Insert(SweetInventory.Count - 1, new Lollipop(percentage));
                }
                i++;
            }
        }

        public void BuySugar(int sugar)
        {
            if (Money >= sugar / 10)
            {
                SugarStock += sugar;
                Money -= sugar / 10;
            }
        }
    }
}