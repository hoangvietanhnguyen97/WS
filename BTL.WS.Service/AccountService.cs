using BTL.WS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTL.WS.Entity;

namespace BTL.WS.Service
{
    public class AccountService
    {
        public IEnumerable<Account> GetAccounts(string email)
        {
            AccountRepository accountRepository = new AccountRepository();
            var account = accountRepository.CheckLogin(email);
            return account;
        }

        public void AddAccount(Account account)
        {
            AccountRepository accountRepository = new AccountRepository();
            accountRepository.AddAccount(account);
        }
    }
}
