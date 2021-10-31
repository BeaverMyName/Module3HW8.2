using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module3FinalProject2.Models;
using Module3FinalProject2.Services;

namespace Module3FinalProject2
{
    public class Application
    {
        public void Run()
        {
            var account = new Account() { Id = 1, UserName = "Igor", Balance = new Balance() { Amount = 1000 } };

            var bankService = new AccountService(account);

            bankService.Accept();

            bankService.Withdraw(500);
            bankService.Put(100);
        }
    }
}
