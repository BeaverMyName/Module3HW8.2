using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Module3FinalProject2.Services;
using Module3FinalProject2.Services.Abstractions;

namespace Module3FinalProject2
{
    public class Starter
    {
        public void StartApplication()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IAccountService, AccountService>()
                .AddTransient<Application>()
                .BuildServiceProvider();

            var application = serviceProvider.GetService<Application>();

            application.Run();
        }
    }
}
