using AXIOMMicroRMQ.Domain.Core.Bus;
using AXIOMRMQ.Transfer.Domain.Interfaces;
using AXIOMRMQ.Transfer.Application.Interfaces;
using AXIOMRMQ.Transfer.Domain.Models;
using System.Collections.Generic;

namespace AXIOMRMQ.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;
        private readonly IEventBus _bus;
        public TransferService(ITransferRepository transferRepository, IEventBus bus)
        {
            _transferRepository = transferRepository;
            _bus = bus;
        }
        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _transferRepository.GetTransferLogs();
        }

        
    }
}
