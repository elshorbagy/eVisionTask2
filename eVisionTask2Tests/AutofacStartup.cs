using Autofac;
using eVisionTask2.AccountService;

namespace eVisionTask2Tests
{
    class AutofacStartup
    {
        public static IContainer Init()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<AccountService>().As<IAccountService>();
            return builder.Build();
        }

    }
}
