using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module3FinalProject2.Models;
using Module3FinalProject2.Services.Abstractions;

namespace Module3FinalProject2.Services
{
    public class AccountService : IAccountService
    {
        private readonly Account _account;

        public AccountService(Account account)
        {
            _account = account;
        }

        public void Accept()
        {
            _account.Balance.Put += (amount) => Console.WriteLine($"You have put {amount} UAH.");
            _account.Balance.Withdrawn += (amount) => Console.WriteLine($"You have withdrawn {amount} UAH.");
        }

        public void Withdraw(double amount)
        {
            _account.Balance.Amount -= amount;
        }

        public void Put(double amount)
        {
            _account.Balance.Amount += amount;
        }
    }
}
