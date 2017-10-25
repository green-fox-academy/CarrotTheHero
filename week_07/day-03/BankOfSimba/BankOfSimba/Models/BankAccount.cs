using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public enum Animal { Lion, Zebra, Hound, Giraffe, Monkey, MonkeyBreadTree}
    public class BankAccount
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public Animal AnimalType { get; set; }

        public BankAccount (string name, double balance, Animal animaltype)
        {
            Name = name;
            Balance = balance;
            AnimalType = animaltype;
        }
    }
}
