using TFP.Domain.Abstract;
using TFP.Domain.Entities;
using System.Collections.Generic;

namespace TFP.Domain.Concrete
{
    public class EFAccountRepository : IAccountsRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Account> Accounts
        {
            get { return context.Accounts; }
        }
    }
}
