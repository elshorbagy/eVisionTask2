using System.Collections.Generic;
using eVisionTask2.Models;

namespace eVisionTask2.Repositry
{
    public class GetAccounts
    {
        public List<Accounts> InitiateAccounts()
        {
            var lstAccounts= new List<Accounts>()
            {
                new Accounts { AccountId = 1,AccountAmount= 2500 },
                new Accounts { AccountId = 2,AccountAmount= 3000.50 },
                new Accounts { AccountId = 3,AccountAmount= 1500.25 },
                new Accounts { AccountId = 4,AccountAmount= 40000.10 }
            };

            return lstAccounts;

        }
    }
}
