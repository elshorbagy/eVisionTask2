using System.Threading.Tasks;
using eVisionTask2.AccountService;

namespace eVisionTask2
{
    public class AccountInfo
    {
        private readonly int _accountId;
        private readonly IAccountService _accountService;
        public AccountInfo(int accountId, IAccountService accountService)
        {
            _accountId = accountId;
            _accountService = accountService;
        }

        public double Amount { get; private set; }

        public async Task RefreshAmount()
        {
            Amount = await _accountService.GetAccountAmount(_accountId);
        }

    }
}
