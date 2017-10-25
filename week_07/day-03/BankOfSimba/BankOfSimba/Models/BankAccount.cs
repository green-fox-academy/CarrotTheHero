using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public enum Animal { Lion, Zebra, Hound, Giraffe, Monkey}
    public class BankAccount
    {
        public List<BankAccount> ListOfNamesThaIDontKnow = new List<BankAccount>();
        public string Name { get; set; }
        public double Balance { get; set; }
        public Animal AnimalType { get; set; }
        public bool IsKing { get; set; }
        public bool IsGood { get; set; }

        public BankAccount (string name, double balance, Animal animaltype, bool isKing, bool isGood)
        {
            Name = name;
            Balance = balance;
            IsKing = isKing;
            AnimalType = animaltype;
            IsGood = isGood;
        }

        public BankAccount()
        {
        }
    }
}
