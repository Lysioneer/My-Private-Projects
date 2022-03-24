using BankOfSimba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Services
{
    public class BankService
    {
        public static List<BankAccount> ListAllAccounts()
        {
            List<BankAccount> allAccounts = new();
            BankAccount simba = new("Simba", 2000, "Lion");
            allAccounts.Add(simba);
            BankAccount pumba = new("Pumba", 1200, "Warthog");
            allAccounts.Add(pumba);
            BankAccount scar = new("Scar", 100, "Lion");
            allAccounts.Add(scar);
            BankAccount monkey = new("The Monkey", 5100, "Monkey");
            allAccounts.Add(monkey);

            return allAccounts;
        }
    }
}
