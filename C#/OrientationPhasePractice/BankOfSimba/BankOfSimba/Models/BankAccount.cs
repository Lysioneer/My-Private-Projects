using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public long Balance { get; set; }
        public string Currency { get; set; }
        public string AnimalType { get; set; }
        public BankAccount(string name, long balance, string animalType)
        {
            Name = name;
            Balance = balance;
            Currency = "Zebra";
            AnimalType = animalType;
        }
    }
}
