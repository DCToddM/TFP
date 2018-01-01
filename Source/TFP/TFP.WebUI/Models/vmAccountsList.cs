using System.Collections.Generic;
using TFP.Domain.Entities;

namespace TFP.WebUI.Models
{
    public class vmAccountsList
    {
        public IEnumerable<Account> Accounts { get; set; }
        public vmPageInfo PagingInfo { get; set; }
    }
}