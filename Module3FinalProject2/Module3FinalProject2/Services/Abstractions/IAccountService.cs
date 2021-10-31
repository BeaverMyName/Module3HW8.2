using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3FinalProject2.Services.Abstractions
{
    public interface IAccountService
    {
        public void Accept();
        public void Withdraw(double amount);
        public void Put(double amount);
    }
}
