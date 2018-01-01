using System.Collections.Generic;
using TFP.Domain.Entities;

namespace TFP.Domain.Abstract
{
    public interface IAccountsRepository
    {
        IEnumerable<Account> Accounts { get; }
    }
}
