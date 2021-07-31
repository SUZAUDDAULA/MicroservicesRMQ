using AXIOMRMQ.Banking.Application.Interfaces;
using AXIOMRMQ.Banking.Domain.Interfaces;
using AXIOMRMQ.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AXIOMRMQ.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }
    }
}
