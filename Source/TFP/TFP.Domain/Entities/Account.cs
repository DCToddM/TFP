using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFP.Domain.Entities
{
    public class Account
    {
        public int AccountID {get; set;}
        public string AccountName { get; set; }
        public decimal AccountBalance { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }

    }
}
