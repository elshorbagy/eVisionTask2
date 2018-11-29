using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eVisionTask2.Models;
using eVisionTask2.Repositry;

namespace eVisionTask2.AccountService
{
    public class AccountService:IAccountService
    {
        private readonly List<Accounts> _lstAccounts;

        public AccountService()
        {            
            _lstAccounts = new GetAccounts().InitiateAccounts();
        }

        public async Task<double> GetAccountAmount(int accountId)
        {
            try
            {
                double amount;

                var singleAccount =await Task.Run(()=> _lstAccounts.Where(x => x.AccountId == accountId).ToList());
                 
                if (singleAccount.Count > 0)
                    amount = singleAccount[0].AccountAmount;
                else
                    amount = -1;

                return amount;
            }
            catch
            {
                return -1;
            }
        }
    }
}
