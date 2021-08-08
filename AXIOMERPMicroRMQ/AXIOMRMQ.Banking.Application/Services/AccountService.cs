using AXIOMMicroRMQ.Domain.Core.Bus;
using AXIOMRMQ.Banking.Application.Interfaces;
using AXIOMRMQ.Banking.Application.Models;
using AXIOMRMQ.Banking.Domain.Commands;
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
        private readonly IEventBus _bus;
        public AccountService(IAccountRepository accountRepository, IEventBus bus)
        {
            _accountRepository = accountRepository;
            _bus = bus;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        public void Transfer(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand(
                accountTransfer.FromAccount,
                accountTransfer.ToAccount,
                accountTransfer.TransferAmount
                );

            _bus.SendCommand(createTransferCommand);
        }
    }
}
