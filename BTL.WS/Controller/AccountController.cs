using BTL.WS.Entity;
using BTL.WS.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BTL.WS.Controller
{
    public class AccountController : ApiController
    {
        [HttpGet]
        [Route("Account/get")]
        // GET: api/Account
        public IEnumerable<Account> Get(string email)
        {
            AccountService accountService = new AccountService();
            var acc = accountService.GetAccounts(email);
            return acc;
        }

        // GET: api/Account/5
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        [Route("Account/post")]
        public void Post([FromBody]Account account)
        {
            AccountService accountService = new AccountService();
            accountService.AddAccount(account);
        }

        // PUT: api/Account/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Account/5
        public void Delete(int id)
        {
        }
    }
}
