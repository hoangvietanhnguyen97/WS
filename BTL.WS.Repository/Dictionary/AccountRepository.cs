using BTL.WS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.WS.Repository
{
    public class AccountRepository
    {
        public IEnumerable<Account> CheckLogin(string email)
        {
            DatabaseAccess databaseAccess = new DatabaseAccess();
            var acc = databaseAccess.CheckAccount(email);
            return acc;
        }

        public void AddAccount(Account account)
        {
            DatabaseAccess databaseAccess = new DatabaseAccess();
            databaseAccess.addAccount(account);
        }
    }
}
