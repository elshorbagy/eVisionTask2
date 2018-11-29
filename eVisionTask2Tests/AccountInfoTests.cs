using Autofac;
using eVisionTask2;
using eVisionTask2.AccountService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace eVisionTask2Tests
{
    [TestClass()]
    public class AccountInfoTests
    {
        [TestMethod()]
        public async Task RefreshAmountTest()
        {
            var accountService = AutofacStartup.Init().Resolve<IAccountService>();

            var accountInfo = new AccountInfo(1, accountService);

            await accountInfo.RefreshAmount();

            Assert.AreEqual(2500, accountInfo.Amount);
        }
    }
}