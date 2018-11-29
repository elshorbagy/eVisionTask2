using System.Threading.Tasks;

namespace eVisionTask2.AccountService
{
    public interface IAccountService
    {
        Task<double> GetAccountAmount(int accountId);
    }
}
