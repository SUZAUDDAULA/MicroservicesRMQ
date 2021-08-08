using AXIOMRMQ.Banking.Application.Models;
using AXIOMRMQ.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AXIOMRMQ.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
        void Transfer(AccountTransfer accountTransfer);
    }
}
