using AXIOMRMQ.Transfer.Domain.Models;
using System.Collections.Generic;

namespace AXIOMRMQ.Transfer.Domain.Interfaces
{
    public interface ITransferRepository
    {
        IEnumerable<TransferLog> GetTransferLogs();
        void Add(TransferLog transfer);
    }
}
