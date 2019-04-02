using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.WS.Entity
{
        public class Account
        {
            public Guid AccountID { set; get; }
            public string email { set; get; }
            public string firstName { set; get; }
            public string lastName { set; get; }
            public string password { set; get; }
            public DateTime birthday { set; get; }
            public int gender { set; get; }
        }
}
